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

		private void ClickClicked(object sender, EventArgs args)
		{
		}

		private void ExceptionClicked(object sender, EventArgs args)
		{
		}

		private async void GoDetailsClicked(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new DetailsPage());
		}
	}
}
