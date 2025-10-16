using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyAnalyser
{
    public partial class ModMenu : Form
    {
        private Mod mod;
        public ModMenu(Mod m)
        {
            InitializeComponent();
            mod = m;
        }

        private void ModMenu_Load(object sender, EventArgs e)
        {

        }

        private void viewUserBtn_Click(object sender, EventArgs e)
        {
            ModUserData userDataMenu = new ModUserData(mod);
            userDataMenu.ShowDialog();
        }

        private void updateQBtn_Click(object sender, EventArgs e)
        {
            ModUserQuestions userQuestionsMenu = new ModUserQuestions(mod);
            userQuestionsMenu.ShowDialog();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();

            // Reopen the login form
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void editUserQuestions_Click(object sender, EventArgs e)
        {
            EditUserQuestions ModEditUserData = new EditUserQuestions(mod);
            ModEditUserData.ShowDialog();
        }
    }
}
