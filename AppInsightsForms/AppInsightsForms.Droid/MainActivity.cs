using Android.App;
using Android.Content.PM;
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

			ApplicationInsights.Setup(Constants.ApplicationInsightsAndroidKey);
			ApplicationInsights.Start();
		}
	}
}

