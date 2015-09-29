using System;
using AppInsightsForms.Interfaces;
using Xamarin.Forms;
using AppInsightsForms.Droid;
using AI.XamarinSDK.Abstractions;

[assembly: Dependency(typeof(ApplicationInsightsProvider))]
namespace AppInsightsForms.Droid
{
	class ApplicationInsightsProvider : IInsightsProvider
	{
		public void TrackEvent(string eventName)
		{
			TelemetryManager.TrackEvent(eventName);
		}

		public void TrackException(Exception e)
		{
			TelemetryManager.TrackManagedException(e, true);
		}

		public void TrackPage(string pageName)
		{
			TelemetryManager.TrackPageView(pageName);
		}
	}
}