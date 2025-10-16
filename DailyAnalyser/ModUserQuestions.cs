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
                userCQBox.Items.Add(user);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
