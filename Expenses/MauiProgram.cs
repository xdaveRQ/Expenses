using Expenses.MVVM.Repository;
using Expenses.MVVM.View;
using Microsoft.Extensions.Logging;

namespace Expenses;

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

		builder.Services.AddSingleton<IncomeRepository>();
        builder.Services.AddTransient<IncomeView>();


#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
