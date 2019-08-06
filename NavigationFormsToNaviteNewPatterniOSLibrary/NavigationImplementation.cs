using System;
using System.Linq;
using NavigationFormsToNaviteNewPattern;
using NavigationFormsToNaviteNewPatterniOSLibrary;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(NavigationImplementation))]
namespace NavigationFormsToNaviteNewPatterniOSLibrary
{
    public class NavigationImplementation : ICustomNavigation
    {
        UIViewController controllerTobePushed;
        
        public void PushPage2Screen()
        {
            controllerTobePushed = new Page2ViewController();
            PushNewScreen();
        }

        public void PushPage3Screen()
        {
            controllerTobePushed = new Page3ViewController();
            PushNewScreen();
        }

        public void PushNewScreen()
        {
            var vc = GetVisibleViewController();

            
            if (vc.NavigationController != null)
                vc.NavigationController.PushViewController(controllerTobePushed, true);
            else
                vc.PresentViewController(controllerTobePushed, true, () => { });
        }

         UIViewController GetVisibleViewController()
        {
            UIViewController viewController = null;
            var window = UIApplication.SharedApplication.KeyWindow;


            if (window != null && window.WindowLevel == UIWindowLevel.Normal)
                viewController = window.RootViewController;

            if (viewController == null)
            {
                window = UIApplication.SharedApplication.Windows.OrderByDescending(w => w.WindowLevel).FirstOrDefault(w => w.RootViewController != null && w.WindowLevel == UIWindowLevel.Normal);
                if (window == null)
                    throw new InvalidOperationException("Could not find current view controller");
                else
                    viewController = window.RootViewController;
            }

            while (viewController.PresentedViewController != null)
                viewController = viewController.PresentedViewController;

            var navController = viewController as UINavigationController;
            if (navController != null)
                viewController = navController.ViewControllers.Last();

            return viewController;
        }
    }
}
