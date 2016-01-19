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
