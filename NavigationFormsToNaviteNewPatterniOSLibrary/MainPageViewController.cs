using System;
using Foundation;
using NavigationFormsToNaviteNewPattern;
using UIKit;

namespace NavigationFormsToNaviteNewPatterniOSLibrary
{
    public partial class MainPageViewController : XamarinFormsViewController<MainPage>
    {
        public MainPageViewController() : base("MainPageViewController", bundle: NSBundle.FromClass(new ObjCRuntime.Class("MainPageViewController")))
        {
            if (!Xamarin.Forms.Forms.IsInitialized)
                Xamarin.Forms.Forms.Init();
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            NavigationItem.Title = "Main Page";
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

