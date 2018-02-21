using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        //private ObservableCollection<Contact> _contacts;
        private IEnumerable<Contact> _contacts;
        public ListviewSelection()
        {
            InitializeComponent();

            _contacts = GetContacts();

            listview.ItemsSource = _contacts;
        }

        //ObservableCollection<Contact> GetContacts(string searchText = null)
        IEnumerable<Contact> GetContacts(string searchText = null)
        {
            var contacts = new ObservableCollection<Contact>
            {
                new Contact {Name = "Faiq", ImageUrl = "http://lorempixel.com/100/100/people/3"},
                new Contact {Name = "Taha", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hi, how is it going?"}
            };

            if (string.IsNullOrWhiteSpace(searchText))
                return contacts;

            return contacts.Where(c=> c.Name.StartsWith(searchText));
        }

        void Search_TextChanged ( object sender, TextChangedEventArgs e)
        {
           listview.ItemsSource = GetContacts(e.NewTextValue);
        }

        void Item_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            //listview.SelectedItem = null; 
            //var contact = e.SelectedItem as Contact;
            //DisplayAlert("Selected", contact.Name, "OK");
        }

        void Item_Tapped(object sender, ItemTappedEventArgs e)
        {
            //var contact = e.Item as Contact; 
            //DisplayAlert("Selected", contact.Name, "OK"); 
        }

        void Call_Clicked(object sender, EventArgs e)
        {
            var menuItem = sender as MenuItem;
            var contact = menuItem.CommandParameter as Contact;

            DisplayAlert("Call", contact.Name, "OK");
        }

        void Delete_Clicked(object sender, EventArgs e)
        {
            var contact = (sender as MenuItem).CommandParameter as Contact;
            //_contacts.Remove(contact);
        }

        void List_Refreshing(object sender, EventArgs e)
        {
            listview.ItemsSource = GetContacts();

            //listview.IsRefreshing = false;
            listview.EndRefresh();
        }
    }
}