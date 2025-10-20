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
    public partial class ModMenu : Form
    {
        private Mod mod;
        public ModMenu(Mod m)
        {
            InitializeComponent();
            mod = m;

            this.Text = "DailyAnalyser — Moderator Menu";
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(900, 500);
            this.Font = new Font("Segoe UI", 10f);
            this.BackColor = SystemColors.Window;
            this.Padding = new Padding(16);

            var header = this.Controls.Find("label1", true).FirstOrDefault() as Label
                 ?? this.Controls.Find("modMenuLabel", true).FirstOrDefault() as Label;

            if (header == null)
            {
                header = new Label { Name = "modMenuLabel" };
                this.Controls.Add(header);
            }

            string today = DateTime.Now.ToString("dddd, d MMMM yyyy");
            string who = (m?.name is { Length: > 0 }) ? $"Moderator: {m.name}" : "Moderator";
            header.Text = $"Mod Menu — {who} — {today}";
            header.AutoSize = true;
            header.Font = new Font(this.Font.FontFamily, 20f, FontStyle.Bold);
            header.ForeColor = Color.FromArgb(40, 40, 40);
            header.Margin = new Padding(0, 0, 0, 6);
            header.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            header.Left = this.Padding.Left;
            header.Top = this.Padding.Top;

            var sub = new Label
            {
                Text = "Review user data, edit questions, or approve pending requests.",
                AutoSize = true,
                ForeColor = SystemColors.GrayText,
                Margin = new Padding(0, 0, 0, 12),
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };
            this.Controls.Add(sub);
            sub.Left = this.Padding.Left;
            sub.Top = header.Bottom + 2;

            var actions = new FlowLayoutPanel
            {
                Name = "actionsPanel",
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
                b.Size = new Size(260, 42);
                b.Margin = new Padding(0, 0, 12, 12);
                b.FlatStyle = FlatStyle.System; // or Standard
            }

            var viewBtn = this.Controls.Find("viewUserBtn", true).FirstOrDefault() as Button;
            var editBtn = this.Controls.Find("editUserQuestions", true).FirstOrDefault() as Button;
            var approveBtn = this.Controls.Find("updateQBtn", true).FirstOrDefault() as Button;
            var logoutBtn = this.Controls.Find("logoutBtn", true).FirstOrDefault() as Button;
            var addUserBtn = this.Controls.Find("addUserBtn", true).FirstOrDefault() as Button;

            StyleBtn(viewBtn, "View Users’ Graph");
            StyleBtn(editBtn, "Edit User Questions");
            StyleBtn(approveBtn, "Approve User Questions");
            StyleBtn(logoutBtn, "Log out");
            StyleBtn(addUserBtn, "Add User");

            if (viewBtn != null) actions.Controls.Add(viewBtn);
            if (editBtn != null) actions.Controls.Add(editBtn);
            if (approveBtn != null) actions.Controls.Add(approveBtn);
            if (addUserBtn != null) actions.Controls.Add(addUserBtn);

            actions.Left = this.Padding.Left;
            actions.Top = sub.Bottom + 8;
            actions.Width = this.ClientSize.Width - this.Padding.Horizontal;
            actions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;

            this.Resize += (s, e) =>
            {
                actions.Width = this.ClientSize.Width - this.Padding.Horizontal;

                // keep logout pinned bottom-left
                if (logoutBtn != null)
                    logoutBtn.Top = this.ClientSize.Height - logoutBtn.Height - this.Padding.Bottom - 10;
            };

            if (logoutBtn != null)
            {
                logoutBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
                logoutBtn.Left = this.Padding.Left;
                logoutBtn.Top = this.ClientSize.Height - logoutBtn.Height - this.Padding.Bottom - 30;
            }

            this.AcceptButton = viewBtn;
            this.CancelButton = logoutBtn;

            var tips = new ToolTip();
            if (viewBtn != null) tips.SetToolTip(viewBtn, "Open a user and view or modify their graphs.");
            if (editBtn != null) tips.SetToolTip(editBtn, "Create, edit, or remove a user’s questions.");
            if (approveBtn != null) tips.SetToolTip(approveBtn, "Approve or deny users’ pending question requests.");
            if (logoutBtn != null) tips.SetToolTip(logoutBtn, "Log out and return to the login screen.");

            var status = new StatusStrip { SizingGrip = false, Dock = DockStyle.Bottom };
            var statusText = new ToolStripStatusLabel($"{who}");
            status.Items.Add(statusText);
            this.Controls.Add(status);
        }

        private void ModMenu_Load(object sender, EventArgs e)
        {

        }

        private void viewUserBtn_Click(object sender, EventArgs e)
        {
            ModUserData userDataMenu = new ModUserData(mod);
            userDataMenu.ShowDialog();
        }

        private void updateQBtn_Click(object sender, EventArgs e)
        {
            ModUserQuestions userQuestionsMenu = new ModUserQuestions(mod);
            userQuestionsMenu.ShowDialog();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            // Close the current form
            this.Close();

        }

        private void editUserQuestions_Click(object sender, EventArgs e)
        {
            EditUserQuestions ModEditUserData = new EditUserQuestions(mod);
            ModEditUserData.ShowDialog();
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser(mod);
            addUser.ShowDialog();
        }
    }
}
