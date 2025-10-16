namespace DailyAnalyser
{
    partial class EditUserQuestions
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
            userQuestionsTitleLbl = new Label();
            userCBox = new ComboBox();
            questionsLBox = new ListBox();
            removeQuestionBtn = new Button();
            closeBtn = new Button();
            SuspendLayout();
            // 
            // userQuestionsTitleLbl
            // 
            userQuestionsTitleLbl.AutoSize = true;
            userQuestionsTitleLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userQuestionsTitleLbl.Location = new Point(28, 22);
            userQuestionsTitleLbl.Name = "userQuestionsTitleLbl";
            userQuestionsTitleLbl.Size = new Size(145, 25);
            userQuestionsTitleLbl.TabIndex = 8;
            userQuestionsTitleLbl.Text = "User Questions";
            // 
            // userCBox
            // 
            userCBox.FormattingEnabled = true;
            userCBox.Location = new Point(33, 62);
            userCBox.Name = "userCBox";
            userCBox.Size = new Size(139, 23);
            userCBox.TabIndex = 9;
            userCBox.SelectedIndexChanged += EditUserQuestions_SelectedIndexChanged;
            // 
            // questionsLBox
            // 
            questionsLBox.FormattingEnabled = true;
            questionsLBox.ItemHeight = 15;
            questionsLBox.Location = new Point(33, 107);
            questionsLBox.Name = "questionsLBox";
            questionsLBox.Size = new Size(467, 124);
            questionsLBox.TabIndex = 10;
            // 
            // removeQuestionBtn
            // 
            removeQuestionBtn.Location = new Point(530, 155);
            removeQuestionBtn.Name = "removeQuestionBtn";
            removeQuestionBtn.Size = new Size(75, 23);
            removeQuestionBtn.TabIndex = 11;
            removeQuestionBtn.Text = "Remove";
            removeQuestionBtn.UseVisualStyleBackColor = true;
            removeQuestionBtn.Click += removeQuestionBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(33, 281);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(75, 23);
            closeBtn.TabIndex = 12;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // EditUserQuestions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(closeBtn);
            Controls.Add(removeQuestionBtn);
            Controls.Add(questionsLBox);
            Controls.Add(userCBox);
            Controls.Add(userQuestionsTitleLbl);
            Name = "EditUserQuestions";
            Text = "EditUserQuestions";
            Load += EditUserQuestions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userQuestionsTitleLbl;
        private ComboBox userCBox;
        private ListBox questionsLBox;
        private Button removeQuestionBtn;
        private Button closeBtn;
    }
}