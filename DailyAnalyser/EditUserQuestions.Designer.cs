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
            newQuestionLbl = new Label();
            newQuestionTBox = new TextBox();
            comboBoxRadioBtn = new RadioButton();
            numUpDownRadioBtn = new RadioButton();
            trackBarRadioBtn = new RadioButton();
            newQuestionBtn = new Button();
            upperBoundNUD = new NumericUpDown();
            lowerBoundNUD = new NumericUpDown();
            UpperBoundLbl = new Label();
            LowerBoundLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)upperBoundNUD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lowerBoundNUD).BeginInit();
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
            questionsLBox.Size = new Size(365, 124);
            questionsLBox.TabIndex = 10;
            // 
            // removeQuestionBtn
            // 
            removeQuestionBtn.Location = new Point(33, 237);
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
            // newQuestionLbl
            // 
            newQuestionLbl.AutoSize = true;
            newQuestionLbl.Location = new Point(440, 62);
            newQuestionLbl.Name = "newQuestionLbl";
            newQuestionLbl.Size = new Size(117, 15);
            newQuestionLbl.TabIndex = 13;
            newQuestionLbl.Text = "Create/Edit Question";
            // 
            // newQuestionTBox
            // 
            newQuestionTBox.Location = new Point(440, 107);
            newQuestionTBox.Name = "newQuestionTBox";
            newQuestionTBox.Size = new Size(348, 23);
            newQuestionTBox.TabIndex = 14;
            // 
            // comboBoxRadioBtn
            // 
            comboBoxRadioBtn.AutoSize = true;
            comboBoxRadioBtn.Location = new Point(665, 157);
            comboBoxRadioBtn.Name = "comboBoxRadioBtn";
            comboBoxRadioBtn.Size = new Size(87, 19);
            comboBoxRadioBtn.TabIndex = 17;
            comboBoxRadioBtn.TabStop = true;
            comboBoxRadioBtn.Text = "Combo Box";
            comboBoxRadioBtn.UseVisualStyleBackColor = true;
            comboBoxRadioBtn.CheckedChanged += comboBoxRadioBtn_CheckedChanged;
            comboBoxRadioBtn.Click += comboBoxRadioBtn_CheckedChanged;
            // 
            // numUpDownRadioBtn
            // 
            numUpDownRadioBtn.AutoSize = true;
            numUpDownRadioBtn.Location = new Point(528, 157);
            numUpDownRadioBtn.Name = "numUpDownRadioBtn";
            numUpDownRadioBtn.Size = new Size(125, 19);
            numUpDownRadioBtn.TabIndex = 16;
            numUpDownRadioBtn.TabStop = true;
            numUpDownRadioBtn.Text = "Numeric Up/Down";
            numUpDownRadioBtn.UseVisualStyleBackColor = true;
            numUpDownRadioBtn.Click += numUpDownRadioBtn_CheckedChanged;
            // 
            // trackBarRadioBtn
            // 
            trackBarRadioBtn.AutoSize = true;
            trackBarRadioBtn.Location = new Point(440, 157);
            trackBarRadioBtn.Name = "trackBarRadioBtn";
            trackBarRadioBtn.Size = new Size(73, 19);
            trackBarRadioBtn.TabIndex = 15;
            trackBarRadioBtn.TabStop = true;
            trackBarRadioBtn.Text = "Track Bar";
            trackBarRadioBtn.UseVisualStyleBackColor = true;
            trackBarRadioBtn.Click += trackBarRadioBtn_CheckedChanged;
            // 
            // newQuestionBtn
            // 
            newQuestionBtn.Location = new Point(436, 228);
            newQuestionBtn.Name = "newQuestionBtn";
            newQuestionBtn.Size = new Size(75, 23);
            newQuestionBtn.TabIndex = 18;
            newQuestionBtn.Text = "Update";
            newQuestionBtn.UseVisualStyleBackColor = true;
            newQuestionBtn.Click += newQuestionBtn_Click;
            // 
            // upperBoundNUD
            // 
            upperBoundNUD.Location = new Point(727, 194);
            upperBoundNUD.Name = "upperBoundNUD";
            upperBoundNUD.Size = new Size(52, 23);
            upperBoundNUD.TabIndex = 23;
            // 
            // lowerBoundNUD
            // 
            lowerBoundNUD.Location = new Point(546, 194);
            lowerBoundNUD.Name = "lowerBoundNUD";
            lowerBoundNUD.Size = new Size(52, 23);
            lowerBoundNUD.TabIndex = 22;
            // 
            // UpperBoundLbl
            // 
            UpperBoundLbl.AutoSize = true;
            UpperBoundLbl.Location = new Point(630, 196);
            UpperBoundLbl.Name = "UpperBoundLbl";
            UpperBoundLbl.Size = new Size(77, 15);
            UpperBoundLbl.TabIndex = 21;
            UpperBoundLbl.Text = "Upper Bound";
            // 
            // LowerBoundLbl
            // 
            LowerBoundLbl.AutoSize = true;
            LowerBoundLbl.Location = new Point(436, 196);
            LowerBoundLbl.Name = "LowerBoundLbl";
            LowerBoundLbl.Size = new Size(77, 15);
            LowerBoundLbl.TabIndex = 20;
            LowerBoundLbl.Text = "Lower Bound";
            // 
            // EditUserQuestions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(upperBoundNUD);
            Controls.Add(lowerBoundNUD);
            Controls.Add(UpperBoundLbl);
            Controls.Add(LowerBoundLbl);
            Controls.Add(newQuestionBtn);
            Controls.Add(comboBoxRadioBtn);
            Controls.Add(numUpDownRadioBtn);
            Controls.Add(trackBarRadioBtn);
            Controls.Add(newQuestionTBox);
            Controls.Add(newQuestionLbl);
            Controls.Add(closeBtn);
            Controls.Add(removeQuestionBtn);
            Controls.Add(questionsLBox);
            Controls.Add(userCBox);
            Controls.Add(userQuestionsTitleLbl);
            Name = "EditUserQuestions";
            Text = "EditUserQuestions";
            Load += EditUserQuestions_Load;
            ((System.ComponentModel.ISupportInitialize)upperBoundNUD).EndInit();
            ((System.ComponentModel.ISupportInitialize)lowerBoundNUD).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userQuestionsTitleLbl;
        private ComboBox userCBox;
        private ListBox questionsLBox;
        private Button removeQuestionBtn;
        private Button closeBtn;
        private Label newQuestionLbl;
        private TextBox newQuestionTBox;
        private RadioButton comboBoxRadioBtn;
        private RadioButton numUpDownRadioBtn;
        private RadioButton trackBarRadioBtn;
        private Button newQuestionBtn;
        private NumericUpDown upperBoundNUD;
        private NumericUpDown lowerBoundNUD;
        private Label UpperBoundLbl;
        private Label LowerBoundLbl;
    }
}