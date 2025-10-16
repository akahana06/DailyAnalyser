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
    public partial class ModUserQuestions : Form
    {
        public Mod mod;

        public ModUserQuestions(Mod mod)
        {
            this.mod = mod;
            InitializeComponent();
        }

        private void ModUserQuestions_Load(object sender, EventArgs e)
        {

            foreach (User user in mod.users)
            {
                userQCBox.Items.Add(user);
            }

        }

        private void ModUserQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            userQuestionsCBox.Items.Clear();

            User selectedUser = userQCBox.SelectedItem as User;
            if (selectedUser == null) return;

            outstandingQuestionsLbl.Text = selectedUser.name + " has " + selectedUser.PendingQuestions.Count + " questions to approve.";

            foreach (string question in selectedUser.PendingQuestions)
            {
                userQuestionsCBox.Items.Add(question);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // Close the current window
            this.Close();
        }
    }
}
