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

namespace Programowanie3ProjektZaliczeniowyRadosławBoczoń.WPF_Controls.DB_CONTROLS
{
    /// <summary>
    /// Interaction logic for Apointments_C.xaml
    /// </summary>
    public partial class Apointments_C : UserControl
    {
        public static Apointments_C _instance
        {
            get;
            set;
        }
        public Apointments_C()
        {
            InitializeComponent();
            _instance = this;
        }
    }
}
