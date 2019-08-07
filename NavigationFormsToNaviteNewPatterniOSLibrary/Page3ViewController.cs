using System;
using Foundation;
using NavigationFormsToNaviteNewPattern;
using UIKit;

namespace NavigationFormsToNaviteNewPatterniOSLibrary
{
    public partial class Page3ViewController : XamarinFormsViewController<Page3>
    {
        public Page3ViewController() : base("Page3ViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            NavigationItem.Title = "Page3 Page";
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

