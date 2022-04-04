using Microsoft.AspNetCore.Components.WebView.Maui;
using Telerik_AutoComplete_Maui_Blazor.Data;

namespace Telerik_AutoComplete_Maui_Blazor;

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

		builder.Services.AddScoped(sp => new HttpClient { });
		builder.Services.AddTelerikBlazor();

		//builder.RootComponents.Add<App>("#app");
		//builder.RootComponents.Add<HeadOutlet>("head::after");

		//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

		//// register the Telerik services
		//builder.Services.AddTelerikBlazor();

		//await builder.Build().RunAsync();

		return builder.Build();
	}
}
