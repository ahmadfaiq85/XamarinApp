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
	public partial class Toolbars : ContentPage
	{
        //Toolbars only appear in NavigationPage
		public Toolbars ()
		{
			InitializeComponent ();
		}
        
        void New_Activated (object sender, EventArgs e)
        {
            DisplayAlert("New", "New Activated", "Ok");
        }
	}
}