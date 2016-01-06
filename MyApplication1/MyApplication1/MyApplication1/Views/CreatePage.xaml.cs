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

        void OnCategoryTapped (object sender, ItemTappedEventArgs e)
        {
            if (e == null) return;
            Debug.WriteLine("Kategorie: " + e.Item);
            ((ListView)sender).SelectedItem = null;
        }

        void OnButtonClickedContinue(object sender, EventArgs args)
        {
            Navigation.PushAsync(new CreatePageTwo());
        }
        //Button wird nicht angezeigt
    }
}
