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
    public partial class UserMenu : Form
    {
        private User user;

        public UserMenu(User u)
        {
            InitializeComponent();
            user = u;
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {

        }

        private void completeDiaryBtn_Click(object sender, EventArgs e)
        {
            UserDailyForm dailyform = new UserDailyForm(user);
            dailyform.ShowDialog();
        }

        private void requestCategoryBtn_Click(object sender, EventArgs e)
        {
            RequestCategoryForm reqCatform = new RequestCategoryForm(user);
            reqCatform.ShowDialog();
        }
    }
}
