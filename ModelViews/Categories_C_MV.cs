using Programowanie3ProjektZaliczeniowyRadosławBoczoń.Utylities;
using Programowanie3ProjektZaliczeniowyRadosławBoczoń.WPF_Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Programowanie3ProjektZaliczeniowyRadosławBoczoń.ModelViews
{
    public class Categories_C_MV
    {
        public Categories_C_MV() { }

        private ICommand _searchCosmetics;

        public ICommand searchCosmetics
        {
            get
            {
                if (_searchCosmetics == null)
                {
                    _searchCosmetics = new ACC(
                        e =>
                        {
                            MV_Control.SetView(new TestSearch_C());
                        },
                        ce=>
                        {
                            return true;
                        }
                        
                        );
                }
                return _searchCosmetics;
            }
        }




    }
}
