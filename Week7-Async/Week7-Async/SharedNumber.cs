using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week7_Async
{
    public class SharedNumber
    {
        private static readonly object _numberLock = new object();

        private static int number = 0;

        public static int GetNumber()
        {
            lock (_numberLock)
            {
                return number++;
            }
        }
    }
}
