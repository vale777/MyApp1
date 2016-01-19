using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            InitializeComponent();


        }

        void OnButtonClickedContinue(object sender, EventArgs args)
        {
            
            Navigation.PushAsync(new CreatePageThree());
        }
    }
}
