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
	public partial class ListviewSelection : ContentPage
	{
		public ListviewSelection ()
		{
			InitializeComponent ();

            listview.ItemsSource = new List<Contact>
            {
                new Contact {Name = "Faiq", ImageUrl = "http://lorempixel.com/100/100/people/3"},
                new Contact {Name = "Taha", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hi, how is it going?"}
            };
        }

        void Item_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            //listview.SelectedItem = null;

            var contact = e.SelectedItem as Contact;
            DisplayAlert("Selected", contact.Name, "OK");
        }

        void Item_Tapped(object sender,  ItemTappedEventArgs e)
        {
            var contact = e.Item as Contact; 
            DisplayAlert("Selected", contact.Name, "OK"); 
        }


	}
}