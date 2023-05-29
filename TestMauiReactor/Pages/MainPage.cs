using MauiReactor;

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
                new ScrollView
                {
                    new VerticalStackLayout
                    {
                    }
                    .VCenter()
                    .Spacing(25)
                    .Padding(30, 0)
                }
            };
        }
    }
}