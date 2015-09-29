using Xamarin.Forms;
using AppInsightsForms.Interfaces;
using AppInsightsForms.Droid;

[assembly: Dependency(typeof(NativeExceptionService))]
namespace AppInsightsForms.Droid
{
	class NativeExceptionService : INativeExceptionService
	{
		public void ManagedException()
		{
			throw new Java.Lang.NullPointerException();
		}

		public void UnmanagedException()
		{
			DependencyService.Get<IDummyLibrary>().TriggerExceptionCrash();
		}
	}
}