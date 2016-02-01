using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyApplication1.Views
{
    public partial class LogPage : ContentPage
    {
        public LogPage()
        {
            InitializeComponent();

            Uri uri = new Uri("http://localhost:49966/odata/");
            var container = new aspverbindung.Container(uri);
        }

        public void DisplayInserat(aspverbindung.Inserat product)
        {
            Angebote.ItemsSource = product.Name;
            BindingContext = new[] { "{0}", product.Name, "{1}", product.Beschreibung };
        }

        void OnButtonClickedCreate(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CreatePage());
        }

        void OnButtonClickedSearch(object sender, EventArgs args)
        {
            Navigation.PushAsync(new ArticlePage());
        }
    }
}
