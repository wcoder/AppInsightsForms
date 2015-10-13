using System;
using AI.XamarinSDK.Abstractions;
using Xamarin.Forms;
using AppInsightsForms.Pages;

namespace AppInsightsForms
{
	public class App : Application
	{
		public App()
		{
			// The root page of your application
			MainPage = new NavigationPage(new MainPage());
		}

		protected override void OnStart()
		{
			// Handle when your app starts
			string iKey = null;
			Device.OnPlatform(
				Android: () => {
					iKey = Constants.ApplicationInsightsAndroidKey;
				},
				iOS: () => {
					iKey = Constants.ApplicationInsightsiOSKey;
				}
			);
			ApplicationInsights.Setup(iKey);
			ApplicationInsights.Start();
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}

		public static void UnhandledException(Exception e)
		{
			TelemetryManager.TrackTrace(e.Message);
		}
	}
}
