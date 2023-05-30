using MauiReactor;
using System;

namespace TestMauiReactor.Pages;

class LoginPageState
{
    public bool LoggingIn { get; set; }
}
internal class LoginPage : Component<LoginPageState>
{
    Action<PageEnum> _nextPage;
    public LoginPage OnNextPage(Action<PageEnum> nextPage)
    {
        this._nextPage = nextPage;
        return this;
    }

    public override VisualNode Render()
    {
        return new ContentPage
        {
            new Grid()
            {
                new FireFitLogo(),

                new VStack(20)
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
            .Text("Login")
            .OnClicked(()=>
            {
                this._nextPage?.Invoke(PageEnum.Home);
            }),

            new Label("Forgot your password?")
            .TextColor(Colors.White)
            .HCenter()
            .FontFamily("BarlowBold")
            .FontSize(25)
        }
        .VCenter()
        .Margin(0, 700, 0, 0)
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
        });
    }

    Button ButtonTemplate() => new Button()
                           .CornerRadius(40)
                           .HeightRequest(70)
                           .WidthRequest(230)
                           .FontSize(30);
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