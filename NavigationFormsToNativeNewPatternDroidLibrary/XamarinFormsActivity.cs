
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
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
        public Android.Support.V7.Widget.Toolbar Toolbar { get; set; }
        public AppBarLayout AppBar { get; set; }

        public XamarinFormsActivity()
        {


            _page = new TPage();
        }


        protected override void OnCreate(Android.OS.Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.xamarin_forms_activity);

            Toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            if (Toolbar?.Parent != null)
            {
                AppBar = Toolbar?.Parent as AppBarLayout;
                SetSupportActionBar(Toolbar);
            }
            if (!Xamarin.Forms.Forms.IsInitialized)
                Xamarin.Forms.Forms.Init(this, null);

            NavigationImplementation.context = this;
            var transaction = SupportFragmentManager.BeginTransaction();
            transaction.Add(Resource.Id.fragment_container, _page.CreateSupportFragment(this));
            transaction.Commit();
            SupportActionBar?.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar?.SetDisplayShowHomeEnabled(true);
            //Toolbar?.SetBackgroundColor(Android.Graphics.Color.White);
        }


        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            //var currentFocus = this.CurrentFocus;
            //if (currentFocus != null)
            //{
            //    InputMethodManager mImm = (InputMethodManager)this.GetSystemService(Android.Content.Context.InputMethodService);
            //    mImm.HideSoftInputFromWindow(currentFocus.WindowToken, HideSoftInputFlags.None);
            //}

            if (item.ItemId == Android.Resource.Id.Home)
            {
                this.OnBackPressed();
                return true;

            }
            else if (item.ItemId == Resource.Id.helpMenu)
            {

                return true;
            }
            return base.OnOptionsItemSelected(item);
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            //menu.Add(Resource.Menu.defaultToolbarMenu);
            MenuInflater.Inflate(Resource.Menu.defaultToolbarMenu, menu);
            return base.OnCreateOptionsMenu(menu);
        }

        //public override bool OnCreateOptionsMenu(IMenu menu)
        //{
        //    menu.Clear();
        //    inflater.Inflate(Resource.Menu.facilityDetailsOptionsMenu, menu);
        //    return base.OnCreateOptionsMenu(menu);

        //}


    }
}