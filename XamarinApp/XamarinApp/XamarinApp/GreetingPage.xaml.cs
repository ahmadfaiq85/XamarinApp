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
		public GreetingPage ()
		{
			InitializeComponent ();

            slider.Value = 0.5;
        }

        void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
        {
            label.Text = string.Format("Value is {0:F2}", e.NewValue);
        }
    }
}