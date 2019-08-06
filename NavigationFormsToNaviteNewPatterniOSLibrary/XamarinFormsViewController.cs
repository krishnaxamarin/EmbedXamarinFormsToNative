using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
using Xamarin.Forms;

namespace NavigationFormsToNaviteNewPatterniOSLibrary
{
    /// <summary>
    /// Base xamarin forms view controller. Used for embedding a Xamarin.Forms page within a native view controller.
    /// When inheriting from this, be sure to create a ViewController within the storyboard as well so that navigation
    /// can properly work.
    /// </summary>
    public abstract class XamarinFormsViewController<TPage> : UIViewController
        where TPage : ContentPage, new()
    {
        protected TPage _page;


        public XamarinFormsViewController(IntPtr handle) : base(handle)
        {
        }

        public XamarinFormsViewController(string nibname, NSBundle bundle) : base(nibname, bundle)
        {
        }

        /// <summary>
        /// Load the Xamarin.Forms Page's ViewController into the parent
        /// </summary>
        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            _page = new TPage();
            var window = UIApplication.SharedApplication.KeyWindow;
            View.Bounds = window.Bounds;
            var xamarinFormsController = _page.CreateViewController();
            AddChildViewController(xamarinFormsController);
            View.AddSubview(xamarinFormsController.View);
            xamarinFormsController.DidMoveToParentViewController(this);

            // add whatever other settings you want - ex:
            EdgesForExtendedLayout = UIKit.UIRectEdge.None;
            ExtendedLayoutIncludesOpaqueBars = false;
            AutomaticallyAdjustsScrollViewInsets = false;




            //if(this.NavigationItem.RightBarButtonItems == null)
            // {
            //var rightBarButton = new UIBarButtonItem();

            //var button = new UIButton();
            //button.TitleLabel.Text = "Help";
            //rightBarButton.CustomView = button;
            ////var nav = new NavigationImplementation();
            ////var nvVC = nav.GetVisibleViewController();
            ////var navVCnav = nvVC.NavigationController;

            //var i = this.NavigationController;
            //i.TopViewController.NavigationItem.SetRightBarButtonItem(rightBarButton, true);
            //NavigationItem.SetRightBarButtonItem(rightBarButton, true);
            //this.NavigationItem.RightBarButtonItem = rightBarButton;

            // }
            //else
            // {


            // }

        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();

            var rightBarButton = new UIBarButtonItem();

            //var button = new UIButton();
            //button.TitleLabel.Text = "Help";
            //rightBarButton.CustomView = button;
            //var nav = new NavigationImplementation();
            //var nvVC = nav.GetVisibleViewController();
            //var navVCnav = nvVC.NavigationController;
            rightBarButton.Title = "Click";
            rightBarButton.Style = UIBarButtonItemStyle.Plain;

            var i = this.NavigationController;

            var rightBarButton1 = new UIBarButtonItem();

            //var button = new UIButton();
            //button.TitleLabel.Text = "Help";
            //rightBarButton.CustomView = button;
            //var nav = new NavigationImplementation();
            //var nvVC = nav.GetVisibleViewController();
            //var navVCnav = nvVC.NavigationController;
            rightBarButton1.Title = "Help";
            rightBarButton1.Style = UIBarButtonItemStyle.Plain;
            NavigationItem.SetRightBarButtonItem(rightBarButton, true);
            //i.TopViewController.NavigationItem.SetRightBarButtonItem(rightBarButton1, true);

            var temp = NavigationItem.RightBarButtonItems;
            if (temp == null)
            {
                temp = new UIBarButtonItem[] { rightBarButton, rightBarButton1 };
                NavigationItem.SetRightBarButtonItems(temp, true);
            }
            else
            {
                //var length = temp.Length;
                //temp = new UIBarButtonItem[temp.Length + 1];
                //for (var w = 0; w < temp.Length -1; w++)
                //{
                //    temp[w] = NavigationItem.RightBarButtonItems[w];
                //}

                //temp[temp.Length -1] = rightBarButton1;
                var tempList = new List<UIBarButtonItem>(temp);

                tempList.Add(rightBarButton1);

                NavigationItem.SetRightBarButtonItems(tempList.ToArray(), true);

                //var length = NavigationItem.RightBarButtonItems.Length;
            }

            

            //var k = new UIBarButtonItem[] { NavigationItem.RightBarButtonItems, rightBarButton1 };

            //var i = this.NavigationController;

            //var rightBarButton = new UIBarButtonItem();

            //var button = new UIButton();
            //button.TitleLabel.Text = "Click";
            //rightBarButton.CustomView = button;


            //NavigationItem.RightBarButtonItem = rightBarButton;
        }
    }
}