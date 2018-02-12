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
	public partial class ImagesExercise : ContentPage
	{
        private int _currentImage = 1;
		public ImagesExercise ()
		{
			InitializeComponent ();

            Load_Image(); 
        }

        void Load_Image()
        {
            var imageSource = new UriImageSource { Uri = new Uri(string.Format("http://lorempixel.com/1920/1080/sports/{0}/", _currentImage)) };
            
            image.Source = imageSource;
        }

        void Previous_Clicked(object sender, EventArgs e)
        {
            _currentImage--;
            Load_Image();
        }

        void Next_Clicked(object sender, EventArgs e)
        {
            _currentImage++;
            Load_Image();
        }
	}
}