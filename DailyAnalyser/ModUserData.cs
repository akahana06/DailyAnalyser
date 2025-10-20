using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScottPlot.WinForms; // .NET 8 doesn't support System.Windows.Forms.Datavisualization
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Office2010.Word.DrawingCanvas;
using System.Collections;

namespace DailyAnalyser
{
    public partial class ModUserData : Form
    {
        public Mod mod;

        public ModUserData(Mod mod)
        {
            this.mod = mod;
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(820, 500);
            this.Font = new Font("Segoe UI", 9F);
        }

        private void UserDataMenu_Load(object sender, EventArgs e)
        {

            foreach (User user in mod.users)
            {
                userCBox.Items.Add(user);
            }
        }

        private void userCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            questionCBox.Items.Clear();

            User selectedUser = (User)userCBox.SelectedItem;
            foreach (ICategory cat in selectedUser.categories)
            {
                questionCBox.Items.Add(cat);
            }
            userNameLbl.Text = selectedUser.name;
            userIDLbl.Text = selectedUser.id.ToString();
            questionLbl.Text = " ";
            comboLbl.Text = "";
            dataBox.Controls.Clear();
        }

        private void questionCBox_SelectedIndexChanged(Object sender, EventArgs e)
        {
            dataBox.Controls.Clear();
            dataBox.Controls.Add(questionLbl);

            ICategory category = questionCBox.SelectedItem as ICategory;
            string question = category.Question;
            questionLbl.Text = question;
            comboLbl.Text = "";

            User user = (User)userCBox.SelectedItem;
            Type type = category.GetType().GetGenericArguments()[0];

            FormsPlot formsPlot;
            if (category.GraphType == "Line")
            {
                formsPlot = GraphBuilder.buildLineGraph(ExcelManager.ReadNumQuestionAnswers(user, question));
            } else if (category.GraphType == "Bar")
            {
                if (type == typeof(string))
                {
                    ArrayList bounds = category.Bounds;
                    formsPlot = GraphBuilder.buildStringBarGraph(ExcelManager.ReadStringQuestionAnswers(user, question), category.Bounds);
                    comboLbl.Text = $"(1 = {bounds[0]}, {bounds.Count} = {bounds[bounds.Count-1]})";
                }
                else
                {
                    formsPlot = GraphBuilder.buildNumBarGraph(ExcelManager.ReadNumQuestionAnswers(user, question));
                }
            } else
            {
                MessageBox.Show("Error", "Error");
                return;
            }

            formsPlot.Plot.Title(question);
            dataBox.Controls.Add(formsPlot);


            

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void userInfoBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
