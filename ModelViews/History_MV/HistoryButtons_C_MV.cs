using Programowanie3ProjektZaliczeniowyRadosławBoczoń.Utylities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Programowanie3ProjektZaliczeniowyRadosławBoczoń.ModelViews.History_MV
{
    public class HistoryButtons_C_MV
    {
        public HistoryButtons_C_MV() { }

        private ICommand _prev;
        public ICommand prev
        {
            get
            {
                if (_prev == null)
                {
                    _prev = new ACC(
                        e =>
                        {
                            MessageBox.Show("Previous");

                        },
                        ce =>
                        {
                            return true;
                        }
                        );
                }
                return _prev;
            }
        }

        private ICommand _next;
        public ICommand next
        {
            get
            {
                if (_next == null)
                {
                    _next = new ACC(
                        e =>
                        {
                            MessageBox.Show("Next");
                        },
                        ce =>
                        {
                            return true;
                        }
                        );
                }
                return _next;
            }
        }


    }
}
