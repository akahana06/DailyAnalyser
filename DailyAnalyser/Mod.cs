using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyAnalyser
{
    
    public class Mod : Account
    {
        public List<User> users = new List<User>();

        public Mod() {
            role = Role.M;
            id = 0;
            password = name = "";
        }

        public Mod(int i, string p, string n)
        {
            role = Role.M;
            id = i;
            password = p;
            name = n;
        }
        
    }
}
