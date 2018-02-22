using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp
{
    public class ContactMethod
    {
        public int Id { get; set; }
        public string Name { get; set; } 
    }

	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Forms1 : ContentPage
	{
		public Forms1 ()
		{
			InitializeComponent ();

            foreach (var method in getContactMethods())
                contactMethods2.Items.Add(method.Name);
		}

        private IList<ContactMethod> getContactMethods()
        {
            return new List<ContactMethod>
            {
                new ContactMethod { Id = 1, Name = "SMS"},
                new ContactMethod { Id = 2, Name = "Email"}
            };
        }

        void Picker_selectedIndexChanged(object sender, EventArgs e)
        {
            var contactMethod = contactMethods.Items[contactMethods.SelectedIndex];

            DisplayAlert("Selection", contactMethod, "OK");
        }

        void Picker2_selectedIndexChanged(object sender, EventArgs e)
        {
            if (contactMethods.SelectedIndex < 0)
                return;

            var name = contactMethods.Items[contactMethods.SelectedIndex];
            var contactMethod = getContactMethods().Single(c => c.Name == name);

            DisplayAlert("Selection", name, "OK");
        }
    }
}