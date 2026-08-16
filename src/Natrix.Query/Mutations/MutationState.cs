namespace Natrix.Query;

/// <summary>
/// Where a mutation is in its lifecycle — the counterpart of TanStack Query's mutation
/// <c>status</c>.
/// </summary>
public enum MutationStatus
{
    /// <summary>Never run.</summary>
    Idle,

    /// <summary>Running right now.</summary>
    Pending,

    /// <summary>Finished successfully.</summary>
    Success,

    /// <summary>Failed.</summary>
    Error,
}

/// <summary>
/// Everything a mutation keeps about its current (or last) run. Immutable: each transition
/// produces a new instance.
/// </summary>
public sealed record MutationState
{
    /// <summary>What the mutation function returned.</summary>
    public object? Data { get; init; }

    /// <summary>Whether <see cref="Data"/> holds a real value.</summary>
    public bool HasData { get; init; }

    /// <summary>The error the mutation failed with.</summary>
    public Exception? Error { get; init; }

    /// <summary>The variables the mutation was called with.</summary>
    public object? Variables { get; init; }

    /// <summary>Whether <see cref="Variables"/> was set — a mutation may legitimately take <c>null</c>.</summary>
    public bool HasVariables { get; init; }

    /// <summary>Whatever <c>OnMutate</c> returned, carried through to the other callbacks.</summary>
    public object? Context { get; init; }

    /// <summary>How many attempts have failed.</summary>
    public int FailureCount { get; init; }

    /// <summary>The error behind the most recent failed attempt.</summary>
    public Exception? FailureReason { get; init; }

    /// <summary>Whether the mutation is waiting for the connection to come back.</summary>
    public bool IsPaused { get; init; }

    /// <inheritdoc cref="MutationStatus" />
    public MutationStatus Status { get; init; } = MutationStatus.Idle;

    /// <summary>When the current run started, in Unix milliseconds.</summary>
    public long SubmittedAt { get; init; }
}

/// <summary>
/// Groups mutations that must not run at the same time. Two mutations sharing a scope id run
/// one after another, in the order they were fired — what you want when they write the same
/// resource.
/// </summary>
/// <param name="Id">The scope's identity.</param>
public sealed record MutationScope(string Id);
