using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games_Rental_System
{
    internal class User
    {
        static string UsernName = "alex";
        static bool AdminEnabled = false;
        public static string User_Name
        {
            get => UsernName;
            set => UsernName = value;
        }
        public static bool isAdmin
        {
            get => AdminEnabled;
            set => AdminEnabled = value;
        }
    }
}
