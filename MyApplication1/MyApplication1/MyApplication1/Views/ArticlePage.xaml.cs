using MyApplication1.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MyApplication1.Views
{
    public partial class ArticlePage
    {
        public ArticlePage()
        {
            InitializeComponent();

            this.ItemsSource = ArticleDataModel.All;
        }
    }
}
