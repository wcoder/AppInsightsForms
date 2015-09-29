using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using AI.XamarinSDK.Abstractions;

namespace AppInsightsForms.iOS
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		//
		// This method is invoked when the application has loaded and is ready to run. In this 
		// method you should instantiate the window, load the UI into it and then make the window
		// visible.
		//
		// You have 17 seconds to return from this method, or iOS will terminate your application.
		//
		public override bool FinishedLaunching(UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init();
			LoadApplication(new App());

			AI.XamarinSDK.iOS.ApplicationInsights.Init();
			ApplicationInsights.Setup("f768a00a-8d1c-4fe7-a3c5-2c2f92b9d5ba");
			ApplicationInsights.Start();

			return base.FinishedLaunching(app, options);
		}
	}
}
