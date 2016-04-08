using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    public class NoPlayerException : Exception
    {
        /*This exception exists to catch exceptions where the user tries to 
         * update or delete a database entry which does not exist. 
         * This could be due to the user misspelling the ID of the player 
         * they want to update/delete */

        public NoPlayerException(string message)
            : base(message)
        {
        }
    }
}