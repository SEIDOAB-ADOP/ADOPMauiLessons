using ADOPMAUI_Lessons.Services;
using ADOPMAUI_Lessons.ViewModels;

namespace ADOPMAUI_Lessons;

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
			});

        //DependencyService.Resolve will get a new instance of PrimePageViewModel
        DependencyService.Register<PrimePageViewModel>();

        //DependencyService.Resolve<IPrimeNumberService> will get the singleton instance of PrimeNumberService
        DependencyService.RegisterSingleton<IPrimeNumberService>(new PrimeNumberService());

		return builder.Build();
	}
}
