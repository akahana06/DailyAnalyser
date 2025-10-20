namespace DailyAnalyser
{
    partial class RequestCategoryForm
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
            requestCatLabel = new Label();
            addQuestionBtn = new Button();
            questionTxtBox = new TextBox();
            questionsLstBox = new ListBox();
            removeQuestionBtn = new Button();
            closeBtn = new Button();
            saveBtn = new Button();
            SuspendLayout();
            // 
            // requestCatLabel
            // 
            requestCatLabel.AutoSize = true;
            requestCatLabel.Location = new Point(29, 32);
            requestCatLabel.Name = "requestCatLabel";
            requestCatLabel.Size = new Size(134, 15);
            requestCatLabel.TabIndex = 1;
            requestCatLabel.Text = "Request Category Menu";
            // 
            // addQuestionBtn
            // 
            addQuestionBtn.Location = new Point(291, 77);
            addQuestionBtn.Name = "addQuestionBtn";
            addQuestionBtn.Size = new Size(72, 32);
            addQuestionBtn.TabIndex = 2;
            addQuestionBtn.Text = "Add";
            addQuestionBtn.UseVisualStyleBackColor = true;
            addQuestionBtn.Click += addQuestionBtn_Click;
            // 
            // questionTxtBox
            // 
            questionTxtBox.Location = new Point(29, 81);
            questionTxtBox.Name = "questionTxtBox";
            questionTxtBox.Size = new Size(245, 23);
            questionTxtBox.TabIndex = 4;
            // 
            // questionsLstBox
            // 
            questionsLstBox.FormattingEnabled = true;
            questionsLstBox.ItemHeight = 15;
            questionsLstBox.Location = new Point(29, 130);
            questionsLstBox.Name = "questionsLstBox";
            questionsLstBox.Size = new Size(334, 94);
            questionsLstBox.TabIndex = 5;
            // 
            // removeQuestionBtn
            // 
            removeQuestionBtn.Location = new Point(381, 162);
            removeQuestionBtn.Name = "removeQuestionBtn";
            removeQuestionBtn.Size = new Size(99, 32);
            removeQuestionBtn.TabIndex = 6;
            removeQuestionBtn.Text = "Remove";
            removeQuestionBtn.UseVisualStyleBackColor = true;
            removeQuestionBtn.Click += removeQuestionBtn_Click;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(291, 351);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(75, 23);
            closeBtn.TabIndex = 7;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(29, 351);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 8;
            saveBtn.Text = "Save";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // RequestCategoryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(saveBtn);
            Controls.Add(closeBtn);
            Controls.Add(removeQuestionBtn);
            Controls.Add(questionsLstBox);
            Controls.Add(questionTxtBox);
            Controls.Add(addQuestionBtn);
            Controls.Add(requestCatLabel);
            Name = "RequestCategoryForm";
            Text = "RequestCategoryForm";
            Load += RequestCategoryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label requestCatLabel;
        private Button addQuestionBtn;
        private TextBox questionTxtBox;
        private ListBox questionsLstBox;
        private Button removeQuestionBtn;
        private Button closeBtn;
        private Button saveBtn;
    }
}