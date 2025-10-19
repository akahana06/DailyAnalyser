using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyAnalyser
{
    public abstract class Account // Superclass of User and Mod
    {
        public int id;
        public string password;
        public string name;
        public Role role;

        public Account() {
            id = 0;
            password = name = "";
        }

        public enum Role // Enum, U = User Account, M = Moderator Account
        {
            U,
            M
        }

        

    }
}
