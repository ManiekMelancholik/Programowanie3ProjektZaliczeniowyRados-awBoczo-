using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie3ProjektZaliczeniowyRadosławBoczoń.Model
{
    public class User
    {
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
        private string _password;
        public string password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
            }
        }
        private string _privLvl;
        public string privLvl
        {
            get
            {
                return _privLvl;
            }
            set
            {
                _privLvl = value;
            }
        }

        public User() { }
        
        public User(bool f)
        {
            this._name = "no name";
            this._password = "no password";
            this._privLvl = "null";
        }
        


        private static User _instance;
        public static User instance
        {
            get
            {
                if (_instance == null)
                    _instance = new User(false);
                return _instance;
            }
            
        }

        public static void SetNewUser(string n, string pass, string pL)
        {
            if (n == string.Empty || pass == string.Empty)
                _instance = new User(false);
            else
                _instance = new User { name = n, password = pass, privLvl = pL };
        }


    }
}
