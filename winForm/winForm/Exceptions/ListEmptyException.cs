using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    public class ListEmptyException : Exception
    {
        /*This exception exists to catch exceptions due to the spdArray and distArray Lists 
         * being empty. This case could arise if one of the comparison methods (avg, min, max)
         * are called before populateLists() */

        public ListEmptyException(string message)
            : base(message)
        {
        }
    }
}
