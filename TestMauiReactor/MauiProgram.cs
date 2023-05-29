using MauiReactor;
using TestMauiReactor.Pages;


namespace TestMauiReactor
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiReactorApp<MainPage>(app =>
                {
                    app.AddResource("Resources/Styles/Colors.xaml");
                    app.AddResource("Resources/Styles/Styles.xaml");

                    app.SetWindowsSpecificAssectDirectory("Assets");
                })
#if DEBUG
            .EnableMauiReactorHotReload()
#endif
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-SemiBold.ttf", "OpenSansSemiBold");
                    fonts.AddFont("Barlow-Light.otf", "BarlowLight");
                    fonts.AddFont("Barlow-Medium.otf", "BarlowMedium");
                    fonts.AddFont("Barlow-Regular.otf", "BarlowRegular");
                    fonts.AddFont("Barlow-SemiBold.otf", "BarlowSemiBold");
                    fonts.AddFont("JungleFever.ttf", "JungleFever");
                });

            return builder.Build();
        }
    }
}