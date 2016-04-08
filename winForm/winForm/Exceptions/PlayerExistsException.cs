using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    public class PlayerExistsException : Exception
    {
        /*This exception exists to catch exceptions where the user tries to 
         * add a new a database entry with an ID that is already present 
         * in the database*/

        public PlayerExistsException(string message)
            : base(message)
        {
        }
    }
}


