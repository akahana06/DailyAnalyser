using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
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
            lowerBoundNUD.Visible = false;
            upperBoundNUD.Visible = false;
            LowerBoundLbl.Visible = false;
            UpperBoundLbl.Visible = false;
            comboTxt.Visible = false;
            comboLbl.Visible = false;

            foreach (User user in mod.users)
            {
                userCBox.Items.Add(user);
            }

            // ToolTips
            var tips = new ToolTip();
            tips.SetToolTip(userCBox, "Select the user whose pending questions you will review");
            tips.SetToolTip(userQuestionsCBox, "Pick a pending question to approve");
            tips.SetToolTip(trackBarRadioBtn, "Use a slider (TrackBar) with numeric bounds");
            tips.SetToolTip(numUpDownRadioBtn, "Use a numeric input with lower/upper bounds");
            tips.SetToolTip(comboBoxRadioBtn, "Use a dropdown with custom options");
            tips.SetToolTip(lowerBoundNUD, "Lower bound");
            tips.SetToolTip(upperBoundNUD, "Upper bound");
            tips.SetToolTip(comboTxt, "Enter options separated by commas, e.g. Low,Medium,High");
        }

        private void userCBox_SelectedIndexChanged(object sender, EventArgs e)
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

        private void comboBoxRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            lowerBoundNUD.Visible = false;
            upperBoundNUD.Visible = false;
            LowerBoundLbl.Visible = false;
            UpperBoundLbl.Visible = false;
            comboTxt.Visible = true;
            comboLbl.Visible = true;
            questionTxt.Text = userQuestionsCBox.Text;
        }

        private void userQuestionsCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            questionTxt.Text = userQuestionsCBox.Text;
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

            if (string.IsNullOrEmpty(graphBox.Text))
            {
                MessageBox.Show("Please select a graph type first.", "No type selected");
                return;
            }

            if (string.IsNullOrWhiteSpace(questionTxt.Text))
            {
                MessageBox.Show("Please enter a question title", "No question selected");
                return;
            }

            ICategory newCategory = null;

            var graphType = graphBox.Text as string;
            if (trackBarRadioBtn.Checked)
            {
                var lBound = lowerBoundNUD.Value;
                var uBound = upperBoundNUD.Value;
                var track = new TrackBar { TickStyle = TickStyle.None, Width = 200 };
                var bounds = new ArrayList { lBound*10, uBound*10 };
                newCategory = new Category<double>(questionTxt.Text, bounds, track, graphType);
            }
            else if (numUpDownRadioBtn.Checked)
            {
                var lBound = lowerBoundNUD.Value;
                var uBound = upperBoundNUD.Value;
                var nud = new NumericUpDown();
                var bounds = new ArrayList { lBound, uBound };
                newCategory = new Category<int>(questionTxt.Text, bounds, nud, graphType);
            }
            else if (comboBoxRadioBtn.Checked)
            {
                var combo = new ComboBox { DropDownStyle = ComboBoxStyle.DropDownList };
                var bounds = new ArrayList(comboTxt.Text.Split(','));
                newCategory = new Category<string>(questionTxt.Text, bounds, combo, graphType);
            }
            else
            {
                MessageBox.Show("Choose a control type (Track Bar, Numeric, or Combo).", "Type not selected");
                return;
            }

            ExcelManager.AddQuestion(selectedUser, newCategory);
            selectedUser.categories.Add(newCategory);

            selectedUser.PendingQuestions.Remove(selectedQuestion);

            outstandingQuestionsLbl.Text = $"{selectedUser.name} has {selectedUser.PendingQuestions.Count} questions to approve.";
            userQuestionsCBox.Items.Clear();
            foreach (var q in selectedUser.PendingQuestions)
                userQuestionsCBox.Items.Add(q);

            File.WriteAllText($"{selectedUser.id}req.txt", "");
            if (selectedUser.PendingQuestions.Count == 0) return;
            foreach (string q in selectedUser.PendingQuestions)
            {
                File.AppendAllText($"{selectedUser.id}req.txt", q + Environment.NewLine);
            }

            MessageBox.Show("Approved and added to " + selectedUser.name + "'s categories.", "Success");
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // Close the current window
            this.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
