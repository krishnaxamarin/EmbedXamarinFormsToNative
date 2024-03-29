﻿using Foundation;
using NavigationFormsToNaviteNewPatterniOSLibrary;
using System;
using UIKit;

namespace NavigationFormsToNaviteNewPattern.iOS
{
    public partial class ViewController : UIViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void UIButton197_TouchUpInside(UIButton sender)
        {
            NavigationController.PushViewController(new MainPageViewController(), true);
            //PresentViewController(new MainPageViewController(), true, null);
        }
    }
}