namespace DailyAnalyser
{
    partial class UserMenu
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
            completeDiaryBtn = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 32);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "User Menu";
            // 
            // completeDiaryBtn
            // 
            completeDiaryBtn.Location = new Point(29, 83);
            completeDiaryBtn.Name = "completeDiaryBtn";
            completeDiaryBtn.Size = new Size(206, 41);
            completeDiaryBtn.TabIndex = 1;
            completeDiaryBtn.Text = "Complete Todays Diary";
            completeDiaryBtn.UseVisualStyleBackColor = true;
            completeDiaryBtn.Click += completeDiaryBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(29, 148);
            button1.Name = "button1";
            button1.Size = new Size(206, 41);
            button1.TabIndex = 2;
            button1.Text = "Request Category";
            button1.UseVisualStyleBackColor = true;
            button1.Click += requestCategoryBtn_Click;
            // 
            // UserMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(completeDiaryBtn);
            Controls.Add(label1);
            Name = "UserMenu";
            Text = "UserMenu";
            Load += UserMenu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button completeDiaryBtn;
        private Button button1;
    }
}