using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie3ProjektZaliczeniowyRadosławBoczoń.ModelViews
{
    public class Login_MV
    {
        Login_C_MV _Login_C_MV = new Login_C_MV();
        MainWindow mW = new MainWindow();
        public Login_MV()
        {
            //mW.MainWindowContent.Children.Clear();
           // mW.MainWindowContent.Children.Add( new Views.LoginView());
        }
    }
}
