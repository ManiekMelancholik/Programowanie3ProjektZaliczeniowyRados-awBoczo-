using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie3ProjektZaliczeniowyRadosławBoczoń.Utylities.DataBase
{
    public interface IQuerry
    {
        public abstract DataTable? ExecuteQuerry();

        public abstract bool ValidateQuerry();

    }
}
