using System;
using System.Threading.Tasks;
using CoreLocation;
using Foundation;
using UIKit;
using MapKit;

namespace Samples
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			MyMapView.MapType = MKMapType.Hybrid;

			MyMapView.ShowsUserLocation = true;
			MyMapView.SetUserTrackingMode(MKUserTrackingMode.Follow, true);

			MyMapView.RegionChanged += async (sender, e) =>
			{
				TxtLatitude.Text = MyMapView.CenterCoordinate.Latitude.ToString();
				TxtLongitude.Text = MyMapView.CenterCoordinate.Longitude.ToString();
				TxtLatitude.ResignFirstResponder();
				TxtLongitude.ResignFirstResponder();
				TxtAddress.Text = string.Empty;
				await ReverseGeocodeToConsoleAsync();
			};

			BtnPlus.TouchUpInside += (sender, e) =>
			{
				MKCoordinateSpan span;
				span.LatitudeDelta = MyMapView.Region.Span.LatitudeDelta / 2f;
				span.LongitudeDelta = MyMapView.Region.Span.LongitudeDelta / 2f;

				MKCoordinateRegion region;
				region.Span = span;
				region.Center = MyMapView.Region.Center;

				MyMapView.SetRegion(region, true);
			};

			BtnMinus.TouchUpInside += (sender, e) =>
			{

				MKCoordinateSpan span;
				span.LatitudeDelta = MyMapView.Region.Span.LatitudeDelta * 2f;
				span.LongitudeDelta = MyMapView.Region.Span.LongitudeDelta * 2f;

				MKCoordinateRegion region;
				region.Span = span;
				region.Center = MyMapView.Region.Center;

				MyMapView.SetRegion(region, true);
			};

		}

		async Task<string> ReverseGeocodeToConsoleAsync()
		{
			var Latitude = Convert.ToDouble(TxtLatitude.Text);
			var Longitude = Convert.ToDouble(TxtLongitude.Text);

			var location = new CLLocation(Latitude, Longitude);
			var geoCoder = new CLGeocoder();
			var placemarks = await geoCoder.ReverseGeocodeLocationAsync(location);

			foreach (var placemark in placemarks)
			{
				TxtAddress.Text = placemark.AddressDictionary.ToString();
			}

			return string.Empty;
		}
	}
}
