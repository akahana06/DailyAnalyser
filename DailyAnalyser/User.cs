using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyAnalyser
{
    public class User : Account
    {
        public Mod mod;
        public List<ICategory> categories; // List of all questions

        public User() {
            role = Role.U;
            id = 0;
            password = name = "";
            mod = new Mod();
            categories = new List<ICategory>();
        }

        public User(int i, string p, string n)
        {
            role = Role.U;
            id = i;
            password = p;
            name = n;
            mod = new Mod();
            categories = new List<ICategory>();
            //categories = FileManager.LoadCategories(this); implement after i/o
        }

        public override string ToString() {
            return name;
        }
        
    }
}
