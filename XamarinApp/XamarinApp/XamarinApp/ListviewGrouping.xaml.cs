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
    public partial class ListviewGrouping : ContentPage
    {
        public ListviewGrouping()
        {
            InitializeComponent();

            listview.ItemsSource = new List<ContactGroup>
            {
                new ContactGroup ("F", "F")
                {
                    new Contact {Name = "Faiq", ImageUrl = "http://lorempixel.com/100/100/people/3"}
                },
                new ContactGroup ("T", "T")
                {
                    new Contact { Name = "Taha", ImageUrl = "http://lorempixel.com/100/100/people/2", Status = "Hi, how is it going?" }
                }
            };
        }
    }
}