using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OktatasNyilvantarto
{
    public static class Users
    {
        public static bool IsSuperUser(string[] users)
        {
            foreach (var a in users)
            {
                if (Environment.UserName == a)
                    return true;
            }
            return false;
        }
    }
}
