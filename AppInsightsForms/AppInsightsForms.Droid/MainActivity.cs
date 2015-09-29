using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using AI.XamarinSDK.Abstractions;

namespace AppInsightsForms.Droid
{
	[Activity(Label = "ApplicationInsightsXFormsDemo", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);
			LoadApplication(new App());
		}

		protected override void OnStart()
		{
			base.OnStart();

			ApplicationInsights.Setup("9428baae-1fd2-45d9-9e40-fb468a721043");
			ApplicationInsights.Start();
		}
	}
}

