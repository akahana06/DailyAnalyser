using Microsoft.VisualBasic.ApplicationServices;

namespace DailyAnalyser
{
    public partial class LoginForm : Form
    {
        public List<Account> accounts;
        
        public LoginForm()
        {
            InitializeComponent();

            this.AcceptButton = loginBtn;
            this.CancelButton = loginBtn;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(820, 500);
            this.Font = new Font("Segoe UI", 9F);

            // ToolTips
            var tips = new ToolTip();
            tips.SetToolTip(userBox, "Enter your 5-digit user ID");
            tips.SetToolTip(passBox, "Enter your password");

            DialogResult result = MessageBox.Show("Overwrite data with initial accounts?", "Overwrite data", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                FileManager.WriteInitAccounts();
                FileManager.LoadAccounts("initaccounts.txt", true);
            } else
            {
                FileManager.LoadAccounts("initaccounts.txt", false);
            }      

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
            foreach (Account acc in FileManager.accounts) 
            {
                if (Convert.ToInt32(userBox.Text).Equals(acc.id) && passBox.Text.Equals(acc.password)) // Temp login from constructor
                {
                    foundUser = true;
                    MessageBox.Show($"Welcome, {acc.name}", "Login", MessageBoxButtons.OK);

                    if (acc.role == Account.Role.U)
                    {
                        UserMenu userMenu = new UserMenu((User)acc);
                        this.Hide();
                        userMenu.ShowDialog();
                        this.Show();
                    } else
                    {
                        ModMenu modMenu = new ModMenu((Mod)acc);
                        this.Hide();
                        modMenu.ShowDialog();
                        this.Show();
                    }
                    
                }
            }
            if (!foundUser)
                MessageBox.Show("Invalid credentials", "Invalid Login", MessageBoxButtons.OK);


        }
    }
}
