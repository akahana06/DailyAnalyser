namespace DailyAnalyser
{
    partial class ModUserData
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
            userCBox = new ComboBox();
            questionCBox = new ComboBox();
            userInfoBox = new GroupBox();
            userIDLbl = new Label();
            IDLbl = new Label();
            userNameLbl = new Label();
            nameLbl = new Label();
            dataBox = new GroupBox();
            questionLbl = new Label();
            modifyBtn = new Button();
            closeBtn = new Button();
            titleLbl = new Label();
            userInfoBox.SuspendLayout();
            dataBox.SuspendLayout();
            SuspendLayout();
            // 
            // userCBox
            // 
            userCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            userCBox.FormattingEnabled = true;
            userCBox.Location = new Point(33, 62);
            userCBox.MaxDropDownItems = 20;
            userCBox.Name = "userCBox";
            userCBox.Size = new Size(139, 23);
            userCBox.TabIndex = 0;
            userCBox.SelectedIndexChanged += userCBox_SelectedIndexChanged;
            // 
            // questionCBox
            // 
            questionCBox.DropDownStyle = ComboBoxStyle.DropDownList;
            questionCBox.FormattingEnabled = true;
            questionCBox.Location = new Point(197, 62);
            questionCBox.Name = "questionCBox";
            questionCBox.Size = new Size(368, 23);
            questionCBox.TabIndex = 1;
            questionCBox.SelectedIndexChanged += questionCBox_SelectedIndexChanged;
            // 
            // userInfoBox
            // 
            userInfoBox.Controls.Add(userIDLbl);
            userInfoBox.Controls.Add(IDLbl);
            userInfoBox.Controls.Add(userNameLbl);
            userInfoBox.Controls.Add(nameLbl);
            userInfoBox.Location = new Point(587, 63);
            userInfoBox.Name = "userInfoBox";
            userInfoBox.Size = new Size(197, 305);
            userInfoBox.TabIndex = 2;
            userInfoBox.TabStop = false;
            userInfoBox.Enter += userInfoBox_Enter;
            // 
            // userIDLbl
            // 
            userIDLbl.AutoSize = true;
            userIDLbl.Location = new Point(12, 96);
            userIDLbl.Name = "userIDLbl";
            userIDLbl.Size = new Size(0, 15);
            userIDLbl.TabIndex = 3;
            // 
            // IDLbl
            // 
            IDLbl.AutoSize = true;
            IDLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IDLbl.Location = new Point(10, 81);
            IDLbl.Name = "IDLbl";
            IDLbl.Size = new Size(49, 15);
            IDLbl.TabIndex = 2;
            IDLbl.Text = "User ID";
            // 
            // userNameLbl
            // 
            userNameLbl.AutoSize = true;
            userNameLbl.Location = new Point(12, 45);
            userNameLbl.Name = "userNameLbl";
            userNameLbl.Size = new Size(0, 15);
            userNameLbl.TabIndex = 1;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nameLbl.Location = new Point(10, 30);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(40, 15);
            nameLbl.TabIndex = 0;
            nameLbl.Text = "Name";
            // 
            // dataBox
            // 
            dataBox.Controls.Add(questionLbl);
            dataBox.Location = new Point(34, 106);
            dataBox.Name = "dataBox";
            dataBox.Size = new Size(533, 261);
            dataBox.TabIndex = 3;
            dataBox.TabStop = false;
            dataBox.Text = "Data Box";
            // 
            // questionLbl
            // 
            questionLbl.AutoSize = true;
            questionLbl.Location = new Point(6, 243);
            questionLbl.Name = "questionLbl";
            questionLbl.Size = new Size(96, 15);
            questionLbl.TabIndex = 0;
            questionLbl.Text = "Select a question";
            // 
            // modifyBtn
            // 
            modifyBtn.Location = new Point(34, 392);
            modifyBtn.Name = "modifyBtn";
            modifyBtn.Size = new Size(105, 26);
            modifyBtn.TabIndex = 4;
            modifyBtn.Text = "Modify Graph";
            modifyBtn.UseVisualStyleBackColor = true;
            // 
            // closeBtn
            // 
            closeBtn.Location = new Point(679, 392);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(105, 26);
            closeBtn.TabIndex = 5;
            closeBtn.Text = "Close";
            closeBtn.UseVisualStyleBackColor = true;
            closeBtn.Click += closeBtn_Click;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLbl.Location = new Point(37, 22);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(98, 25);
            titleLbl.TabIndex = 6;
            titleLbl.Text = "User Data";
            // 
            // ModUserData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(titleLbl);
            Controls.Add(closeBtn);
            Controls.Add(modifyBtn);
            Controls.Add(dataBox);
            Controls.Add(userInfoBox);
            Controls.Add(questionCBox);
            Controls.Add(userCBox);
            Name = "ModUserData";
            Text = "UserDataMenu";
            Load += UserDataMenu_Load;
            userInfoBox.ResumeLayout(false);
            userInfoBox.PerformLayout();
            dataBox.ResumeLayout(false);
            dataBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox userCBox;
        private ComboBox questionCBox;
        private GroupBox userInfoBox;
        private Label nameLbl;
        private Label userNameLbl;
        private Label userIDLbl;
        private Label IDLbl;
        private GroupBox dataBox;
        private Label questionLbl;
        private Button modifyBtn;
        private Button closeBtn;
        private Label titleLbl;
    }
}