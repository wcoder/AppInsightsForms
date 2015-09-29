using System;
using Xamarin.Forms;
using AppInsightsForms.Pages;
using AppInsightsForms.Interfaces;

namespace AppInsightsForms
{
	public class App : Application
	{
		public static IInsightsProvider Insights { get; private set; }

		public App()
		{
			// The root page of your application
			MainPage = new NavigationPage(new MainPage());

			Insights = DependencyService.Get<IInsightsProvider>();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
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
			Insights.TrackException(e);
		}
	}
}
