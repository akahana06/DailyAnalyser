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
            LowerBoundLbl = new Label();
            UpperBoundLbl = new Label();
            lowerBoundNUD = new NumericUpDown();
            upperBoundNUD = new NumericUpDown();
            questionTxt = new TextBox();
            qLbl = new Label();
            comboTxt = new TextBox();
            comboLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)lowerBoundNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)upperBoundNUD).BeginInit();
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
            userCBox.SelectedIndexChanged += userCBox_SelectedIndexChanged;
            // 
            // userQuestionsCBox
            // 
            userQuestionsCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            userQuestionsCBox.FormattingEnabled = true;
            userQuestionsCBox.Location = new Point(33, 110);
            userQuestionsCBox.Name = "userQuestionsCBox";
            userQuestionsCBox.Size = new Size(467, 23);
            userQuestionsCBox.TabIndex = 9;
            userQuestionsCBox.SelectedIndexChanged += userQuestionsCBox_SelectedIndexChanged;
            // 
            // trackBarRadioBtn
            // 
            trackBarRadioBtn.AutoSize = true;
            trackBarRadioBtn.Location = new Point(35, 186);
            trackBarRadioBtn.Name = "trackBarRadioBtn";
            trackBarRadioBtn.Size = new Size(72, 19);
            trackBarRadioBtn.TabIndex = 10;
            trackBarRadioBtn.TabStop = true;
            trackBarRadioBtn.Text = "Track Bar";
            trackBarRadioBtn.UseVisualStyleBackColor = true;
            trackBarRadioBtn.Click += trackBarRadioBtn_CheckedChanged;
            // 
            // numUpDownRadioBtn
            // 
            numUpDownRadioBtn.AutoSize = true;
            numUpDownRadioBtn.Location = new Point(158, 186);
            numUpDownRadioBtn.Name = "numUpDownRadioBtn";
            numUpDownRadioBtn.Size = new Size(125, 19);
            numUpDownRadioBtn.TabIndex = 11;
            numUpDownRadioBtn.TabStop = true;
            numUpDownRadioBtn.Text = "Numeric Up/Down";
            numUpDownRadioBtn.UseVisualStyleBackColor = true;
            numUpDownRadioBtn.Click += numUpDownRadioBtn_CheckedChanged;
            // 
            // comboBoxRadioBtn
            // 
            comboBoxRadioBtn.AutoSize = true;
            comboBoxRadioBtn.Location = new Point(325, 186);
            comboBoxRadioBtn.Name = "comboBoxRadioBtn";
            comboBoxRadioBtn.Size = new Size(88, 19);
            comboBoxRadioBtn.TabIndex = 12;
            comboBoxRadioBtn.TabStop = true;
            comboBoxRadioBtn.Text = "Combo Box";
            comboBoxRadioBtn.UseVisualStyleBackColor = true;
            comboBoxRadioBtn.Click += comboBoxRadioBtn_CheckedChanged;
            // 
            // approveBtn
            // 
            approveBtn.Location = new Point(35, 263);
            approveBtn.Name = "approveBtn";
            approveBtn.Size = new Size(75, 23);
            approveBtn.TabIndex = 13;
            approveBtn.Text = "Approve";
            approveBtn.UseVisualStyleBackColor = true;
            approveBtn.Click += approveBtn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(158, 263);
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
            // LowerBoundLbl
            // 
            LowerBoundLbl.AutoSize = true;
            LowerBoundLbl.Location = new Point(34, 227);
            LowerBoundLbl.Name = "LowerBoundLbl";
            LowerBoundLbl.Size = new Size(77, 15);
            LowerBoundLbl.TabIndex = 16;
            LowerBoundLbl.Text = "Lower Bound";
            // 
            // UpperBoundLbl
            // 
            UpperBoundLbl.AutoSize = true;
            UpperBoundLbl.Location = new Point(228, 227);
            UpperBoundLbl.Name = "UpperBoundLbl";
            UpperBoundLbl.Size = new Size(77, 15);
            UpperBoundLbl.TabIndex = 17;
            UpperBoundLbl.Text = "Upper Bound";
            // 
            // lowerBoundNUD
            // 
            lowerBoundNUD.Location = new Point(144, 225);
            lowerBoundNUD.Name = "lowerBoundNUD";
            lowerBoundNUD.Size = new Size(52, 23);
            lowerBoundNUD.TabIndex = 18;
            // 
            // upperBoundNUD
            // 
            upperBoundNUD.Location = new Point(325, 225);
            upperBoundNUD.Name = "upperBoundNUD";
            upperBoundNUD.Size = new Size(52, 23);
            upperBoundNUD.TabIndex = 19;
            // 
            // questionTxt
            // 
            questionTxt.Location = new Point(33, 157);
            questionTxt.Name = "questionTxt";
            questionTxt.Size = new Size(467, 23);
            questionTxt.TabIndex = 20;
            // 
            // qLbl
            // 
            qLbl.AutoSize = true;
            qLbl.Location = new Point(33, 139);
            qLbl.Name = "qLbl";
            qLbl.Size = new Size(80, 15);
            qLbl.TabIndex = 21;
            qLbl.Text = "Question Title";
            // 
            // comboTxt
            // 
            comboTxt.Location = new Point(33, 224);
            comboTxt.Name = "comboTxt";
            comboTxt.Size = new Size(467, 23);
            comboTxt.TabIndex = 22;
            // 
            // comboLbl
            // 
            comboLbl.AutoSize = true;
            comboLbl.Location = new Point(33, 208);
            comboLbl.Name = "comboLbl";
            comboLbl.Size = new Size(245, 15);
            comboLbl.TabIndex = 23;
            comboLbl.Text = "ComboBox Categories (Split categories by ',')";
            comboLbl.Click += label1_Click;
            // 
            // ModUserQuestions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboLbl);
            Controls.Add(comboTxt);
            Controls.Add(qLbl);
            Controls.Add(questionTxt);
            Controls.Add(upperBoundNUD);
            Controls.Add(lowerBoundNUD);
            Controls.Add(UpperBoundLbl);
            Controls.Add(LowerBoundLbl);
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
            ((System.ComponentModel.ISupportInitialize)lowerBoundNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)upperBoundNUD).EndInit();
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
        private Label LowerBoundLbl;
        private Label UpperBoundLbl;
        private NumericUpDown lowerBoundNUD;
        private NumericUpDown upperBoundNUD;
        private TextBox questionTxt;
        private Label qLbl;
        private TextBox comboTxt;
        private Label comboLbl;
    }
}