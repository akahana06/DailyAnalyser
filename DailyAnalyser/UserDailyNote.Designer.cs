namespace DailyAnalyser
{
    partial class UserDailyNote
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
            noteTxt = new TextBox();
            submitBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 21);
            label1.Name = "label1";
            label1.Size = new Size(148, 15);
            label1.TabIndex = 0;
            label1.Text = "Additional Notes for Today";
            // 
            // noteTxt
            // 
            noteTxt.Location = new Point(16, 39);
            noteTxt.MaximumSize = new Size(400, 50);
            noteTxt.MinimumSize = new Size(0, 50);
            noteTxt.Multiline = true;
            noteTxt.Name = "noteTxt";
            noteTxt.Size = new Size(350, 50);
            noteTxt.TabIndex = 1;
            // 
            // submitBtn
            // 
            submitBtn.Location = new Point(267, 95);
            submitBtn.Name = "submitBtn";
            submitBtn.Size = new Size(99, 21);
            submitBtn.TabIndex = 2;
            submitBtn.Text = "Submit";
            submitBtn.UseVisualStyleBackColor = true;
            submitBtn.Click += submitBtn_Click;
            // 
            // UserDailyNote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 128);
            Controls.Add(submitBtn);
            Controls.Add(noteTxt);
            Controls.Add(label1);
            Name = "UserDailyNote";
            Text = "UserDailyNote";
            Load += UserDailyNote_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox noteTxt;
        private Button submitBtn;
    }
}