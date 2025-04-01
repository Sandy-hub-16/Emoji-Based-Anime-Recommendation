using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBAR_BL
{
    public class EBARProcess
    {
        public static bool ValidateEmptyUserName(string userName)
        {
            if (string.IsNullOrEmpty(userName))
            {
                return true;
            }

            return false;
           
        }
    }
}
