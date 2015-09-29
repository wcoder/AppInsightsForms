using AppInsightsForms.Interfaces;
using AppInsightsForms.iOS;
using DummyLibrary.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(DummyLibraryIOS))]
namespace AppInsightsForms.iOS
{
	public class DummyLibraryIOS : IDummyLibrary
	{
		public DummyLibraryIOS() { }

		public void TriggerSignalCrash()
		{
			ExamplePlugin.TriggerSignalCrash();
		}

		public void TriggerExceptionCrash()
		{
			ExamplePlugin.TriggerExceptionCrash();
		}
	}
}
