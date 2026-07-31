using Natrix.Core.Components;
using Natrix.Signals;

namespace Natrix.Docs.Client.Components.Examples.BouncingBalls;

public class BouncingBallsExamplePage : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
{
    private const string FieldSource = """
        public sealed class Ball
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double VelocityX { get; set; }
            public double VelocityY { get; set; }
            public required double Radius { get; init; }
            public required string Color { get; init; }
        }

        // Pure math, so it stays independent of the canvas and of the browser platform.
        public sealed class BallField
        {
            private readonly List<Ball> _balls = [];

            public required double Width { get; init; }
            public required double Height { get; init; }

            public IReadOnlyList<Ball> Balls => _balls;
            public int Count => _balls.Count;

            public void Add() { /* push a randomized ball */ }
            public void Clear() => _balls.Clear();

            public void Step()
            {
                foreach (var ball in _balls)
                {
                    ball.X += ball.VelocityX;
                    ball.Y += ball.VelocityY;

                    if (ball.X - ball.Radius < 0 || ball.X + ball.Radius > Width)
                        ball.VelocityX = -ball.VelocityX;

                    if (ball.Y - ball.Radius < 0 || ball.Y + ball.Radius > Height)
                        ball.VelocityY = -ball.VelocityY;
                }
            }
        }
        """;

    private const string DemoSource = """
        public class BouncingBallsDemo : BaseComponent<NoProps, NoEvents, NoSlots, NoExpose>
        {
            private const uint CanvasWidth = 800;
            private const uint CanvasHeight = 600;

            protected override IComponent[] Setup(out NoExpose exposed)
            {
                exposed = default;

                var canvasRef = new Signal<HTMLCanvasElement?>(null);
                var ballCount = new Signal<int>(0);
                var field = new BallField { Width = CanvasWidth, Height = CanvasHeight };

                void AddBall() { field.Add(); ballCount.Value = field.Count; }
                void ClearBalls() { field.Clear(); ballCount.Value = field.Count; }

                OnMounted(onUnmounted =>
                {
                    if (!OperatingSystem.IsBrowser()) return;

                    var canvas = canvasRef.Value;
                    if (canvas is null) return;

                    CanvasRenderingContext2D? ctx = null;
                    if (canvas.GetContext("2d")?.TryCast(out ctx) != true || ctx is null) return;

                    var window = JSObjectProxyFactory.GetProxy<Window>(JSHost.GlobalThis);

                    for (var i = 0; i < 5; i++) AddBall();

                    var stopped = false;
                    uint handle = 0;
                    FrameRequestCallback? frameCallback = null;

                    frameCallback = new FrameRequestCallback(_ =>
                    {
                        if (stopped) return;

                        field.Step();
                        RenderFrame(ctx, field);
                        handle = window.RequestAnimationFrame(frameCallback!);
                    });

                    handle = window.RequestAnimationFrame(frameCallback);

                    // Stop the loop when the route unmounts.
                    onUnmounted(() =>
                    {
                        stopped = true;
                        window.CancelAnimationFrame(handle);
                        ClearBalls();
                    });
                });

                return
                [
                    new Canvas
                    {
                        Ref = canvasRef,
                        Props = new CanvasProps
                        {
                            Width = CanvasWidth.ToConstSignal(),
                            Height = CanvasHeight.ToConstSignal(),
                        },
                    },
                    new Button
                    {
                        Props = new ButtonProps(),
                        Events = new ButtonEvents { OnClick = _ => AddBall() },
                        Children = [new DomText { Text = "Add Ball".ToConstSignal() }],
                    },
                    new Button
                    {
                        Props = new ButtonProps(),
                        Events = new ButtonEvents { OnClick = _ => ClearBalls() },
                        Children = [new DomText { Text = "Clear All".ToConstSignal() }],
                    },
                    new Span
                    {
                        Props = new SpanProps(),
                        Children =
                        [
                            new DomText
                            {
                                Text = new Computed<string>(() => $"Balls: {ballCount.Value}"),
                            },
                        ],
                    },
                ];
            }
        }
        """;

    protected override IComponent[] Setup(out NoExpose exposed)
    {
        exposed = default;

        return
        [
            new ExamplePage
            {
                Props = new ExamplePageProps
                {
                    Title = "Canvas".ToConstSignal(),
                    Id = "canvas-example".ToConstSignal(),
                    Description = "A bouncing balls animation showing how to reach the raw Canvas API through a component Ref, and how to drive requestAnimationFrame from OnMounted while cleaning it up on unmount. The simulation lives in a plain class so it stays testable and platform independent.".ToConstSignal(),
                },
                Slots = new ExamplePageSlots
                {
                    Demo = () => [new BouncingBallsDemo { Props = new NoProps() }],
                    Source = () =>
                    [
                        new CodeBlock
                        {
                            Props = new CodeBlockProps
                            {
                                Title = "BallField.cs".ToConstSignal(),
                                Code = FieldSource.ToConstSignal(),
                            },
                        },
                        new CodeBlock
                        {
                            Props = new CodeBlockProps
                            {
                                Title = "BouncingBallsDemo.cs".ToConstSignal(),
                                Code = DemoSource.ToConstSignal(),
                            },
                        },
                    ],
                },
            },
        ];
    }
}
