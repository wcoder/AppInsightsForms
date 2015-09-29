using System;
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

			App.Insights.TrackPage(GetType().Name);
		}

		private async void BackClicked(object sender, EventArgs args)
		{
			await Navigation.PopAsync();
		}
    }
}
