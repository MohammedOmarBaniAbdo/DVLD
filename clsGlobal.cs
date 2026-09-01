using BLLPeopleDVLD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD1
{
    internal class clsGlobal
    {
        public static string UserName { get; set; }
        public static int UserID { get; private set; }

        public static void LoadUser(string userName)
        {
            UserName = userName;

            BLLUser user = BLLUser.FindByUserName(UserName);

            if (user != null)
            {
                UserID = user.UserID;
            }
        }
    }
}
