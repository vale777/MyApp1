using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication1.DataModel
{
    class ArticleDataModel
    {
        static ArticleDataModel()
        {
            All = new ObservableCollection<ArticleDataModel>
            {
                new ArticleDataModel
                {
                    Name = "Konstruktionsholz",
                    Type = "Holz",
                    Info = "Fichte, 20 x 40 mm 5 m Holz Latte",
                    PhotoUrl="http://www.massivdiele.info/WebRoot/Store9/Shops/61199559/4C2E/0549/95BC/71AE/F617/C0A8/29BB/ED9F/CIMG3579.JPG"
                },
                new ArticleDataModel
                {
                    Name = "Schreibtisch",
                    Type = "Holz, Birke",
                    Info = "herkömmlicher Schreibtisch, Eiche",
                    PhotoUrl="http://www.tischfabrik24.de/Media/Shop/massivholz_schreibtisch_nach_mass_eiche_practic_2.jpg"
                },
                new ArticleDataModel
                {
                    Name = "Flexrohr",
                    Type = "Aluminium",
                    Info = "Alu-Flexrohr, verzinkt, Schlauchverbinder NW 150",
                    PhotoUrl="http://www.hornbach.de/data/shop/D04/001/780/491/916/27/DV_8_8610921_01_4c_NL_20121025075337.jpg"
                }
            };
        }

        public string Name { set; get; }

        public string Type { set; get; }

        public string Info { set; get; }

        public string PhotoUrl { set; get; }

        public static IList<ArticleDataModel> All { set; get; }
    }
}

