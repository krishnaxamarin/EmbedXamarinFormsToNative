using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using NavigationFormsToNativeNewPatternDroidLibrary;

namespace NavigationFormsToNaviteNewPattern.Droid
{
    [Activity(Label = "NavigationFormsToNaviteNewPattern", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : AppCompatActivity
    {
        Button btnNavForms;
        protected override void OnCreate(Bundle savedInstanceState)
        {

            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.mainLayout);
            btnNavForms = FindViewById<Button>(Resource.Id.btnNavForms);
            btnNavForms.Click += BtnNavForms_Click;

            
        }

        private void BtnNavForms_Click(object sender, EventArgs e)
        {
            StartActivity(typeof(MainPageActivity));
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        protected override void OnDestroy()
        {
            btnNavForms.Click -= BtnNavForms_Click;
            base.OnDestroy();
        }
    }
}