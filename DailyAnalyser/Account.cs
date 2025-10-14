using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyAnalyser
{
    public abstract class Account
    {
        public int id;
        public string password;
        public string name;

        public Account() {
            id = 0;
            password = name = "";
        }

        public enum Role
        {
            U,
            M
        }

        public Role AccRole { get; set; }
    }
}
