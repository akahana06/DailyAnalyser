using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace DailyAnalyser
{
    public partial class EditUserQuestions : Form
    {
        public Mod mod;
        public EditUserQuestions(Mod mod)
        {
            this.mod = mod;
            InitializeComponent();
        }

        private void EditUserQuestions_Load(object sender, EventArgs e)
        {
            foreach (User user in mod.users)
            {
                userCBox.Items.Add(user);
            }
        }

        private void EditUserQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            questionsLBox.Items.Clear();

            User selectedUser = userCBox.SelectedItem as User;
            if (selectedUser == null) return;

            foreach (ICategory category in selectedUser.categories)
            {
                questionsLBox.Items.Add(category.Question);
            }
        }

        private void removeQuestionBtn_Click(object sender, EventArgs e)
        {
            if (questionsLBox.SelectedItem == null)   //Check if anything selected from listbox
            {
                MessageBox.Show("Please select an item to remove.", "No Selection", //Warn user if empty
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selected = questionsLBox.SelectedItem.ToString();  //Select entry from listbox

            DialogResult result = MessageBox.Show(
                $"Remove '{selected}' from the list?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);    //Warn user

            if (result == DialogResult.Yes)
            {
                questionsLBox.Items.Remove(selected);     //Remove from listbox
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            // Close the current window
            this.Close();
        }
    }
}
