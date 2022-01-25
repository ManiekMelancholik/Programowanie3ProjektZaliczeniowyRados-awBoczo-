using Programowanie3ProjektZaliczeniowyRadosławBoczoń.Model;
using Programowanie3ProjektZaliczeniowyRadosławBoczoń.Utylities;
using Programowanie3ProjektZaliczeniowyRadosławBoczoń.Utylities.DataBase;
using Programowanie3ProjektZaliczeniowyRadosławBoczoń.Utylities.DataBase.DataBaseQuerries.StandarUserQuerries;
using Programowanie3ProjektZaliczeniowyRadosławBoczoń.WPF_Controls.DB_CONTROLS;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Programowanie3ProjektZaliczeniowyRadosławBoczoń.ModelViews.DB_CONTROLS_MV
{
    public class Apointments_C_MV
    {
        public Apointments_C_MV() { }
        //private static EventHandler _load;
        //public static EventHandler load
        //{
        //    get
        //    {
        //        if (_load == null)
        //        {
        //            _load = new EventHandler(LOAD);
        //        }
        //        return _load;
        //    }
        //}
        private static List<Visit> _collection;
        public static List<Visit> collection
        {
            get
            {
                MessageBox.Show("GETTING COLLECTION");
                return _collection;
            }
            set
            {
                MessageBox.Show("SETTING COLLECTION");
                _collection = value;
            }
            
        }

        private string _hour;
        public string hour
        {
            get
            {
                return _hour;
            }
            set 
            { 
                _hour = value; 
            }
        }
        private string _date;
        public DateTime date
        {
            private get
            {
                return new DateTime();
            }
            set
            {
                _date = value.Year.ToString() + '-' + value.Month.ToString()+'-' + value.Day.ToString();
            }
        }

        private ICommand _makeAppointment;

        public ICommand makeAppointment
        {
            get
            {
                if (_makeAppointment == null)
                {
                    _makeAppointment = new ACC(
                        e =>
                        {
                            IQuerry GetAppointments = new GetPersonApointments();
                            MessageBox.Show($"Loading Appointments{_date} , {_hour}");
                            collection = Visit.ConvertToObservableCollection(GetAppointments.ExecuteQuerry());
                            
                            Apointments_C._instance.listView.ItemsSource = collection;
                        },
                        ce =>
                        {
                            return true;
                        }
                        );
                }
                return _makeAppointment;
            }
        }
        //public static void LOAD(object o, EventArgs e)
        //{

        //}




    }
}
