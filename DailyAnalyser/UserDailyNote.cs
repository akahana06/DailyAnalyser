using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class UserDailyNote : Form
    {
        private User user;

        public UserDailyNote(User user)
        {
            this.user = user;
            this.FormClosing += UserDailyNote_FormClosing;
            InitializeComponent();
        }

        private void UserDailyNote_Load(object sender, EventArgs e)
        {

        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void UserDailyNote_FormClosing(object sender, FormClosingEventArgs e)
        {
            ExcelManager.SaveUserAnswers(user, noteTxt.Text);
        }
    }
}
