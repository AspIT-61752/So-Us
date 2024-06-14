using Microsoft.Extensions.Logging;
using SoUs.CareApp.ViewModels;
using SoUs.CareApp.Views;
using SoUs.Services;

namespace SoUs.CareApp
{
    public static class MauiProgram
    {

        //private const string uriString = "https://localhost:7096/api/";
        private const string uriString = "https://10.0.2.2:7096/api/";

        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

            Uri baseUri = new Uri(uriString);

            builder.Services.AddScoped<ISosuService>(x => new SosuService(baseUri));
            builder.Services.AddSingleton<IUserService, UserService>();

            builder.Services.AddSingleton<MainPageViewModel>();
            builder.Services.AddSingleton<MainPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
