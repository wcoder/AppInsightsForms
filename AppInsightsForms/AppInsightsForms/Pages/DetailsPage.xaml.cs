using System;
using AI.XamarinSDK.Abstractions;
using Xamarin.Forms;

namespace AppInsightsForms.Pages
{
	public partial class DetailsPage : ContentPage
	{
		public DetailsPage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			TelemetryManager.TrackPageView(GetType().Name);
		}

		private async void BackClicked(object sender, EventArgs args)
		{
			await Navigation.PopAsync();
		}
    }
}
