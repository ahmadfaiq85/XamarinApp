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
	public partial class Listviews : ContentPage
	{
		public Listviews ()
		{
			InitializeComponent ();

            var names = new List<string>
            {
                "Faiq",
                "Taha",
                "Hosa"
            };

            listview.ItemsSource = names;
		}
	}
}