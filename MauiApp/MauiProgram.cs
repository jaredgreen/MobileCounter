using Core.Interfaces;
using Core.Services;
using Core.ViewModels;

namespace MobileCounter;

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
			.RegisterPages()
			.RegisterViewModels()
			.RegisterServices();

#if DEBUG
		//builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
	
	private static MauiAppBuilder RegisterPages(this MauiAppBuilder builder)
	{
		builder.Services.AddTransient<MainPage>();

		return builder;
	}
    
    private static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
    {
        builder.Services.AddTransient<MainPageViewModel>();
        
        return builder; 
    }

    private static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
    {
        builder.Services.AddTransient<ICountingService, CountingService>();
        
        return builder;
    }
}