using System;
using Xamarin.Forms;
using AI.XamarinSDK.Abstractions;
using AppInsightsForms.Interfaces;
using AppInsightsForms.iOS;

[assembly: Dependency(typeof(ApplicationInsightsProvider))]
namespace AppInsightsForms.iOS
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
