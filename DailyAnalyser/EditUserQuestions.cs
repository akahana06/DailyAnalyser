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

        private void newQuestionBtn_Click(object sender, EventArgs e)
        {
            var selectedUser = userCBox.SelectedItem as User;
            var newQuestion = newQuestionTBox.Text as string;

            ICategory newCategory = null;

            if (trackBarRadioBtn.Checked)
            {
                var track = new TrackBar { TickStyle = TickStyle.None, Width = 200 };
                var bounds = new ArrayList { 0, 100 };
                newCategory = new Category<double>(newQuestion, bounds, track);
            }
            else if (numUpDownRadioBtn.Checked)
            {
                var nud = new NumericUpDown();
                var bounds = new ArrayList { 1, 10 };
                newCategory = new Category<int>(newQuestion, bounds, nud);
            }
            else if (comboBoxRadioBtn.Checked)
            {
                var combo = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList };
                var bounds = new ArrayList { "Low", "Medium", "High" };
                newCategory = new Category<string>(newQuestion, bounds, combo);
            }
            else
            {
                MessageBox.Show("Choose a control type (Track Bar, Numeric, or Combo).", "Type not selected");
                return;
            }

            selectedUser.categories.Add(newCategory);

            MessageBox.Show("Added to " + selectedUser.name + "'s categories.", "Success");

            questionsLBox.Items.Clear();
            newQuestionTBox.Clear();

            foreach (ICategory category in selectedUser.categories)
            {
                questionsLBox.Items.Add(category.Question);
            }
        }
    }
}
