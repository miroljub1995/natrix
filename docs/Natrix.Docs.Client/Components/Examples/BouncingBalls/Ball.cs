namespace Natrix.Docs.Client.Components.Examples.BouncingBalls;

public sealed record Ball(
    double X,
    double Y,
    double VelocityX,
    double VelocityY,
    double Radius,
    string Color)
{
    public Ball(double width, double height, IReadOnlyList<string> colors)
        : this(
            X: Random.Shared.Next(50, (int)width - 50),
            Y: Random.Shared.Next(50, (int)height - 50),
            VelocityX: Random.Shared.Next(-5, 6),
            VelocityY: Random.Shared.Next(-5, 6),
            Radius: Random.Shared.Next(10, 30),
            Color: colors[Random.Shared.Next(colors.Count)])
    {
    }

    public Ball Step(double width, double height)
    {
        var nextX = X + VelocityX;
        var nextY = Y + VelocityY;
        var nextVelocityX = VelocityX;
        var nextVelocityY = VelocityY;

        if (nextX - Radius < 0 || nextX + Radius > width)
        {
            nextVelocityX = -nextVelocityX;
        }

        if (nextY - Radius < 0 || nextY + Radius > height)
        {
            nextVelocityY = -nextVelocityY;
        }

        nextX = Math.Max(Radius, Math.Min(width - Radius, nextX));
        nextY = Math.Max(Radius, Math.Min(height - Radius, nextY));

        return this with
        {
            X = nextX,
            Y = nextY,
            VelocityX = nextVelocityX,
            VelocityY = nextVelocityY,
        };
    }
}
