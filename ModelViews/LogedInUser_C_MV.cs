using Programowanie3ProjektZaliczeniowyRadosławBoczoń.Model;
using Programowanie3ProjektZaliczeniowyRadosławBoczoń.Utylities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Programowanie3ProjektZaliczeniowyRadosławBoczoń.ModelViews
{
    public class LogedInUser_C_MV
    {
        private User user = User.instance;
        public LogedInUser_C_MV() { }
        #region properties
        private string _userName;
        public string userName
        {
            get
            {
                if (_userName == null)
                {
                    if (user == null)
                    {
                        return "null";
                    }
                    else
                    {
                        _userName = user.name;
                    }
                }
                   
                return _userName;
            }
            
        }
        private string _privLvl;
        public string privLvl
        {
            get
            {
                if (_privLvl == null)
                {
                    if (user == null)
                    {
                        return "null";
                    }
                    else
                    {
                        _privLvl = user.privLvl;
                    }
                }
                   
                return _privLvl;
                    
            }
          
        }
        #endregion
        private ICommand _showUserData;
        public ICommand showUserData
        {
            get
            {
                if (_showUserData == null)
                {
                    _showUserData = new ACC(
                        e =>
                        {
                            MessageBox.Show("Showing: \nUserData");
                        },
                        ce =>
                        {
                            return true;
                        }
                        );
                }

                return _showUserData;
            }
        }
    }
}
