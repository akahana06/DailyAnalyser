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
            userCQBox = new ComboBox();
            comboBox1 = new ComboBox();
            trackBarRadioBtn = new RadioButton();
            numUpDownRadioBtn = new RadioButton();
            comboBoxRadioBtn = new RadioButton();
            approveBtn = new Button();
            cancelBtn = new Button();
            SuspendLayout();
            // 
            // userQuestionsTitleLbl
            // 
            userQuestionsTitleLbl.AutoSize = true;
            userQuestionsTitleLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userQuestionsTitleLbl.Location = new Point(37, 22);
            userQuestionsTitleLbl.Name = "userQuestionsTitleLbl";
            userQuestionsTitleLbl.Size = new Size(145, 25);
            userQuestionsTitleLbl.TabIndex = 7;
            userQuestionsTitleLbl.Text = "User Questions";
            // 
            // userCQBox
            // 
            userCQBox.DropDownStyle = ComboBoxStyle.DropDownList;
            userCQBox.FormattingEnabled = true;
            userCQBox.Location = new Point(33, 62);
            userCQBox.MaxDropDownItems = 20;
            userCQBox.Name = "userCQBox";
            userCQBox.Size = new Size(139, 23);
            userCQBox.TabIndex = 8;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(33, 110);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(467, 23);
            comboBox1.TabIndex = 9;
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
            approveBtn.Click += button1_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Location = new Point(157, 219);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(75, 23);
            cancelBtn.TabIndex = 14;
            cancelBtn.Text = "Cancel";
            cancelBtn.UseVisualStyleBackColor = true;
            // 
            // ModUserQuestions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cancelBtn);
            Controls.Add(approveBtn);
            Controls.Add(comboBoxRadioBtn);
            Controls.Add(numUpDownRadioBtn);
            Controls.Add(trackBarRadioBtn);
            Controls.Add(comboBox1);
            Controls.Add(userCQBox);
            Controls.Add(userQuestionsTitleLbl);
            Name = "ModUserQuestions";
            Text = "ModUserQuestions";
            Load += ModUserQuestions_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userQuestionsTitleLbl;
        private ComboBox userCQBox;
        private ComboBox comboBox1;
        private RadioButton trackBarRadioBtn;
        private RadioButton numUpDownRadioBtn;
        private RadioButton comboBoxRadioBtn;
        private Button approveBtn;
        private Button cancelBtn;
    }
}