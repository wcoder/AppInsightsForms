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

		private void CrashClicked(object sender, EventArgs args)
		{
			throw new Exception("Test crash!");
		}

		private void ClickClicked(object sender, EventArgs args)
		{
			App.Insights.TrackEvent("ClickClicked");
		}

		private void ExceptionClicked(object sender, EventArgs args)
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

		private async void GoDetailsClicked(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new DetailsPage());
		}
	}
}
