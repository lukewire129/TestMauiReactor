using MauiReactor;
using System;

namespace TestMauiReactor.Pages
{
    internal class MainPageState
    {
        public int Counter { get; set; }
    }

    internal class MainPage : Component<MainPageState>
    {
        public override VisualNode Render()
        {
            return new ContentPage
            {
                new Grid()
                {
                    new FireFitLogo(),

                    new Sign()
                }
            }
            .Background(new Microsoft.Maui.Controls.LinearGradientBrush()
            {
                StartPoint = new Point(0, 1),
                EndPoint = new Point(1, 0),
                GradientStops = new Microsoft.Maui.Controls.GradientStopCollection()
                            {
                                new Microsoft.Maui.Controls.GradientStop(Color.FromArgb("535cdd"), Convert.ToSingle(0.0)),
                                new Microsoft.Maui.Controls.GradientStop(Color.FromArgb("667fe6"), Convert.ToSingle(1.1))
                            }
            }
            );
        }
    }

    public class FireFitLogo : Component
    {
        public override VisualNode Render()
        {
            return new VStack(10)
            {
                new Image("logo")
                    .WidthRequest(130),

                new VStack(-10)
                {
                    new Label("FIREFIT")
                    .FontFamily("JungleFever")
                    .FontAttributes(Microsoft.Maui.Controls.FontAttributes.Bold)
                    .FontSize(50)
                    .HCenter(),

                    new Label("Stay in shape, stay healthy")
                    .FontFamily("JungleFever")
                    .FontSize(25)
                }


            }
            .VCenter()
            .HCenter();
        }
    }

    public class Sign : Component
    {
        public override VisualNode Render()
        {
            return new VStack(20)
            {
                ButtonTemplate()
                .Text("Sign Up")
                .TextColor(Colors.White)
                .Background(new Microsoft.Maui.Controls.LinearGradientBrush()
                {
                    StartPoint = new Point(0, 1),
                    EndPoint = new Point(1, 0),
                    GradientStops = new Microsoft.Maui.Controls.GradientStopCollection()
                                {
                                    new Microsoft.Maui.Controls.GradientStop(Color.FromArgb("fe5b53"), Convert.ToSingle(0.0)),
                                    new Microsoft.Maui.Controls.GradientStop(Color.FromArgb("ff826c"), Convert.ToSingle(1.1))
                                }
                }),

                ButtonTemplate()
                .TextColor(Color.FromArgb("e16c5e"))
                .Text("Login"),

                new Label("Forgot your password?")
                .TextColor(Colors.White)
                .HCenter()
                .FontFamily("BarlowBold")
                .FontSize(25)
            }
            .VEnd()
            .Margin(0, 0, 0, 150);
        }

        Button ButtonTemplate() => new Button()
                                .CornerRadius(40)
                                .HeightRequest(60)
                                .WidthRequest(230)
                                .FontSize(32);
    }

    
}