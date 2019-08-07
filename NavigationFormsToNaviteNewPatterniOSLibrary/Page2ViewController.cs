using System;
using Foundation;
using NavigationFormsToNaviteNewPattern;
using UIKit;

namespace NavigationFormsToNaviteNewPatterniOSLibrary
{
    public partial class Page2ViewController : XamarinFormsViewController<Page2>
    {
        public Page2ViewController() : base("Page2ViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            NavigationItem.Title = "Page2 Page";
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}