using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyApplication1.Views
{
    class TabbedPageDemoPage : TabbedPage
    {
        public TabbedPageDemoPage()
        {
            this.Title = "Angebot erstellen";

            this.ItemsSource = new NamedTab[]
            {
                new NamedTab ("Page One"),
                new NamedTab ("Page Two"),
                new NamedTab ("Page Three"),
                new NamedTab ("Page Four")
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
