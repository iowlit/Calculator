using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcClass
{
    class MathOperations
    {
        private static string _lastError = "";
        public static string lastError
        {
            get { return _lastError; }
            set { _lastError = value; }
        }
    }
}
