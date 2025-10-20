using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.VisualBasic.ApplicationServices;
using ScottPlot.Rendering.RenderActions;
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
    public partial class AddUser : Form
    {
        public Mod mod;

        public AddUser(Mod mod)
        {
            this.mod = mod;
            InitializeComponent();
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            lowerBoundNUD.Visible = false;
            upperBoundNUD.Visible = false;
            LowerBoundLbl.Visible = false;
            UpperBoundLbl.Visible = false;
            comboTxt.Visible = false;
            comboLbl.Visible = false;

            // ToolTips
            var tips = new ToolTip();
            tips.SetToolTip(trackBarRadioBtn, "Use a slider (TrackBar) with numeric bounds");
            tips.SetToolTip(numUpDownRadioBtn, "Use a numeric input with lower/upper bounds");
            tips.SetToolTip(comboBoxRadioBtn, "Use a dropdown with custom options");
            tips.SetToolTip(lowerBoundNUD, "Lower bound");
            tips.SetToolTip(upperBoundNUD, "Upper bound");
            tips.SetToolTip(comboTxt, "Enter options separated by commas, e.g. Low,Medium,High");
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
            graphBox.Enabled = true;
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
            graphBox.Enabled = true;
        }

        private void comboBoxRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            lowerBoundNUD.Visible = false;
            upperBoundNUD.Visible = false;
            LowerBoundLbl.Visible = false;
            UpperBoundLbl.Visible = false;
            comboTxt.Visible = true;
            comboLbl.Visible = true;
            graphBox.SelectedItem = "Bar";
            graphBox.Enabled = false;
        }


        private void approveBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTxt.Text))
            {
                MessageBox.Show("Please enter the users name.", "No name specified");
                return;
            }

            if (string.IsNullOrWhiteSpace(passTxt.Text))
            {
                MessageBox.Show("Please enter the users password.", "No password specified");
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

            var lBound = lowerBoundNUD.Value;
            var uBound = upperBoundNUD.Value;

            if (lBound >= uBound && !comboBoxRadioBtn.Checked)
            {
                MessageBox.Show("Please select valid bounds", "Invalid Bounds");
                return;
            }

            ICategory newCategory = null;
            var graphType = graphBox.Text as string;

            if (trackBarRadioBtn.Checked)
            {
                var track = new TrackBar { TickStyle = TickStyle.None, Width = 200 };
                var bounds = new ArrayList { lBound * 10, uBound * 10 };
                newCategory = new Category<double>(questionTxt.Text, bounds, track, graphType);
            }
            else if (numUpDownRadioBtn.Checked)
            {
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

            Random random = new Random();
            int id = random.Next(10000, 99999);
            MessageBox.Show($"Generated User ID: {id}", "User ID");

            User newUser = new User(id, passTxt.Text, nameTxt.Text, mod.id);
            
            mod.users.Add(newUser);
            FileManager.accounts.Add(newUser);

            var lines = new List<string>(File.ReadAllLines("initaccounts.txt"));
            for (int i = 0; i < lines.Count; i++)
            {
                var info = lines[i].Split(',');
                if (Convert.ToInt32(info[1]) == mod.id)
                {
                    lines[i] += $",{id}"; 
                }
            }

            File.WriteAllLines("initaccounts.txt", lines);

            string userTxt = $"U,{id},{nameTxt.Text},{passTxt.Text},{mod.id}";
            File.AppendAllText("initaccounts.txt", userTxt + Environment.NewLine);

            ExcelManager.InitialiseDb(newUser);
            ExcelManager.AddQuestion(newUser, newCategory);
            newUser.categories.Add(newCategory);

            MessageBox.Show("Added " + newUser.name + " to the system.", "Success");
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // Close the current window
            this.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void userQuestionsTitleLbl_Click(object sender, EventArgs e)
        {

        }
    }
}
