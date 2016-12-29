// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Samples
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		UIKit.UIButton BtnGetAddress { get; set; }

		[Outlet]
		UIKit.UIButton BtnMinus { get; set; }

		[Outlet]
		UIKit.UIButton BtnPlus { get; set; }

		[Outlet]
		MapKit.MKMapView MyMapView { get; set; }

		[Outlet]
		UIKit.UITextView TxtAddress { get; set; }

		[Outlet]
		UIKit.UITextField TxtLatitude { get; set; }

		[Outlet]
		UIKit.UITextField TxtLongitude { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (BtnPlus != null) {
				BtnPlus.Dispose ();
				BtnPlus = null;
			}

			if (BtnMinus != null) {
				BtnMinus.Dispose ();
				BtnMinus = null;
			}

			if (BtnGetAddress != null) {
				BtnGetAddress.Dispose ();
				BtnGetAddress = null;
			}

			if (MyMapView != null) {
				MyMapView.Dispose ();
				MyMapView = null;
			}

			if (TxtAddress != null) {
				TxtAddress.Dispose ();
				TxtAddress = null;
			}

			if (TxtLatitude != null) {
				TxtLatitude.Dispose ();
				TxtLatitude = null;
			}

			if (TxtLongitude != null) {
				TxtLongitude.Dispose ();
				TxtLongitude = null;
			}
		}
	}
}
