using System.Runtime.InteropServices.JavaScript;
using System.Runtime.Versioning;
using Natrix.Core.Components;
using Natrix.Dom.Components;
using Natrix.JSCore;
using Natrix.Signals;
using Natrix.StdWeb;

namespace Natrix.Docs.Client.Components.Examples.BouncingBalls;

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

        void AddBall()
        {
            field.Add();
            ballCount.Value = field.Count;
        }

        void ClearBalls()
        {
            field.Clear();
            ballCount.Value = field.Count;
        }

        OnMounted(onUnmounted =>
        {
            if (!OperatingSystem.IsBrowser())
            {
                return;
            }

            var canvas = canvasRef.Value;
            if (canvas is null)
            {
                return;
            }

            StartAnimation(canvas, field, AddBall, ClearBalls, onUnmounted);
        });

        return
        [
            new DemoCard
            {
                Props = new DemoCardProps
                {
                    Title = "Bouncing Balls".ToConstSignal(),
                },
                Slots = new DemoCardSlots
                {
                    Default = () =>
                    [
                        new Canvas
                        {
                            Ref = canvasRef,
                            Props = new CanvasProps
                            {
                                Width = CanvasWidth.ToConstSignal(),
                                Height = CanvasHeight.ToConstSignal(),
                                Class = "block w-full h-auto rounded-md border border-gray-200 dark:border-gray-700 bg-white".ToConstSignal(),
                            },
                        },
                        new Div
                        {
                            Props = new DivProps
                            {
                                Class = "mt-4 flex flex-wrap items-center gap-3".ToConstSignal(),
                            },
                            Children =
                            [
                                new DemoButton
                                {
                                    Props = new DemoButtonProps
                                    {
                                        Label = "Add Ball".ToConstSignal(),
                                    },
                                    Events = new DemoButtonEvents { OnClick = AddBall },
                                },
                                new DemoButton
                                {
                                    Props = new DemoButtonProps
                                    {
                                        Label = "Clear All".ToConstSignal(),
                                        Variant = DemoButtonVariant.Secondary.ToConstSignal(),
                                    },
                                    Events = new DemoButtonEvents { OnClick = ClearBalls },
                                },
                                new Span
                                {
                                    Props = new SpanProps
                                    {
                                        Class = "text-sm text-gray-500 dark:text-gray-400".ToConstSignal(),
                                    },
                                    Children =
                                    [
                                        new DomText
                                        {
                                            Text = new Computed<string>(() => $"Balls: {ballCount.Value}"),
                                        },
                                    ],
                                },
                            ],
                        },
                    ],
                },
            },
        ];
    }

    [SupportedOSPlatform("browser")]
    private static void StartAnimation(
        HTMLCanvasElement canvas,
        BallField field,
        Action addBall,
        Action clearBalls,
        Action<Action> onUnmounted)
    {
        CanvasRenderingContext2D? ctx = null;
        if (canvas.GetContext("2d")?.TryCast(out ctx) != true || ctx is null)
        {
            return;
        }

        var window = JSObjectProxyFactory.GetProxy<Window>(JSHost.GlobalThis);

        for (var i = 0; i < 5; i++)
        {
            addBall();
        }

        var stopped = false;
        uint handle = 0;
        FrameRequestCallback? frameCallback = null;

        frameCallback = new FrameRequestCallback(_ =>
        {
            if (stopped)
            {
                return;
            }

            field.Step();
            RenderFrame(ctx, field);
            handle = window.RequestAnimationFrame(frameCallback!);
        });

        handle = window.RequestAnimationFrame(frameCallback);

        // The route unmounts when navigating away, so the loop must be stopped
        // explicitly or it keeps drawing into a detached canvas forever.
        onUnmounted(() =>
        {
            stopped = true;
            window.CancelAnimationFrame(handle);
            clearBalls();
        });
    }

    [SupportedOSPlatform("browser")]
    private static void RenderFrame(CanvasRenderingContext2D ctx, BallField field)
    {
        ctx.ClearRect(0, 0, CanvasWidth, CanvasHeight);

        foreach (var ball in field.Balls)
        {
            ctx.BeginPath();
            ctx.Arc(ball.X, ball.Y, ball.Radius, 0, Math.PI * 2);
            ctx.FillStyle = ball.Color;
            ctx.Fill();
            ctx.ClosePath();
        }
    }
}
