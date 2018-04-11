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

using System.IO.Pipes;

namespace XamarinApp
{
    public class Article
    { 
        public int ArticleId { get; set; }
        public int CategoryId { get; set; }
        public string HTMLContent { get; set; }
        public string ImageUrl { get; set; }
        public bool PostPublic { get; set; }
        public DateTime PublishDate { get; set; }
        public string Title { get; set; }
    }

    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class NetflixExcercise : ContentPage
	{
        public const string Url = "https://jsonplaceholder.typicode.com/posts";
        private HttpClient _client = new HttpClient();
        //private ObservableCollection<Article> _articles;


        public NetflixExcercise ()
		{
			InitializeComponent ();
		}

        async void GetArticles_Clicked(object sender, EventArgs e)
        {
            try
            {
            var content = await _client.GetStringAsync(Url);
            //var articles = JsonConvert.DeserializeObject<List<Article>>(content);

            //_articles = new ObservableCollection<Article>(articles);
            //articlesListView.ItemsSource = _articles;
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Ok");
            }
        }

        void Search_TextChanged(object sender, TextChangedEventArgs e)
        {
            //string searchTerm = e.NewTextValue;
            //if (searchTerm.Length < 5)
            //    return; 

            base.OnAppearing();
        }
    }
}