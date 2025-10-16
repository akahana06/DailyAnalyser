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
    public partial class ModUserData : Form
    {
        public Mod mod;

        public ModUserData(Mod mod)
        {
            this.mod = mod;
            InitializeComponent();
        }

        private void UserDataMenu_Load(object sender, EventArgs e)
        {

            foreach (User user in mod.users)
            {
                userCBox.Items.Add(user);
            }
        }

        private void userCBox_SelectedIndexChanged(object sender, EventArgs e) {
            questionCBox.Items.Clear();

            User selectedUser = (User)userCBox.SelectedItem;
            foreach (ICategory cat in selectedUser.categories)
            {
                questionCBox.Items.Add(cat.ToString());
            }
            userNameLbl.Text = selectedUser.name;
            userIDLbl.Text = selectedUser.id.ToString();
            questionLbl.Text = " ";
        }

        private void questionCBox_SelectedIndexChanged(Object sender, EventArgs e)
        {
            questionLbl.Text = questionCBox.SelectedItem.ToString();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        
    }
}
