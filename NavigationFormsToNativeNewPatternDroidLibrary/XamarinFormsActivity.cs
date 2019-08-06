
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace NavigationFormsToNativeNewPatternDroidLibrary
{
    public abstract class XamarinFormsActivity<TPage> : AppCompatActivity
    where TPage : ContentPage, new()
    {
        protected readonly TPage _page;

        public XamarinFormsActivity()
        {
            
            
            _page = new TPage();
        }


        protected override void OnCreate(Android.OS.Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.xamarin_forms_activity);
            if (!Xamarin.Forms.Forms.IsInitialized)
                Xamarin.Forms.Forms.Init(this, null);

            NavigationImplementation.context = this;
            var transaction = SupportFragmentManager.BeginTransaction();
            transaction.Add(Resource.Id.fragment_container, _page.CreateSupportFragment(this));
            transaction.Commit();
            SupportActionBar?.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar?.SetDisplayShowHomeEnabled(true);
        }
    }
}