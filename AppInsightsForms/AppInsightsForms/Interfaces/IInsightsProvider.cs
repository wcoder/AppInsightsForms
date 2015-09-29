using System;

namespace AppInsightsForms.Interfaces
{
	public interface IInsightsProvider
	{
		void TrackException(Exception e);

		void TrackEvent(string eventName);

		void TrackPage(string pageName);
	}
}
