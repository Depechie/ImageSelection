using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using ImageSelection.Resources;

namespace ImageSelection
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private void image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (this.Image.Height > 100)
                VisualStateManager.GoToState(this, "ClosedState", true);
            else
                VisualStateManager.GoToState(this, "OpenState", true);
        }
    }
}