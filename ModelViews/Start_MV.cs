using Programowanie3ProjektZaliczeniowyRadosławBoczoń.Utylities;
using Programowanie3ProjektZaliczeniowyRadosławBoczoń.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Programowanie3ProjektZaliczeniowyRadosławBoczoń.ModelViews
{
    public class Start_MV
    {
        public Start_MV() { }
        private ICommand _noLogin;
        private ICommand _login;
        private ICommand _exit;

        public ICommand noLogin
        {
            get
            {
                if(_noLogin == null)
                {
                    _noLogin = new ACC(
                        e =>
                        {
                            MessageBox.Show("Start without logging in");
                            MV_Control.SetView(new GuestView());
                            
                        },
                        ce =>
                        {
                            return true;
                        }
                        );
                }

                return _noLogin;
            }
        }

        public ICommand login
        {
            get
            {
                if(_login == null)
                {
                    _login = new ACC(
                        e =>
                        {
                            MessageBox.Show("Starting LOGING IN");
                            MV_Control.SetView(new LoginView());
                        },
                        ce =>
                        {
                            return true;
                        }
                        );
                }

                return _login;
            }
        }

        public ICommand exit
        {
            get
            {
                if (_exit == null)
                {
                    _exit = new ACC(
                        e =>
                        {
                            MessageBox.Show("EXITING APPLICATION");
                        },
                        ce =>
                        {
                            return true;
                        }
                        );
                }

                return _exit;
            }
        }

        public object MC_Control { get; private set; }
        public object MV { get; private set; }
    }
}
