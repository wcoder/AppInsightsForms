using AppInsightsForms.Interfaces;
using System;
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

			App.Insights.TrackPage(GetType().Name);
		}

		private void ClickClicked(object sender, EventArgs args)
		{
			App.Insights.TrackEvent("ClickClicked");
		}

		private void HandledExceptionClicked(object sender, EventArgs args)
		{
			try
			{
				throw new Exception("Test Exception!");
			}
			catch (Exception e)
			{
				App.Insights.TrackException(e);
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
