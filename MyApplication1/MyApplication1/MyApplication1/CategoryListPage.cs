using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyApplication1
{
    class CategoryListPage : ContentPage
    {
        public CategoryListPage()
        {
            var listView = new ListView();

            listView.ItemsSource = new[] { "Holz", "Metall", "Glas", "Baustoff", "Sonstiges" };

            listView.ItemTapped += async (sender, e) =>
            {
                await DisplayAlert("Tapped", e.Item + " wurde gewählt", "OK");
                Debug.WriteLine("Kategorie: " + e.Item);
                ((ListView)sender).SelectedItem = null;
            };

            Padding = new Thickness(0, 20, 0, 0);
            Content = listView;
        }
    }
}
