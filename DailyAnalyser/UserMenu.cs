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

            this.Text = "DailyAnalyser — User Menu";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(820, 500);
            this.Font = new Font("Segoe UI", 10f);
            this.BackColor = SystemColors.Window;
            this.Padding = new Padding(16);

            //Header
            if (this.Controls.Find("label1", true).FirstOrDefault() is Label header)
            {
                string today = DateTime.Now.ToString("dddd, d MMMM yyyy"); // e.g., "Sunday, 20 October 2025"
                header.Text = (user?.name is { Length: > 0 })
                    ? $"Welcome back, {user.name}! — {today}"
                    : $"Welcome back! — {today}";
                header.AutoSize = true;
                header.Font = new Font(this.Font.FontFamily, 20f, FontStyle.Bold);
                header.Margin = new Padding(0, 0, 0, 6);
                header.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                header.Left = this.Padding.Left;
                header.Top = this.Padding.Top;
            }

            //Subtitle
            var sub = new Label
            {
                Text = "What would you like to do today?",
                AutoSize = true,
                ForeColor = SystemColors.GrayText,
                Margin = new Padding(0, 0, 0, 12),
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };
            this.Controls.Add(sub);
            sub.Left = this.Padding.Left;
            sub.Top = (this.Controls["label1"] as Label)?.Bottom + 2 ?? (this.Padding.Top + 28);

            var actions = new FlowLayoutPanel
            {
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = true,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Padding = new Padding(0),
                Margin = new Padding(0),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            this.Controls.Add(actions);

            void StyleBtn(Button b, string text)
            {
                if (b == null) return;
                b.Text = text;
                b.AutoSize = false;
                b.Size = new Size(240, 42);
                b.Margin = new Padding(0, 0, 12, 12);
                b.FlatStyle = FlatStyle.System;
            }

            var diaryBtn = this.Controls.Find("completeDiaryBtn", true).FirstOrDefault() as Button;
            var requestBtn = this.Controls.Find("button1", true).FirstOrDefault() as Button;
            var logoutBtn = this.Controls.Find("logoutBtn", true).FirstOrDefault() as Button;

            StyleBtn(diaryBtn, "Complete Today’s Diary");
            StyleBtn(requestBtn, "Request a New Question");
            StyleBtn(logoutBtn, "Log out");

            if (diaryBtn != null) actions.Controls.Add(diaryBtn);
            if (requestBtn != null) actions.Controls.Add(requestBtn);

            // Put logout on a new “row” visually by adding a padding label if desired:
            actions.Controls.Add(new Label { AutoSize = false, Width = 1, Height = 1, Margin = new Padding(0, 0, 0, 0) });
            if (logoutBtn != null) actions.Controls.Add(logoutBtn);

            // Position the actions panel under the subtitle and stretch it
            actions.Left = this.Padding.Left;
            actions.Top = sub.Bottom + 8;
            actions.Width = this.ClientSize.Width - this.Padding.Horizontal;
            actions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            // Keep it responsive on resize
            this.Resize += (s, e) =>
            {
                actions.Width = this.ClientSize.Width - this.Padding.Horizontal;
            };

            //Keyboard control + tooltips
            this.AcceptButton = diaryBtn;   // Enter = complete diary
            this.CancelButton = logoutBtn;  // Esc   = logout/close
            var tips = new ToolTip();
            if (diaryBtn != null) tips.SetToolTip(diaryBtn, "Fill in today’s diary.");
            if (requestBtn != null) tips.SetToolTip(requestBtn, "Ask a moderator to add a new question.");
            if (logoutBtn != null) tips.SetToolTip(logoutBtn, "Return to the login screen.");

            //Footer
            var status = new StatusStrip { SizingGrip = false, Dock = DockStyle.Bottom };
            status.Items.Add(new ToolStripStatusLabel($"Signed in as {user?.name ?? "User"} (ID {user?.id})"));
            this.Controls.Add(status);

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

        private void button2_Click(object sender, EventArgs e)
        {
            // Close the current window
            this.Close();

        }
    }
}
