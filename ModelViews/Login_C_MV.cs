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
    using Programowanie3ProjektZaliczeniowyRadosławBoczoń.Views;
    using Programowanie3ProjektZaliczeniowyRadosławBoczoń.Model;

    public class Login_C_MV
    {
        public Login_C_MV() { }

        #region properties
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
        #endregion
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
                            User.SetNewUser(login, password, "ADMIN");
                            MV_Control.SetView(new LogedInView());
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
