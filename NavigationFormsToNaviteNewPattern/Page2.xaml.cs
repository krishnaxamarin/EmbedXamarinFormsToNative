using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NavigationFormsToNaviteNewPattern
{
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        void OnBtnClick(object sender, EventArgs args)
        {
            GlobalVariables.navigation.PushPage3Screen();
        }
    }
}
