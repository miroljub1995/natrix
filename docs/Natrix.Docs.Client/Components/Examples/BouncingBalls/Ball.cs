namespace Natrix.Docs.Client.Components.Examples.BouncingBalls;

public sealed class Ball
{
    public double X { get; set; }
    public double Y { get; set; }
    public double VelocityX { get; set; }
    public double VelocityY { get; set; }
    public required double Radius { get; init; }
    public required string Color { get; init; }
}
