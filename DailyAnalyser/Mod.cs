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
        public Mod() {
            AccRole = Role.M;
            id = 0;
            password = name = "";
        }

        public Mod(int i, string p, string n)
        {
            AccRole = Role.U;
            id = i;
            password = p;
            name = n;
        }
        
    }
}
