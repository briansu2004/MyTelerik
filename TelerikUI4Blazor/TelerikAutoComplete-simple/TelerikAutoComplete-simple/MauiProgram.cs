using Microsoft.AspNetCore.Components.WebView.Maui;
using TelerikAutoComplete_simple.Data;

namespace TelerikAutoComplete_simple;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.RegisterBlazorMauiWebView()
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddBlazorWebView();
		builder.Services.AddSingleton<WeatherForecastService>();
		builder.Services.AddScoped(sp => new HttpClient {});

		return builder.Build();
	}
}
