using Microsoft.AspNetCore.Components.WebView.Maui;
using FinalProjectMAUIAPP.Data;
using Microsoft.Extensions.Configuration;

namespace FinalProjectMAUIAPP
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });

            builder.Services.AddMauiBlazorWebView();
#if DEBUG
            builder.Services.AddBlazorWebViewDeveloperTools();
#endif

            // Add your configuration options here
            builder.Configuration.AddInMemoryCollection(new Dictionary<string, string>
            {
                { "ConnectionStrings:DefaultConnection", "Server=127.0.01;Database=blazormauiappdb;Uid=root;Pwd=password;" }
            });

            // Register the DbContext and EventRepository in the dependency injection container
            builder.Services.AddSingleton<DbContext>();
            builder.Services.AddSingleton<EventRepository>();

            builder.Services.AddSingleton<WeatherForecastService>();

            return builder.Build();
        }
    }
}
