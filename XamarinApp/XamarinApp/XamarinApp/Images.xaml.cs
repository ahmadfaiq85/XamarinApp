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
	public partial class Images : ContentPage
	{
		public Images ()
		{
			InitializeComponent ();

            //Image source using code
            var imageSource = new UriImageSource { Uri = new Uri("http://lorempixel.com/1920/1080/sports/2/") };
            imageSource.CachingEnabled = true;
            imageSource.CacheValidity = TimeSpan.FromHours(12);

            image.Source = imageSource;

            //Aspect ratios
            image.Aspect = Aspect.AspectFill;
            //image.Aspect = Aspect.AspectFit;
            //image.Aspect = Aspect.Fill;
        }
	}
}