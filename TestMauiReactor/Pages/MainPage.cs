using MauiReactor;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace TestMauiReactor.Pages;
public enum PageEnum
{
    Login,
    Home,
}

class MainPageState
{
    public PageEnum CurrentPage { get; set; }
}
internal class MainPage : Component<MainPageState>
{
    protected override void OnMounted()
    {
        State.CurrentPage = PageEnum.Login;

        base.OnMounted();
    }

    public override VisualNode Render()
    {
        return RenderBody();
    }

    VisualNode RenderBody()
    {
        switch (State.CurrentPage)
        {
            case PageEnum.Login:
                return new LoginPage()
                        .OnNextPage(nextPage => SetState(s =>
                        {
                            s.CurrentPage = nextPage;
                        }));
            case PageEnum.Home:
                return new HomePage();
        }

        throw new InvalidOperationException();
    }
}