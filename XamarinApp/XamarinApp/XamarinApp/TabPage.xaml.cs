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
	public partial class TabPage : TabbedPage
	{
		public TabPage ()
		{
			InitializeComponent ();

            //this.Children.Add(new GreetingPage());
            //this.Children.Add(new GridPage());
		}
	}
}