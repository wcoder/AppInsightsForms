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

		private async void BackClicked(object sender, EventArgs args)
		{
			await Navigation.PopAsync();
		}
    }
}
