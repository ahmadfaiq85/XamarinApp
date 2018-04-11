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


    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TechArticles : ContentPage
    {
        private const string Url = "http://www.techstreetonline.com/Api/Articles";
        private HttpClient _client = new HttpClient();
        private ObservableCollection<TechArticle> _articles;
        class TechArticle
        {
            public int ArticleId { get; set; }
            public string Title { get; set; }
            public string HTMLContent { get; set; }
            public string ImageUrl { get; set; }
            public DateTime PublishDate { get; set; }
        }


        public TechArticles()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            _client.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json");
            _client.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 (Windows NT 6.2; WOW64; rv:19.0) Gecko/20100101 Firefox/19.0");

            var content = await _client.GetStringAsync(Url);
            var articles = JsonConvert.DeserializeObject<List<TechArticle>>(content);

            _articles = new ObservableCollection<TechArticle>(articles);
            postsListView.ItemsSource = _articles;

            base.OnAppearing();
        }

    }
}