using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinApp
{
    public class Movie
    { 
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NetflixExcercise : ContentPage
	{
        public const string Url = "http://netflixroulette.net/api/api.php?actor={0}";
        private HttpClient _client = new HttpClient();
        private ObservableCollection<Movie> _movies;


        public NetflixExcercise ()
		{
			InitializeComponent ();
		}

        async void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            string searchTerm = e.NewTextValue;
            if (searchTerm.Length < 5)
                return;

            var content = await _client.GetStringAsync(Url);
            var movies = JsonConvert.DeserializeObject<List<Movie>>(content);

            _movies = new ObservableCollection<Movie>(movies);
            moviesListView.ItemsSource = _movies;

            base.OnAppearing();
        }
    }
}