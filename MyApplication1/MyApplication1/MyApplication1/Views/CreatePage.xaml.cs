using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyApplication1.Views
{
    public partial class CreatePage : TabbedPage
    {
        public CreatePage()
        {
            this.Title = "Angebot erstellen";

            this.ItemsSource = new NamedTab[]
            {
                new NamedTab ("Schritt eins"),
                new NamedTab ("Schritt zwei"),
                new NamedTab ("Schritt drei"),
                new NamedTab ("Schritt vier")
            };

            this.ItemTemplate = new DataTemplate(() => {
                return new NamedTabPage();
            });
        }
    }

    class NamedTab
    {
        public NamedTab(string name)
        {
            this.Name = name;
        }

        public string Name { private set; get; }

        public override string ToString()
        {
            return Name;
        }
    }

    public partial class NamedTabPage : ContentPage
    {
        public NamedTabPage()
        {
            this.SetBinding(ContentPage.TitleProperty, "Name");
        }
    }
}
