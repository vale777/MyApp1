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
        List<Products> _products = new List<Products>();
        public LogPage()
        {
            InitializeComponent();

            // The root page of your application
            
            Uri uri = new Uri("http://localhost:49966/odata/");
            var container = new aspverbindung.Container(uri);
            _products = container.products;
            this.BindingContext = new[] { "{0}", product.Name };
        }

        public List<Products> Products
        {
            get {
                return _products;
            }
            set{
                _products = value;
            }
        }

        public void DisplayInserat(aspverbindung.Inserat product)
        {
            Angebote.ItemsSource = product.Name;  
            this.BindingContext = new[] { "{0}", product.Name };
        }

        void OnButtonClickedCreate(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CreatePage());
        }
    }
}
