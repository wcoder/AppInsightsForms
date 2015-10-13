using AppInsightsForms.Interfaces;
using System;
using AI.XamarinSDK.Abstractions;
using Xamarin.Forms;

namespace AppInsightsForms.Pages
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

			NavigationPage.SetHasNavigationBar(this, false);
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			TelemetryManager.TrackPageView(GetType().Name);
		}

		private void ClickClicked(object sender, EventArgs args)
		{
			TelemetryManager.TrackEvent("ClickClicked");
		}

		private void HandledExceptionClicked(object sender, EventArgs args)
		{
			try
			{
				throw new Exception("Test Exception!");
			}
			catch (Exception e)
			{
				TelemetryManager.TrackTrace(e.Message);
			}
		}

		private void UnhandledExceptionClicked(object sender, EventArgs args)
		{
			int value = 1 / int.Parse("0");
		}

		private void ManagedExceptionClicked(object sender, EventArgs args)
		{
			DependencyService.Get<INativeExceptionService>().ManagedException();
		}

		private void UnmanagedExceptionClicked(object sender, EventArgs args)
		{
			DependencyService.Get<INativeExceptionService>().UnmanagedException();
		}

		private async void GoDetailsClicked(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new DetailsPage());
		}
	}
}
