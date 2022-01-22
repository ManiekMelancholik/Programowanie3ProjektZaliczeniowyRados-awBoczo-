using Programowanie3ProjektZaliczeniowyRadosławBoczoń.Utylities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Programowanie3ProjektZaliczeniowyRadosławBoczoń
{


    public class MV_Control
    {
        //private static List<Tuple<string, UserControl>> registeredViews;

        //private MainWindow _mw;
        public MV_Control() { }

        //private static MV_Control _instance;



        //public static MV_Control CTRL
        //{
        //    get
        //    {
        //        Generate();

        //        //return _instance;
        //    }
        //}
        //private MV_Control(MainWindow mw) 
        //{
        //    //_mw = mw;
        //    MessageBox.Show("MV_COntrol is beeing generated");
        //}

        //private static void Generate()
        //{
        //    if (_instance == null)
        //        _instance = new MV_Control(MainWindow.GetInstance());

        //    //MessageBox.Show("Generated MV_COntrol");
            
        //}

        //public static void RegisterView()
        //{

        //}
        public static void SetView(UserControl view)
        {
            MainWindow.GetInstance().MainWindowContent.Child = view;

        }

    //    private ICommand _startup;
    //    public ICommand startup
    //    {
    //        get
    //        {
    //            if (_startup == null)
    //            {
    //                _startup = new ACC(
    //                    e =>
    //                    {
    //                       // MV_Control.Generate();
    //                    },
    //                    ce =>
    //                    {
    //                        return true;
    //                    }
    //                    );
    //            }
    //            return _startup;
    //        }
    //    }
        
    }
}

