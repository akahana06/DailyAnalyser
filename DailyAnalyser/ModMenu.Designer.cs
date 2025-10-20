namespace DailyAnalyser
{
    partial class ModMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            viewUserBtn = new Button();
            updateQBtn = new Button();
            logoutBtn = new Button();
            editUserQuestions = new Button();
            addUserBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 0;
            label1.Text = "Mod Menu";
            // 
            // viewUserBtn
            // 
            viewUserBtn.Location = new Point(22, 37);
            viewUserBtn.Name = "viewUserBtn";
            viewUserBtn.Size = new Size(190, 37);
            viewUserBtn.TabIndex = 1;
            viewUserBtn.Text = "View / Modify Users Graph";
            viewUserBtn.UseVisualStyleBackColor = true;
            viewUserBtn.Click += viewUserBtn_Click;
            // 
            // updateQBtn
            // 
            updateQBtn.Location = new Point(22, 135);
            updateQBtn.Name = "updateQBtn";
            updateQBtn.Size = new Size(190, 37);
            updateQBtn.TabIndex = 2;
            updateQBtn.Text = "Approve Users Questions";
            updateQBtn.UseVisualStyleBackColor = true;
            updateQBtn.Click += updateQBtn_Click;
            // 
            // logoutBtn
            // 
            logoutBtn.Location = new Point(198, 257);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(112, 47);
            logoutBtn.TabIndex = 3;
            logoutBtn.Text = "Logout";
            logoutBtn.UseVisualStyleBackColor = true;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // editUserQuestions
            // 
            editUserQuestions.Location = new Point(22, 85);
            editUserQuestions.Name = "editUserQuestions";
            editUserQuestions.Size = new Size(190, 37);
            editUserQuestions.TabIndex = 4;
            editUserQuestions.Text = "Edit User Questions";
            editUserQuestions.UseVisualStyleBackColor = true;
            editUserQuestions.Click += editUserQuestions_Click;
            // 
            // addUserBtn
            // 
            addUserBtn.Location = new Point(22, 187);
            addUserBtn.Name = "addUserBtn";
            addUserBtn.Size = new Size(190, 37);
            addUserBtn.TabIndex = 5;
            addUserBtn.Text = "Approve Users Questions";
            addUserBtn.UseVisualStyleBackColor = true;
            addUserBtn.Click += addUserBtn_Click;
            // 
            // ModMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addUserBtn);
            Controls.Add(editUserQuestions);
            Controls.Add(logoutBtn);
            Controls.Add(updateQBtn);
            Controls.Add(viewUserBtn);
            Controls.Add(label1);
            Name = "ModMenu";
            Text = "ModMenu";
            Load += ModMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button viewUserBtn;
        private Button updateQBtn;
        private Button logoutBtn;
        private Button editUserQuestions;
        private Button addUserBtn;
    }
}