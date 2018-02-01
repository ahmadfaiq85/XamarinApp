using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetingPage : ContentPage
    {
        public GreetingPage()
        {
            InitializeComponent();

            slider.Value = 0.5;



            //if (Device.OS == TargetPlatform.iOS)
            //    Padding = new Thickness(0, 20, 0, 0);
            //else if (Device.OS == TargetPlatform.Android)
            //    Padding = new Thickness(10, 20, 0, 0);

            //Device.OnPlatform(
            //   iOS: new Thickness(0, 20, 0, 0),
            //   Android: new Thickness(10, 20, 0, 0),
            //   WinPhone: new Thickness(30, 20, 0, 0)
            //    );

            ////executing code based on OS
            //Device.OnPlatform(
            //    iOS: () =>
            //    {
            //        Padding = new Thickness(0, 20, 0, 0);
            //    },
            //    Android: () =>
            //    {
            //        Padding = new Thickness(0, 20, 0, 0);
            //    });
        }

    }
}