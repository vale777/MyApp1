using MyApplication1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyApplication1
{
    public partial class HelloXamlPage : ContentPage
    {
        public HelloXamlPage()
        {
            InitializeComponent();
        }

        void OnButtonClickedLogin(object sender, EventArgs args)
        {
            /*Button button = (Button)sender;
            await DisplayAlert("Clicked!",
                "The button labeled '" + button.Text + "' has been clicked",
                "OK");*/
            Navigation.PushAsync(new LogPage());
        }

        void OnButtonClickedRegistrierung(object sender, EventArgs args)
        {
            Navigation.PushAsync(new RegistrierungPage());
        }
    }
}
