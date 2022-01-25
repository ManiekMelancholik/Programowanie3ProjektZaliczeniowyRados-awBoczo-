using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie3ProjektZaliczeniowyRadosławBoczoń.Model
{
    public class Visit
    {
        public Visit() { }
        private string _date;
        public string date
        {
            get
            {
                return _date;
            }
            set
            {
                _date = value;
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
        private bool _realized;
        public bool realized
        {
            get
            {
                return _realized;
            }
            set
            {
                _realized = value;
            }
        }

        public static List<Visit> ConvertToObservableCollection(DataTable table)
        {
            List<Visit> collection = new List<Visit>();

            for(int i = 0; i<table.Rows.Count; i++)
            {
                var row = table.Rows[i].ItemArray;
                //collection.Add(new Visit { date = "-1-1-1001", hour = "20:09", realized = false });
                collection.Add(new Visit{ date = row[0].ToString(), hour = row[1].ToString(), realized = bool.Parse(row[2].ToString()) });
            }
            

            return collection;
        }
    }
}
