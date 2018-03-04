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
	public partial class AppProperties : ContentPage
	{
		public AppProperties ()
		{
			InitializeComponent ();

            if(Application.Current.Properties.ContainsKey("Title"))
                title.Text = Application.Current.Properties["Title"].ToString();

            if (Application.Current.Properties.ContainsKey("NotificationsEnabled"))
                notificationEnabled.On = (bool)Application.Current.Properties["NotificationsEnabled"];
        }

        void OnChanged(object sender, EventArgs e)
        {
            Application.Current.Properties["Title"] = title.Text;
            Application.Current.Properties["NotificationsEnabled"] = notificationEnabled.On;

            Application.Current.SavePropertiesAsync();
        }
	}
}