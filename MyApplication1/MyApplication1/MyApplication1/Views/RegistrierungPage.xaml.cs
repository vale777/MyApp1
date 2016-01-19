using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

using Xamarin.Forms;

namespace MyApplication1.Views
{
    public partial class RegistrierungPage : ContentPage
    {
        public RegistrierungPage()
        {
            InitializeComponent();
            /*DataTable theTable = new DataTable();

            String connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Movies.mdf;Integrated Security=True" providerName="System.Data.SqlClient; Initial Catalog=DataBaseNew
;Integrated Security=True";

            String query = @"SELECT ID, Benutzername, E-Mail, Passwort";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                da.Fill(theTable);
            }

            DataContext = theTable;*/
        }

        void OnButtonClickedSubmit(object sender, EventArgs args)
        {
            DisplayAlert("Glückwunsch!", "Sie haben sich erfolgreich registriert!", "Fortsetzen");
            Navigation.PushAsync(new LogPage());
        }
    }
}
