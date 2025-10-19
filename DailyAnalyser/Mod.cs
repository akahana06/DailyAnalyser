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
        public List<string> userIDs = new List<string>();

        public Mod() {
            role = Role.M;
            id = 0;
            password = name = "";
        }

        public Mod(int i, string p, string n, List<string> userIDs)
        {
            role = Role.M;
            id = i;
            password = p;
            name = n;
            this.userIDs = userIDs;
        }

        public void LoadUsers()
        {
            MessageBox.Show("Debug", "Devyg");
            foreach (string uid in userIDs)
            {
                foreach (Account account in FileManager.accounts)
                {
                    MessageBox.Show("Debug");
                    if (account.id == Convert.ToInt32(uid))
                    {
                        users.Add((User)account);
                    }
                }
            }
        }
    }
}
