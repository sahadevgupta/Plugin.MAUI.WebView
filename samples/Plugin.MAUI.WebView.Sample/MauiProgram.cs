using Microsoft.Extensions.DependencyInjection;
using Microsoft.Maui.Controls.Compatibility.Hosting;
using Plugin.Maui.Feature;
using Plugin.MAUI.WebView;

namespace Plugin.Maui.Feature.Sample;

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
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.ConfigureMauiHandlers(handlers =>
			{
#if ANDROID
				handlers.AddHandler(typeof(FormsWebView), typeof(FormsWebViewRenderer));
#endif
			});

		builder.Services.AddTransient<MainPage>();

		return builder.Build();
	}
}