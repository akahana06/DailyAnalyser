using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace DailyAnalyser
{
    static class FileManager
    {
        // This function will eventually return a list of categories from I/O but for now it uses InitCategories()
        public static List<Account> accounts = new List<Account>();
                
        public static void LoadAccounts(string filename, bool init)
        {
            StreamReader sr = new StreamReader(filename);
            while(!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] info = line.Split(',');
                if (info[0] == "U")
                {
                    User u = new User(Convert.ToInt32(info[1]), info[3], info[2], Convert.ToInt32(info[4]));
                    u.LoadData(init);
                    accounts.Add(u);
                } else if (info[0] == "M")
                {
                    List<string> userIDs = new List<string>();
                    for (int i = 4; i < info.Length; i++)
                    {
                        userIDs.Add(info[i]);
                    }
                    Mod m = new Mod(Convert.ToInt32(info[1]), info[3], info[2], userIDs);
                    accounts.Add(m);
                }

            }
            foreach (Account account in accounts)
            {
                if (account.role == Account.Role.U)
                {
                    ((User)account).LoadMod();
                    if (init || !File.Exists($"{account.id}.xlsx")) ExcelManager.InitialiseDb((User)account);
                }
                else
                {
                    ((Mod)account).LoadUsers();
                }
            }
            sr.Close();

        }
        

        public static void WriteInitAccounts()
        {
            File.Delete("11111.xlsx");
            File.Delete("33333.xlsx");
            File.Delete("initaccounts.txt");
            string text = "";
            text += "U,11111,Guy,321,22222\n";
            text += "U,33333,Guy2,333,22222\n";
            text += "M,22222,Mord,123,11111,33333";
            File.WriteAllText("initaccounts.txt", text);
        }
        

        public static List<string> LoadRequests(User user, bool init)
        {
            List<string> pendingRequests = new();
            
            string filename = $"{user.id}req.txt";
            if (!File.Exists(filename) || init)
            {
                File.WriteAllText($"{user.id}req.txt", "");
                return new List<string>();
            }

            StreamReader sr = new StreamReader(filename);
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                pendingRequests.Add(line);
            }
            sr.Close();
            return pendingRequests;
        }

    }
}
