using System;
using Xamarin.Forms;

namespace NavigationFormsToNaviteNewPattern
{
    public static class GlobalVariables
    {
        public static ICustomNavigation navigation = DependencyService.Get<ICustomNavigation>();
    }
}
