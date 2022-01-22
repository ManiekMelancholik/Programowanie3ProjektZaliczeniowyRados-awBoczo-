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
        Login_C control;
        public Login_C_MV()
        {
            control = new Login_C();
            control.DataContext = this;

        }
        private ICommand _enter;
        public ICommand enter
        {
            get
            {
                if (enter == null)
                {
                    _enter = new ACC(
                        exec =>
                        {
                            MessageBox.Show("Clicked Enter Button");
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
