using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace BuildStuff14.Droid
{
    [Activity(Label = "ConferenceDetails")]
    public class ConferenceDetailsActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.ConferenceDetails);

            Button hotelButton = FindViewById<Button>(Resource.Id.hotel_location);

            hotelButton.Click += delegate { ShowHotelLocation(); };
        }

        protected void ShowHotelLocation()
        {
            var geoUri = Android.Net.Uri.Parse("geo:0,0?q=Radisson+Blue+Hotel+LietuvaKonstitucijos+prospektas+20+Vilnius+Lithuania");
            var mapIntent = new Intent(Intent.ActionView, geoUri);
            StartActivity(mapIntent);
        }


    }
}