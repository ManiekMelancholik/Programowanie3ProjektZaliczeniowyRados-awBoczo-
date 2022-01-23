using Programowanie3ProjektZaliczeniowyRadosławBoczoń.Utylities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Programowanie3ProjektZaliczeniowyRadosławBoczoń.ModelViews
{
    public class TstSearch_C_MV
    {
        public TstSearch_C_MV() { }

        #region properties

        private string _name;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        private string _producerName;
        public string producerName
        {
            get
            {
                return _producerName;
            }
            set
            {
                _producerName = value;
            }
        }

        private float _price;
        public string price
        {
            get
            {
                return _price.ToString();
            }
            set
            {
                float.TryParse(value, out _price);
            }
        }

        private string _mainActiveSubstance;
        public string mainActiveSubstance
        {
            get
            {
                return _mainActiveSubstance;
            }
            set
            {
                _mainActiveSubstance = value;
            }
        }






        #endregion

        private ICommand _search;
        public ICommand search
        {
            get
            {
                if (_search == null)
                {
                    _search = new ACC(
                        e =>
                        {
                            /*
                             POLĄCZYĆ LOGOWANIE Z BAZĄ DANYCH 

                            USTAWIĆ POŁĄCZENIE I WYWOŁYWANIE KOMENDY DO OSOBNEGO PLOKU W SQL


                             */
                            //MessageBox.Show("SEARCHING");
                            SqlConnection connection = new SqlConnection();
                            string querry = "SELECT * FROM[Zaliczenie].[dbo].[TestCosmetics]";
                            connection.Open();
                            SqlCommand sqlCommand = new SqlCommand(querry, connection);
                            sqlCommand.CommandType = System.Data.CommandType.Text;
                            MessageBox.Show(sqlCommand.ExecuteScalar().ToString());
                            connection.Close();
                        },
                        ce =>
                        {
                            return true;
                        }
                        
                        
                        );
                }

                return _search;
            }
        }



    }
}
