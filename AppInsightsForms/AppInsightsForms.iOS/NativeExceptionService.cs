using System;
using Xamarin.Forms;
using AppInsightsForms.Interfaces;
using AppInsightsForms.iOS;

[assembly: Dependency(typeof(NativeExceptionService))]
namespace AppInsightsForms.iOS
{
	class NativeExceptionService : INativeExceptionService
	{
		public void ManagedException()
		{
			throw new NotImplementedException();
		}

		public void UnmanagedException()
		{
			DependencyService.Get<IDummyLibrary>().TriggerExceptionCrash();
		}
	}
}
