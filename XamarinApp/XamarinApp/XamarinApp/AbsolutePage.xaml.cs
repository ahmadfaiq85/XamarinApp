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
	public partial class AbsolutePage : ContentPage
	{
		public AbsolutePage ()
		{
			InitializeComponent ();

            var layout = new AbsoluteLayout();
            Content = layout;

            var aquabox = new BoxView { Color = Color.Aqua };
            layout.Children.Add(aquabox,
                                new Rectangle(0, 0, 1, 1),
                                AbsoluteLayoutFlags.All);

            AbsoluteLayout.SetLayoutBounds(aquabox, new Rectangle(0, 0, 1, 1));
            AbsoluteLayout.SetLayoutFlags(aquabox, AbsoluteLayoutFlags.All);
		}
	}
}