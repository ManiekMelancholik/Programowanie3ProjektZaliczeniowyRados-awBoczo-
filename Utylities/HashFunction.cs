using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programowanie3ProjektZaliczeniowyRadosławBoczoń.Utylities
{
    public class HashFunction
    {
        private static string hashString = "123";
        public static string HashString(string s)
        {
            return s + hashString;
        }
    }
}
