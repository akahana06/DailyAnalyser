namespace DailyAnalyser
{
    partial class ModUserQuestions
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
            userQuestionsCBox = new ComboBox();
            trackBarRadioBtn = new RadioButton();
            numUpDownRadioBtn = new RadioButton();
            comboBoxRadioBtn = new RadioButton();
            approveBtn = new Button();
            cancelBtn = new Button();
            outstandingQuestionsLbl = new Label();
            SuspendLayout();
            // 
            // userQuestionsTitleLbl
            // 
            userQuestionsTitleLbl.AutoSize = true;
            userQuestionsTitleLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userQuestionsTitleLbl.Location = new Point(28, 22);
            userQuestionsTitleLbl.Name = "userQuestionsTitleLbl";
            userQuestionsTitleLbl.Size = new Size(224, 25);
            userQuestionsTitleLbl.TabIndex = 7;
            userQuestionsTitleLbl.Text = "Pending User Questions";
            // 
            // userCBox
            // 
            userCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            userCBox.FormattingEnabled = true;
            userCBox.Location = new Point(33, 62);
            userCBox.MaxDropDownItems = 20;
            userCBox.Name = "userCBox";
            userCBox.Size = new Size(139, 23);
            userCBox.TabIndex = 8;
            userCBox.SelectedIndexChanged += ModUserQuestions_SelectedIndexChanged;
            // 
            // userQuestionsCBox
            // 
            userQuestionsCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            userQuestionsCBox.FormattingEnabled = true;
            userQuestionsCBox.Location = new Point(33, 110);
            userQuestionsCBox.Name = "userQuestionsCBox";
            userQuestionsCBox.Size = new Size(467, 23);
            userQuestionsCBox.TabIndex = 9;
            // 
            // trackBarRadioBtn
            // 
            trackBarRadioBtn.AutoSize = true;
            trackBarRadioBtn.Location = new Point(34, 157);
            trackBarRadioBtn.Name = "trackBarRadioBtn";
            trackBarRadioBtn.Size = new Size(73, 19);
            trackBarRadioBtn.TabIndex = 10;
            trackBarRadioBtn.TabStop = true;
            trackBarRadioBtn.Text = "Track Bar";
            trackBarRadioBtn.UseVisualStyleBackColor = true;
            // 
            // numUpDownRadioBtn
            // 
            numUpDownRadioBtn.AutoSize = true;
            numUpDownRadioBtn.Location = new Point(157, 157);
            numUpDownRadioBtn.Name = "numUpDownRadioBtn";
            numUpDownRadioBtn.Size = new Size(125, 19);
            numUpDownRadioBtn.TabIndex = 11;
            numUpDownRadioBtn.TabStop = true;
            numUpDownRadioBtn.Text = "Numeric Up/Down";
            numUpDownRadioBtn.UseVisualStyleBackColor = true;
            // 
            // comboBoxRadioBtn
            // 
            comboBoxRadioBtn.AutoSize = true;
            comboBoxRadioBtn.Location = new Point(324, 157);
            comboBoxRadioBtn.Name = "comboBoxRadioBtn";
            comboBoxRadioBtn.Size = new Size(87, 19);
            comboBoxRadioBtn.TabIndex = 12;
            comboBoxRadioBtn.TabStop = true;
            comboBoxRadioBtn.Text = "Combo Box";
            comboBoxRadioBtn.UseVisualStyleBackColor = true;
            // 
            // approveBtn
            // 
            approveBtn.Location = new Point(34, 219);
            approveBtn.Name = "approveBtn";
            approveBtn.Size = new Size(75, 23);
            approveBtn.TabIndex = 13;
            approveBtn.Text = "Approve";
            approveBtn.UseVisualStyleBackColor = true;
            approveBtn.Click += approveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(157, 219);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 14;
            cancelBtn.Text = "Close";
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // outstandingQuestionsLbl
            // 
            outstandingQuestionsLbl.AutoSize = true;
            outstandingQuestionsLbl.Location = new Point(227, 67);
            outstandingQuestionsLbl.Name = "outstandingQuestionsLbl";
            outstandingQuestionsLbl.Size = new Size(0, 15);
            outstandingQuestionsLbl.TabIndex = 15;
            // 
            // ModUserQuestions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(outstandingQuestionsLbl);
            Controls.Add(cancelBtn);
            Controls.Add(approveBtn);
            Controls.Add(comboBoxRadioBtn);
            Controls.Add(numUpDownRadioBtn);
            Controls.Add(trackBarRadioBtn);
            Controls.Add(userQuestionsCBox);
            Controls.Add(userCBox);
            Controls.Add(userQuestionsTitleLbl);
            Name = "ModUserQuestions";
            Text = "ModUserQuestions";
            Load += ModUserQuestions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userQuestionsTitleLbl;
        private ComboBox userCBox;
        private ComboBox userQuestionsCBox;
        private RadioButton trackBarRadioBtn;
        private RadioButton numUpDownRadioBtn;
        private RadioButton comboBoxRadioBtn;
        private Button approveBtn;
        private Button cancelBtn;
        private Label outstandingQuestionsLbl;
    }
}