using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Programowanie3ProjektZaliczeniowyRadosławBoczoń
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static MainWindow _instance;
        public MainWindow()
        {
            InitializeComponent();
            _instance = this;
            //rep.ReportServer.ReportServerUrl = new Uri(@"http://laptop-k83qnn3g", System.UriKind.Absolute).ToString();
           // rep.ReportServer.ReportPath = @"/Reports/report/Report3";
            //rep.RefreshReport();


        }
        public static MainWindow GetInstance()
        {
            if (_instance == null)
                _instance = new MainWindow();
            return _instance;
        }
    }
}
