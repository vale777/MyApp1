using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyApplication1.Views
{
    public partial class CreatePageThree : ContentPage
    {
        public CreatePageThree()
        {
            InitializeComponent();
        }

        void OnButtonClickedContinue(object sender, EventArgs args)
        {
            DisplayAlert("Glückwunsch!", "Der Artikel wurde eingestellt", "Ok");
            Navigation.PushAsync(new LogPage());
        }
    }
}
