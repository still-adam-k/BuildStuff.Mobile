using Android.App;
using Android.Content;
using Android.OS;
using Android.Webkit;


namespace BuildStuff14.Droid
{
    [Activity(Label = "@string/app_name", MainLauncher = true, Icon = "@drawable/buildstuff14")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var conferenceDetails = new Intent(this, typeof (ConferenceDetailsActivity));
            StartActivity(conferenceDetails);

            //var webView = FindViewById<WebView>(Resource.Id.LocalWebView);
            //webView.Settings.JavaScriptEnabled = true;
            //webView.LoadUrl("http://buildstuff.lt/#speakers");
        }
    }
}
