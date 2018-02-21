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
	public partial class ListviewViewCell : ContentPage
	{ 
        public ListviewViewCell ()
		{
			InitializeComponent ();

            listview.ItemsSource = new List<Contact>
            {
                new Contact {Name = "Faiq", ImageUrl = "http://lorempixel.com/100/100/people/3"},
                new Contact {Name = "Taha", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hi, how is it going?"}
            };
        }
	}
}