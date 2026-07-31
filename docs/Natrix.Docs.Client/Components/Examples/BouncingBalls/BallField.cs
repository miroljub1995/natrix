namespace Natrix.Docs.Client.Components.Examples.BouncingBalls;

/// <summary>
/// Owns the ball simulation. Pure math, so it stays independent of the canvas and
/// of the browser platform.
/// </summary>
public sealed class BallField
{
    private static readonly string[] Colors =
        ["#667eea", "#764ba2", "#f093fb", "#4facfe", "#43e97b", "#fa709a"];

    private readonly Random _random = new();
    private readonly List<Ball> _balls = [];

    public required double Width { get; init; }
    public required double Height { get; init; }

    public IReadOnlyList<Ball> Balls => _balls;

    public int Count => _balls.Count;

    public void Add()
    {
        _balls.Add(new Ball
        {
            X = _random.Next(50, (int)Width - 50),
            Y = _random.Next(50, (int)Height - 50),
            VelocityX = _random.Next(-5, 6),
            VelocityY = _random.Next(-5, 6),
            Radius = _random.Next(10, 30),
            Color = Colors[_random.Next(Colors.Length)],
        });
    }

    public void Clear()
    {
        _balls.Clear();
    }

    /// <summary>Advances every ball by one frame, bouncing off the edges.</summary>
    public void Step()
    {
        foreach (var ball in _balls)
        {
            ball.X += ball.VelocityX;
            ball.Y += ball.VelocityY;

            if (ball.X - ball.Radius < 0 || ball.X + ball.Radius > Width)
            {
                ball.VelocityX = -ball.VelocityX;
            }

            if (ball.Y - ball.Radius < 0 || ball.Y + ball.Radius > Height)
            {
                ball.VelocityY = -ball.VelocityY;
            }

            ball.X = Math.Max(ball.Radius, Math.Min(Width - ball.Radius, ball.X));
            ball.Y = Math.Max(ball.Radius, Math.Min(Height - ball.Radius, ball.Y));
        }
    }
}
