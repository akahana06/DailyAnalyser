using Microsoft.VisualBasic.ApplicationServices;

namespace DailyAnalyser
{
    public partial class LoginForm : Form
    {
        public List<Account> accounts;
        
        public LoginForm()
        {
            InitializeComponent();
            
            // Will eventually hold a list of Accounts and based on Account.Role will open user/mod menu
            // The code below is temporary and is just used to hardcode users for testing, will be changed later
            accounts = new List<Account>();
            
            User user = new User(11111, "321", "Guy");
            user.categories = FileManager.InitCategories();
            accounts.Add(user);

            User user2 = new User(33333, "333", "Guy 2");
            user2.categories = FileManager.InitCategories2();
            accounts.Add(user2);

            Mod mod = new Mod(22222, "123", "Mort");
            mod.users.Add(user);
            mod.users.Add(user2);
            accounts.Add(mod);

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            bool foundUser = false;
            foreach (Account acc in accounts) 
            {
                if (Convert.ToInt32(userBox.Text).Equals(acc.id) && passBox.Text.Equals(acc.password)) // Temp login from constructor
                {
                    foundUser = true;
                    MessageBox.Show($"Welcome, {acc.name}", "Login", MessageBoxButtons.OK);

                    if (acc.role == Account.Role.U)
                    {
                        UserMenu userMenu = new UserMenu((User)acc);
                        userMenu.ShowDialog();
                    } else
                    {
                        ModMenu modMenu = new ModMenu((Mod)acc);
                        modMenu.ShowDialog();
                    }
                }
            }
            if (!foundUser)
                MessageBox.Show("Invalid credentials", "Invalid Login", MessageBoxButtons.OK);
        }
    }
}
