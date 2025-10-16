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
                userCBox.Items.Add(user);
            }

        }

        private void ModUserQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            userQuestionsCBox.Items.Clear();

            User selectedUser = userCBox.SelectedItem as User;
            if (selectedUser == null) return;

            outstandingQuestionsLbl.Text = selectedUser.name + " has " + selectedUser.PendingQuestions.Count + " questions to approve.";

            foreach (string question in selectedUser.PendingQuestions)
            {
                userQuestionsCBox.Items.Add(question);
            }

        }

        private void approveBtn_Click(object sender, EventArgs e)
        {
            var selectedUser = userCBox.SelectedItem as User;
            if (selectedUser == null)
            {
                MessageBox.Show("Please select a user first.", "No user selected");
                return;
            }

            var selectedQuestion = userQuestionsCBox.SelectedItem as string;
            if (string.IsNullOrWhiteSpace(selectedQuestion))
            {
                MessageBox.Show("Please select a question to approve.", "No question selected");
                return;
            }

            ICategory newCategory = null;

            if (trackBarRadioBtn.Checked)
            {
                var track = new TrackBar { TickStyle = TickStyle.None, Width = 200 };
                var bounds = new ArrayList { 0, 100 };
                newCategory = new Category<double>(selectedQuestion, bounds, track);
            }
            else if (numUpDownRadioBtn.Checked)
            {
                var nud = new NumericUpDown();
                var bounds = new ArrayList { 1, 10 };
                newCategory = new Category<int>(selectedQuestion, bounds, nud);
            }
            else if (comboBoxRadioBtn.Checked)
            {
                var combo = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList };
                var bounds = new ArrayList { "Low", "Medium", "High" };
                newCategory = new Category<string>(selectedQuestion, bounds, combo);
            }
            else
            {
                MessageBox.Show("Choose a control type (Track Bar, Numeric, or Combo).", "Type not selected");
                return;
            }

            selectedUser.categories.Add(newCategory);

            selectedUser.PendingQuestions.Remove(selectedQuestion);
            outstandingQuestionsLbl.Text = $"{selectedUser.name} has {selectedUser.PendingQuestions.Count} questions to approve.";
            userQuestionsCBox.Items.Clear();
            foreach (var q in selectedUser.PendingQuestions)
                userQuestionsCBox.Items.Add(q);

            MessageBox.Show("Approved and added to user’s categories.", "Success");
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // Close the current window
            this.Close();
        }
    }
}
