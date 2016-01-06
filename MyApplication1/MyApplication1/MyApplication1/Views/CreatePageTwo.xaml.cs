using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyApplication1.Views
{
    public partial class CreatePageTwo : ContentPage
    {
        public CreatePageTwo()
        {
            var woodImage = new Image { WidthRequest = 300, HeightRequest = 300 };
            woodImage.Source = ImageSource.FromFile("holzbretter.gif");
            woodImage.Aspect = Aspect.AspectFit;

            Content = new StackLayout
            {
                Children = {

                    new Button
                    {
                        Text = "Bilder hochladen",
                        //Funktion der Kamera implementieren
                    },

                    //new Label
                    //{
                    //    Text = "Bilder hochladen",
                    //    FontSize = Device.GetNamedSize (NamedSize.Medium, typeof(Label)),
                    //    FontAttributes = FontAttributes.Bold
                    //},

                    woodImage,

                    new Label
                    {
                        Text = "holzbretter.gif has been added each application project: iOS, Android and Windows Phone. On iOS and Android multiple resolutions are supplied and resolved at runtime."
                    },

                    new Label
                    {
                        Text = "Ende der Anzeige"
                    },

                    new DatePicker
                    {
                        Format = "D",
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    },

                    new Button
                    {
                        Text = "Angebot erstellen"
                    },                                    
                },

                Padding = new Thickness(0, 20, 0, 0),
                VerticalOptions = LayoutOptions.StartAndExpand,
                HorizontalOptions = LayoutOptions.CenterAndExpand
            };
        }
    }
}
