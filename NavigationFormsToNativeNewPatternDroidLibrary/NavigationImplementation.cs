using System;
using Android.Content;
using NavigationFormsToNativeNewPatternDroidLibrary;
using NavigationFormsToNaviteNewPattern;
using Xamarin.Forms;

[assembly: Dependency(typeof(NavigationImplementation))]
namespace NavigationFormsToNativeNewPatternDroidLibrary
{
    public class NavigationImplementation : ICustomNavigation
    {
        public static Context context;

        public void PushPage2Screen()
        {
            context.StartActivity(typeof(Page2Activity));
        }

        public void PushPage3Screen()
        {
            context.StartActivity(typeof(Page3Activity));
        }
    }
}
