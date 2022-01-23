using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie3ProjektZaliczeniowyRadosławBoczoń.Model
{
    public class Cosmetic
    {
        public Cosmetic() { }

        public Cosmetic(string n, string pr, string acs, float p)
        {
            _name = n;
            _price = p;
            _mainActiveSubstance = acs;
            _producerName = pr;
        }

        #region properties

        private string _name;
        public string name
        {
            get
            {
                return _name;
            }
        }

        private string _producerName;
        public string producerName
        {
            get
            {
                return _producerName;
            }
        }

        private float _price;
        public float price
        {
            get
            {
                return _price;
            }
        }

        private string _mainActiveSubstance;
        public string mainActiveSubstance
        {
            get
            {
                return _mainActiveSubstance;
            }
        }






        #endregion


    }
}
