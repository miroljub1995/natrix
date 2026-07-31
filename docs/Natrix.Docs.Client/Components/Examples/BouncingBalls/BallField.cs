using System.Collections.Immutable;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Examples.BouncingBalls;

/// <summary>
/// Owns the ball simulation. Pure math, so it stays independent of the canvas and
/// of the browser platform.
/// </summary>
public sealed class BallField
{
    private static readonly string[] Colors =
        ["#667eea", "#764ba2", "#f093fb", "#4facfe", "#43e97b", "#fa709a"];

    private readonly Signal<ImmutableList<Ball>> _balls = new([]);

    public required double Width { get; init; }
    public required double Height { get; init; }

    public IReadOnlyList<Ball> Balls => _balls.Value;

    public void Add()
    {
        _balls.Value = _balls.Value.Add(new Ball(Width, Height, Colors));
    }

    public void Clear()
    {
        _balls.Value = [];
    }

    /// <summary>Advances every ball by one frame, bouncing off the edges.</summary>
    public void Step()
    {
        _balls.Value = _balls.Value
            .Select(ball => ball.Step(Width, Height))
            .ToImmutableList();
    }
}
