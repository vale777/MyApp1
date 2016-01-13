using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyApplication1.Views
{
    public partial class CreatePage : ContentPage
    {
        public CreatePage()
        {
            InitializeComponent();

            this.BindingContext = new [] { "Holz", "Metall", "Glas", "Baustoff", "Sonstiges" };
        }

        void OnSelection(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }
            DisplayAlert("augewählte Kategorie", e.SelectedItem.ToString(), "Ok");
        }

        void OnButtonClickedContinue(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CreatePageTwo());
        }
    }
}
