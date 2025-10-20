using Microsoft.EntityFrameworkCore.Diagnostics;
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
        public int modID;
        public List<ICategory> categories; // List of all questions
        public List<string> PendingQuestions;

        public User() {
            role = Role.U;
            id = 0;
            password = name = "";
            mod = new Mod();
            categories = new List<ICategory>();
            PendingQuestions = new List<string>();
        }

        public User(int i, string p, string n, int modid)
        {
            role = Role.U;
            id = i;
            password = p;
            name = n;
            mod = new Mod();
            this.modID = modid;
            categories = new List<ICategory>();
            PendingQuestions = new List<string>();
            //categories = FileManager.LoadCategories(this); implement after i/o
        }

        public void LoadData(bool init)
        {
            categories = ExcelManager.LoadCategories(this, init);
            PendingQuestions = FileManager.LoadRequests(this, init);
        }

        public void LoadMod()
        {
            foreach (Account account in FileManager.accounts)
            {
                if (account.id == modID)
                {
                    mod = (Mod)account;
                }
            }
        }

        public override string ToString() {
            return name;
        }
        
    }
}
