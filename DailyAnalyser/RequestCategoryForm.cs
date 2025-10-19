using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using ComboBox = System.Windows.Forms.ComboBox;
using TrackBar = System.Windows.Forms.TrackBar;

namespace DailyAnalyser
{
    public partial class RequestCategoryForm : Form
    {
        public User user;
        public bool saved = false;

        public RequestCategoryForm(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void RequestCategoryForm_Load(object sender, EventArgs e)
        {
            foreach (string q in user.PendingQuestions)
            {
                questionsLstBox.Items.Add(q);
            }
            
        }

        private void addQuestionBtn_Click(object sender, EventArgs e)
        {
            string questionText = questionTxtBox.Text; //Get text from textbox
            questionText.Trim();                       //Trim extra whitespace

            if (string.IsNullOrWhiteSpace(questionText))    //Check if anything in textbox
            {
                MessageBox.Show("Please enter a question before adding.", "Empty Field", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //Warn user if empty
            }

            FileManager.WriteRequest(questionText, user.id);
            questionsLstBox.Items.Add(questionText);    //Add to listbox
            questionTxtBox.Clear();                     //Clear textbox

        }

        private void removeQuestionBtn_Click(object sender, EventArgs e)
        {
            if (questionsLstBox.SelectedItem == null)   //Check if anything selected from listbox
            {
                MessageBox.Show("Please select an item to remove.", "No Selection", //Warn user if empty
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selected = questionsLstBox.SelectedItem.ToString();  //Select entry from listbox

            DialogResult result = MessageBox.Show(
                $"Remove '{selected}' from the list?", "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Question);    //Warn user

            if (result == DialogResult.Yes)
            {
                questionsLstBox.Items.Remove(selected);     //Remove from listbox
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in questionsLstBox.Items) //Goes thru listbox adding to pending questions list
            {
                var text = item?.ToString();
                
                user.PendingQuestions.Add(text);
            }

            MessageBox.Show("Requests submitted for moderator review.", "Saved",    //Notify user
            MessageBoxButtons.OK, MessageBoxIcon.Information);

            Close();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            // Close the current window
            this.Close();
        }
    }
}
