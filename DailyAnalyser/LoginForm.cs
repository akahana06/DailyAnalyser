namespace DailyAnalyser
{
    public partial class LoginForm : Form
    {
        public User user;
        public Mod mod;
        
        public LoginForm()
        {
            InitializeComponent();
            user = new User(11111, "321", "Guy");
            mod = new Mod(22222, "123", "Mort");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(userBox.Text).Equals(user.id) && passBox.Text.Equals(user.password))
            {
                MessageBox.Show($"Welcome, {user.name}", "Login", MessageBoxButtons.OK);

                UserMenu usermenu = new UserMenu(user);
                usermenu.ShowDialog();
            } else if (Convert.ToInt32(userBox.Text).Equals(mod.id) && passBox.Text.Equals(mod.password))
            {
                MessageBox.Show($"Welcome, {mod.name}", "Login", MessageBoxButtons.OK);

                ModMenu modmenu = new ModMenu(mod);
                modmenu.ShowDialog();
            } else
            {
                MessageBox.Show("Login Unsuccessful", "Login", MessageBoxButtons.OK);
            }
        }
    }
}
