using ProjectReminderApplicationThesis66.ViewModels;
using ProjectReminderApplicationThesis66.Views;
using CommunityToolkit.Maui;
//using ProjectReminderApplicationThesis66.Models;


namespace ProjectReminderApplicationThesis66;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
        // Initialise the toolkit
        builder.UseMauiApp<App>().UseMauiCommunityToolkit();
        builder
			.UseMauiApp<App>()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("Mitr-Bold.ttf", "Mitr-Bold");
                fonts.AddFont("Mitr-SemiBold.ttf", "Mitr-SemiBold");
                fonts.AddFont("Mitr-Regular.ttf", "Mitr-Regular");
                fonts.AddFont("Mitr-Medium.ttf", "Mitr-Medium");
                fonts.AddFont("Mitr-Light.ttf", "Mitr-Light");
                fonts.AddFont("Mitr-ExtraLight.ttf", "Mitr-ExtraLight");
            });

        builder.Services.AddSingleton<SignupPage>();
        builder.Services.AddSingleton<SignupPageVM>();
        builder.Services.AddSingleton<LoginPage>();
        builder.Services.AddSingleton<LoginPageVM>();
        builder.Services.AddSingleton<MainPage>();
        builder.Services.AddSingleton<MainPageVM>();
        //builder.Services.AddSingleton<PillreminderPage>();
        //builder.Services.AddSingleton<PillreminderPageVM>();
        //builder.Services.AddSingleton<ProfilePage>();
        //builder.Services.AddSingleton<ProfilePageVM>();
        //builder.Services.AddSingleton<SettingPage>();
        //builder.Services.AddSingleton<SettingPageVM>();
        //builder.Services.AddSingleton<SetupProfilePage>();
        //builder.Services.AddSingleton<SetupProfilePageVM>();
        //builder.Services.AddSingleton<UserActionLogPage>();
        //builder.Services.AddSingleton<UserActionLogViewModel>();


        return builder.Build();
	}

    public interface IAlarmService
    {
        void SetAlarm(DateTime alarmTime, string title, string message);
        void CancelAlarm();
    }

}
