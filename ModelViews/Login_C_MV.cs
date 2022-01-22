using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Programowanie3ProjektZaliczeniowyRadosławBoczoń.ModelViews
{
    using Utylities;
    using System.Windows.Controls;
    using System.Windows.Input;
    using WPF_Controls;
    using System.Windows;

    public class Login_C_MV
    {
        public Login_C_MV() { }


        private string _login;
        private string _password;
        public string login
        {
            get
            {
                if (_login == null)
                    return "null";
                return _login;

            }
            set
            {
                _login = value;
            }
        }
        public string password
        {
            get
            {
                if (_password == null)
                    return "null";
                return _password;
            }
            set
            {
                _password = value;
            }
        }

        private ICommand _enter;
        public ICommand enter
        {
            get
            {
                if (_enter == null)
                {
                    _enter = new ACC(
                        exec =>
                        {
                            MessageBox.Show($"loging as\n\n{login}\n\n{password}" );
                        },
                        canExec =>
                        {
                            return true;
                        });
                }

                return _enter;
            }

        }
    }
}
