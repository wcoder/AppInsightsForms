using Com.Microsoft.AI.Xamarinexample;
using Xamarin.Forms;
using Android.App;
using AppInsightsForms.Droid;
using AppInsightsForms.Interfaces;

[assembly: Dependency(typeof(DummyLibraryAndroid))]
namespace AppInsightsForms.Droid
{
	public class DummyLibraryAndroid : Java.Lang.Object, IDummyLibrary
	{
		public DummyLibraryAndroid()
		{
		}

		public void TriggerExceptionCrash()
		{
			ExampleClass library = new ExampleClass();
			library.ForceAppCrash((Activity)Forms.Context);
		}
	}
}