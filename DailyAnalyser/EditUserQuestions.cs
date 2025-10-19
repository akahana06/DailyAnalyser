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
            lowerBoundNUD.Visible = false;
            upperBoundNUD.Visible = false;
            LowerBoundLbl.Visible = false;
            UpperBoundLbl.Visible = false;
            comboTxt.Visible = false;
            comboLbl.Visible = false;
            removeQuestionBtn.Enabled = false;

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
                questionsLBox.Items.Add(category);
            }

        }

        private void questionsLBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeQuestionBtn.Enabled = true;
        }

        private void removeQuestionBtn_Click(object sender, EventArgs e)
        {
            if (questionsLBox.SelectedItem == null)   //Check if anything selected from listbox
            {
                MessageBox.Show("Please select an item to remove.", "No Selection", //Warn user if empty
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            object selected = questionsLBox.SelectedItem;  //Select entry from listbox
            User user = (User)userCBox.SelectedItem;

            DialogResult result = MessageBox.Show(
                $"Remove '{selected.ToString()}' from the list?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);    //Warn user

            if (result == DialogResult.Yes)
            {
                questionsLBox.Items.Remove(selected);
                foreach (ICategory cat in user.categories)
                {
                    if (cat == selected)
                    {
                        user.categories.Remove(cat);
                        break;
                    }
                }//Remove from listbox
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            // Close the current window
            this.Close();
        }

        private void trackBarRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            bool showBounds = trackBarRadioBtn.Checked;
            lowerBoundNUD.Visible = showBounds;
            upperBoundNUD.Visible = showBounds;
            LowerBoundLbl.Visible = showBounds;
            UpperBoundLbl.Visible = showBounds;
            comboTxt.Visible = false;
            comboLbl.Visible = false;
        }

        private void numUpDownRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            bool showBounds = numUpDownRadioBtn.Checked;
            lowerBoundNUD.Visible = showBounds;
            upperBoundNUD.Visible = showBounds;
            LowerBoundLbl.Visible = showBounds;
            UpperBoundLbl.Visible = showBounds;
            comboTxt.Visible = false;
            comboLbl.Visible = false;
        }
        private void newQuestionBtn_Click(object sender, EventArgs e)
        {
            var selectedUser = userCBox.SelectedItem as User;
            var newQuestion = newQuestionTBox.Text as string;

            if (selectedUser == null)
            {
                MessageBox.Show("Please select a user", "User not selected");
                return;
            }
            if (newQuestion == "")
            {
                MessageBox.Show("Please enter a question name", "Question not specified");
                return;
            }
            ICategory newCategory = null;

            if (trackBarRadioBtn.Checked)
            {
                var lBound = lowerBoundNUD.Value;
                var uBound = upperBoundNUD.Value;
                var track = new TrackBar { TickStyle = TickStyle.None, Width = 200 };
                var bounds = new ArrayList { lBound*10, uBound*10 };
                newCategory = new Category<double>(newQuestion, bounds, track);
            }
            else if (numUpDownRadioBtn.Checked)
            {
                var lBound = lowerBoundNUD.Value;
                var uBound = upperBoundNUD.Value;
                var nud = new NumericUpDown();
                var bounds = new ArrayList { lBound, uBound };
                newCategory = new Category<int>(newQuestion, bounds, nud);
            }
            else if (comboBoxRadioBtn.Checked)
            {
                var combo = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList };
                var bounds = new ArrayList (comboTxt.Text.Split(','));
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

        private void comboBoxRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            lowerBoundNUD.Visible = false;
            upperBoundNUD.Visible = false;
            LowerBoundLbl.Visible = false;
            UpperBoundLbl.Visible = false;
            comboTxt.Visible = true;
            comboLbl.Visible = true;
        }
    }
}
