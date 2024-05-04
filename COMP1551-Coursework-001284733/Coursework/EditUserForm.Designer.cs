using System.ComponentModel;

namespace Coursework
{
    partial class EditUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SaveEditBtn = new System.Windows.Forms.Button();
            this.addRoleLabel = new System.Windows.Forms.Label();
            this.addEmailLabel = new System.Windows.Forms.Label();
            this.addTelephoneLabel = new System.Windows.Forms.Label();
            this.addNameLabel = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.telephoneBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.roleLabel = new System.Windows.Forms.Label();
            this.AdminInfoLabel1 = new System.Windows.Forms.Label();
            this.AdminInfoLabel2 = new System.Windows.Forms.Label();
            this.AdminInfoLabel3 = new System.Windows.Forms.Label();
            this.AdminSalaryText = new System.Windows.Forms.TextBox();
            this.AdminRadioPanel = new System.Windows.Forms.Panel();
            this.radioFullTime = new System.Windows.Forms.RadioButton();
            this.radioPartTime = new System.Windows.Forms.RadioButton();
            this.startTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AdminInfoLabel4 = new System.Windows.Forms.Label();
            this.AdminDetailBox = new System.Windows.Forms.GroupBox();
            this.TeacherInfoLabel1 = new System.Windows.Forms.Label();
            this.TeacherInfoLabel2 = new System.Windows.Forms.Label();
            this.TeacherSubject1Text = new System.Windows.Forms.ComboBox();
            this.TeacherInfoLabel3 = new System.Windows.Forms.Label();
            this.TeacherSubject2Text = new System.Windows.Forms.ComboBox();
            this.TeacherSalaryText = new System.Windows.Forms.TextBox();
            this.TeacherDetailBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentInfo2 = new System.Windows.Forms.ComboBox();
            this.StudentInfo3 = new System.Windows.Forms.ComboBox();
            this.StudentInfo4 = new System.Windows.Forms.ComboBox();
            this.StudentInfo1 = new System.Windows.Forms.ComboBox();
            this.StudentDetailBox = new System.Windows.Forms.GroupBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.AdminRadioPanel.SuspendLayout();
            this.AdminDetailBox.SuspendLayout();
            this.TeacherDetailBox.SuspendLayout();
            this.StudentDetailBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(641, 539);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(103, 54);
            this.CancelBtn.TabIndex = 28;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // SaveEditBtn
            // 
            this.SaveEditBtn.Location = new System.Drawing.Point(38, 539);
            this.SaveEditBtn.Name = "SaveEditBtn";
            this.SaveEditBtn.Size = new System.Drawing.Size(103, 54);
            this.SaveEditBtn.TabIndex = 26;
            this.SaveEditBtn.Text = "Save changes";
            this.SaveEditBtn.UseVisualStyleBackColor = true;
            this.SaveEditBtn.Click += new System.EventHandler(this.SaveEditBtn_Click);
            // 
            // addRoleLabel
            // 
            this.addRoleLabel.Location = new System.Drawing.Point(38, 168);
            this.addRoleLabel.Name = "addRoleLabel";
            this.addRoleLabel.Size = new System.Drawing.Size(155, 31);
            this.addRoleLabel.TabIndex = 25;
            this.addRoleLabel.Text = "Role";
            // 
            // addEmailLabel
            // 
            this.addEmailLabel.Location = new System.Drawing.Point(38, 113);
            this.addEmailLabel.Name = "addEmailLabel";
            this.addEmailLabel.Size = new System.Drawing.Size(155, 31);
            this.addEmailLabel.TabIndex = 24;
            this.addEmailLabel.Text = "Email";
            // 
            // addTelephoneLabel
            // 
            this.addTelephoneLabel.Location = new System.Drawing.Point(38, 62);
            this.addTelephoneLabel.Name = "addTelephoneLabel";
            this.addTelephoneLabel.Size = new System.Drawing.Size(155, 31);
            this.addTelephoneLabel.TabIndex = 23;
            this.addTelephoneLabel.Text = "Telephone";
            // 
            // addNameLabel
            // 
            this.addNameLabel.Location = new System.Drawing.Point(38, 13);
            this.addNameLabel.Name = "addNameLabel";
            this.addNameLabel.Size = new System.Drawing.Size(155, 31);
            this.addNameLabel.TabIndex = 22;
            this.addNameLabel.Text = "Name";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(281, 113);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(309, 22);
            this.emailBox.TabIndex = 21;
            // 
            // telephoneBox
            // 
            this.telephoneBox.Location = new System.Drawing.Point(281, 62);
            this.telephoneBox.Name = "telephoneBox";
            this.telephoneBox.Size = new System.Drawing.Size(309, 22);
            this.telephoneBox.TabIndex = 20;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(281, 13);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(309, 22);
            this.nameBox.TabIndex = 19;
            // 
            // roleLabel
            // 
            this.roleLabel.AutoSize = true;
            this.roleLabel.Location = new System.Drawing.Point(278, 168);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(35, 16);
            this.roleLabel.TabIndex = 31;
            this.roleLabel.Text = "NaN";
            // 
            // AdminInfoLabel1
            // 
            this.AdminInfoLabel1.Location = new System.Drawing.Point(43, 43);
            this.AdminInfoLabel1.Name = "AdminInfoLabel1";
            this.AdminInfoLabel1.Size = new System.Drawing.Size(303, 26);
            this.AdminInfoLabel1.TabIndex = 0;
            this.AdminInfoLabel1.Text = "Salary";
            // 
            // AdminInfoLabel2
            // 
            this.AdminInfoLabel2.Location = new System.Drawing.Point(43, 95);
            this.AdminInfoLabel2.Name = "AdminInfoLabel2";
            this.AdminInfoLabel2.Size = new System.Drawing.Size(303, 26);
            this.AdminInfoLabel2.TabIndex = 1;
            this.AdminInfoLabel2.Text = "Work Schedule";
            // 
            // AdminInfoLabel3
            // 
            this.AdminInfoLabel3.Location = new System.Drawing.Point(43, 144);
            this.AdminInfoLabel3.Name = "AdminInfoLabel3";
            this.AdminInfoLabel3.Size = new System.Drawing.Size(303, 26);
            this.AdminInfoLabel3.TabIndex = 2;
            this.AdminInfoLabel3.Text = "Start Time";
            // 
            // AdminSalaryText
            // 
            this.AdminSalaryText.Location = new System.Drawing.Point(395, 43);
            this.AdminSalaryText.Name = "AdminSalaryText";
            this.AdminSalaryText.Size = new System.Drawing.Size(222, 22);
            this.AdminSalaryText.TabIndex = 4;
            // 
            // AdminRadioPanel
            // 
            this.AdminRadioPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AdminRadioPanel.Controls.Add(this.radioFullTime);
            this.AdminRadioPanel.Controls.Add(this.radioPartTime);
            this.AdminRadioPanel.Location = new System.Drawing.Point(395, 89);
            this.AdminRadioPanel.Name = "AdminRadioPanel";
            this.AdminRadioPanel.Size = new System.Drawing.Size(222, 32);
            this.AdminRadioPanel.TabIndex = 15;
            // 
            // radioFullTime
            // 
            this.radioFullTime.Location = new System.Drawing.Point(3, 7);
            this.radioFullTime.Name = "radioFullTime";
            this.radioFullTime.Size = new System.Drawing.Size(105, 22);
            this.radioFullTime.TabIndex = 13;
            this.radioFullTime.TabStop = true;
            this.radioFullTime.Text = "Full-time";
            this.radioFullTime.UseVisualStyleBackColor = true;
            // 
            // radioPartTime
            // 
            this.radioPartTime.Location = new System.Drawing.Point(114, 6);
            this.radioPartTime.Name = "radioPartTime";
            this.radioPartTime.Size = new System.Drawing.Size(105, 22);
            this.radioPartTime.TabIndex = 14;
            this.radioPartTime.TabStop = true;
            this.radioPartTime.Text = "Part-time";
            this.radioPartTime.UseVisualStyleBackColor = true;
            // 
            // startTimePicker
            // 
            this.startTimePicker.Location = new System.Drawing.Point(395, 142);
            this.startTimePicker.Name = "startTimePicker";
            this.startTimePicker.Size = new System.Drawing.Size(223, 22);
            this.startTimePicker.TabIndex = 16;
            // 
            // endTimePicker
            // 
            this.endTimePicker.Location = new System.Drawing.Point(395, 191);
            this.endTimePicker.Name = "endTimePicker";
            this.endTimePicker.Size = new System.Drawing.Size(223, 22);
            this.endTimePicker.TabIndex = 17;
            // 
            // AdminInfoLabel4
            // 
            this.AdminInfoLabel4.Location = new System.Drawing.Point(43, 191);
            this.AdminInfoLabel4.Name = "AdminInfoLabel4";
            this.AdminInfoLabel4.Size = new System.Drawing.Size(303, 26);
            this.AdminInfoLabel4.TabIndex = 18;
            this.AdminInfoLabel4.Text = "End Time";
            // 
            // AdminDetailBox
            // 
            this.AdminDetailBox.Controls.Add(this.AdminInfoLabel4);
            this.AdminDetailBox.Controls.Add(this.endTimePicker);
            this.AdminDetailBox.Controls.Add(this.startTimePicker);
            this.AdminDetailBox.Controls.Add(this.AdminRadioPanel);
            this.AdminDetailBox.Controls.Add(this.AdminSalaryText);
            this.AdminDetailBox.Controls.Add(this.AdminInfoLabel3);
            this.AdminDetailBox.Controls.Add(this.AdminInfoLabel2);
            this.AdminDetailBox.Controls.Add(this.AdminInfoLabel1);
            this.AdminDetailBox.Location = new System.Drawing.Point(38, 271);
            this.AdminDetailBox.Name = "AdminDetailBox";
            this.AdminDetailBox.Size = new System.Drawing.Size(706, 246);
            this.AdminDetailBox.TabIndex = 30;
            this.AdminDetailBox.TabStop = false;
            this.AdminDetailBox.Text = "Admin";
            this.AdminDetailBox.Visible = false;
            // 
            // TeacherInfoLabel1
            // 
            this.TeacherInfoLabel1.Location = new System.Drawing.Point(43, 43);
            this.TeacherInfoLabel1.Name = "TeacherInfoLabel1";
            this.TeacherInfoLabel1.Size = new System.Drawing.Size(303, 26);
            this.TeacherInfoLabel1.TabIndex = 0;
            this.TeacherInfoLabel1.Text = "Salary";
            // 
            // TeacherInfoLabel2
            // 
            this.TeacherInfoLabel2.Location = new System.Drawing.Point(43, 95);
            this.TeacherInfoLabel2.Name = "TeacherInfoLabel2";
            this.TeacherInfoLabel2.Size = new System.Drawing.Size(303, 26);
            this.TeacherInfoLabel2.TabIndex = 1;
            this.TeacherInfoLabel2.Text = "Subject 1";
            // 
            // TeacherSubject1Text
            // 
            this.TeacherSubject1Text.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeacherSubject1Text.FormattingEnabled = true;
            this.TeacherSubject1Text.Items.AddRange(new object[] {
            "Mathematics",
            "Physics",
            "Chemistry",
            "Biology",
            "English",
            "History",
            "Geography",
            "ComputerScience",
            "Economics",
            "Psychology",
            "Sociology",
            "Art",
            "Music",
            "PhysicalEducation",
            "ForeignLanguage",
            "Literature",
            "Philosophy"});
            this.TeacherSubject1Text.Location = new System.Drawing.Point(395, 92);
            this.TeacherSubject1Text.Name = "TeacherSubject1Text";
            this.TeacherSubject1Text.Size = new System.Drawing.Size(220, 24);
            this.TeacherSubject1Text.TabIndex = 8;
            // 
            // TeacherInfoLabel3
            // 
            this.TeacherInfoLabel3.Location = new System.Drawing.Point(43, 144);
            this.TeacherInfoLabel3.Name = "TeacherInfoLabel3";
            this.TeacherInfoLabel3.Size = new System.Drawing.Size(303, 26);
            this.TeacherInfoLabel3.TabIndex = 2;
            this.TeacherInfoLabel3.Text = "Subject 2";
            // 
            // TeacherSubject2Text
            // 
            this.TeacherSubject2Text.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TeacherSubject2Text.FormattingEnabled = true;
            this.TeacherSubject2Text.Items.AddRange(new object[] {
            "Mathematics",
            "Physics",
            "Chemistry",
            "Biology",
            "English",
            "History",
            "Geography",
            "ComputerScience",
            "Economics",
            "Psychology",
            "Sociology",
            "Art",
            "Music",
            "PhysicalEducation",
            "ForeignLanguage",
            "Literature",
            "Philosophy"});
            this.TeacherSubject2Text.Location = new System.Drawing.Point(395, 141);
            this.TeacherSubject2Text.Name = "TeacherSubject2Text";
            this.TeacherSubject2Text.Size = new System.Drawing.Size(220, 24);
            this.TeacherSubject2Text.TabIndex = 9;
            // 
            // TeacherSalaryText
            // 
            this.TeacherSalaryText.Location = new System.Drawing.Point(395, 40);
            this.TeacherSalaryText.Name = "TeacherSalaryText";
            this.TeacherSalaryText.Size = new System.Drawing.Size(220, 22);
            this.TeacherSalaryText.TabIndex = 19;
            // 
            // TeacherDetailBox
            // 
            this.TeacherDetailBox.Controls.Add(this.TeacherSalaryText);
            this.TeacherDetailBox.Controls.Add(this.TeacherSubject2Text);
            this.TeacherDetailBox.Controls.Add(this.TeacherInfoLabel3);
            this.TeacherDetailBox.Controls.Add(this.TeacherSubject1Text);
            this.TeacherDetailBox.Controls.Add(this.TeacherInfoLabel2);
            this.TeacherDetailBox.Controls.Add(this.TeacherInfoLabel1);
            this.TeacherDetailBox.Location = new System.Drawing.Point(38, 271);
            this.TeacherDetailBox.Name = "TeacherDetailBox";
            this.TeacherDetailBox.Size = new System.Drawing.Size(706, 246);
            this.TeacherDetailBox.TabIndex = 32;
            this.TeacherDetailBox.TabStop = false;
            this.TeacherDetailBox.Text = "Teacher";
            this.TeacherDetailBox.Visible = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(43, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(303, 26);
            this.label4.TabIndex = 0;
            this.label4.Text = "Current Subject 1";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(43, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(303, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Current Subject 2";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(43, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Previous Subject 1";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(43, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Previous Subject 2";
            // 
            // StudentInfo2
            // 
            this.StudentInfo2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentInfo2.FormattingEnabled = true;
            this.StudentInfo2.Items.AddRange(new object[] {
            "Mathematics",
            "Physics",
            "Chemistry",
            "Biology",
            "English",
            "History",
            "Geography",
            "ComputerScience",
            "Economics",
            "Psychology",
            "Sociology",
            "Art",
            "Music",
            "PhysicalEducation",
            "ForeignLanguage",
            "Literature",
            "Philosophy"});
            this.StudentInfo2.Location = new System.Drawing.Point(395, 92);
            this.StudentInfo2.Name = "StudentInfo2";
            this.StudentInfo2.Size = new System.Drawing.Size(223, 24);
            this.StudentInfo2.TabIndex = 5;
            // 
            // StudentInfo3
            // 
            this.StudentInfo3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentInfo3.FormattingEnabled = true;
            this.StudentInfo3.Items.AddRange(new object[] {
            "Mathematics",
            "Physics",
            "Chemistry",
            "Biology",
            "English",
            "History",
            "Geography",
            "ComputerScience",
            "Economics",
            "Psychology",
            "Sociology",
            "Art",
            "Music",
            "PhysicalEducation",
            "ForeignLanguage",
            "Literature",
            "Philosophy"});
            this.StudentInfo3.Location = new System.Drawing.Point(395, 141);
            this.StudentInfo3.Name = "StudentInfo3";
            this.StudentInfo3.Size = new System.Drawing.Size(222, 24);
            this.StudentInfo3.TabIndex = 6;
            // 
            // StudentInfo4
            // 
            this.StudentInfo4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentInfo4.FormattingEnabled = true;
            this.StudentInfo4.Items.AddRange(new object[] {
            "Mathematics",
            "Physics",
            "Chemistry",
            "Biology",
            "English",
            "History",
            "Geography",
            "ComputerScience",
            "Economics",
            "Psychology",
            "Sociology",
            "Art",
            "Music",
            "PhysicalEducation",
            "ForeignLanguage",
            "Literature",
            "Philosophy"});
            this.StudentInfo4.Location = new System.Drawing.Point(395, 193);
            this.StudentInfo4.Name = "StudentInfo4";
            this.StudentInfo4.Size = new System.Drawing.Size(223, 24);
            this.StudentInfo4.TabIndex = 7;
            // 
            // StudentInfo1
            // 
            this.StudentInfo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentInfo1.FormattingEnabled = true;
            this.StudentInfo1.Items.AddRange(new object[] {
            "Mathematics",
            "Physics",
            "Chemistry",
            "Biology",
            "English",
            "History",
            "Geography",
            "ComputerScience",
            "Economics",
            "Psychology",
            "Sociology",
            "Art",
            "Music",
            "PhysicalEducation",
            "ForeignLanguage",
            "Literature",
            "Philosophy"});
            this.StudentInfo1.Location = new System.Drawing.Point(395, 40);
            this.StudentInfo1.Name = "StudentInfo1";
            this.StudentInfo1.Size = new System.Drawing.Size(222, 24);
            this.StudentInfo1.TabIndex = 8;
            // 
            // StudentDetailBox
            // 
            this.StudentDetailBox.Controls.Add(this.StudentInfo1);
            this.StudentDetailBox.Controls.Add(this.StudentInfo4);
            this.StudentDetailBox.Controls.Add(this.StudentInfo3);
            this.StudentDetailBox.Controls.Add(this.StudentInfo2);
            this.StudentDetailBox.Controls.Add(this.label1);
            this.StudentDetailBox.Controls.Add(this.label2);
            this.StudentDetailBox.Controls.Add(this.label3);
            this.StudentDetailBox.Controls.Add(this.label4);
            this.StudentDetailBox.Location = new System.Drawing.Point(38, 271);
            this.StudentDetailBox.Name = "StudentDetailBox";
            this.StudentDetailBox.Size = new System.Drawing.Size(706, 246);
            this.StudentDetailBox.TabIndex = 11;
            this.StudentDetailBox.TabStop = false;
            this.StudentDetailBox.Text = "Student";
            this.StudentDetailBox.Visible = false;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Location = new System.Drawing.Point(38, 214);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(155, 31);
            this.passwordLabel.TabIndex = 34;
            this.passwordLabel.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(281, 214);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(309, 22);
            this.passwordBox.TabIndex = 33;
            this.passwordBox.Text = "password123";
            // 
            // EditUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 753);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.TeacherDetailBox);
            this.Controls.Add(this.StudentDetailBox);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.AdminDetailBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.SaveEditBtn);
            this.Controls.Add(this.addRoleLabel);
            this.Controls.Add(this.addEmailLabel);
            this.Controls.Add(this.addTelephoneLabel);
            this.Controls.Add(this.addNameLabel);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.telephoneBox);
            this.Controls.Add(this.nameBox);
            this.Name = "EditUserForm";
            this.Text = "EditUserForm";
            this.AdminRadioPanel.ResumeLayout(false);
            this.AdminDetailBox.ResumeLayout(false);
            this.AdminDetailBox.PerformLayout();
            this.TeacherDetailBox.ResumeLayout(false);
            this.TeacherDetailBox.PerformLayout();
            this.StudentDetailBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenu contextMenu1;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button SaveEditBtn;
        private System.Windows.Forms.Label addRoleLabel;
        private System.Windows.Forms.Label addEmailLabel;
        private System.Windows.Forms.Label addTelephoneLabel;
        private System.Windows.Forms.Label addNameLabel;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox telephoneBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label roleLabel;
        private System.Windows.Forms.Label AdminInfoLabel1;
        private System.Windows.Forms.Label AdminInfoLabel2;
        private System.Windows.Forms.Label AdminInfoLabel3;
        private System.Windows.Forms.TextBox AdminSalaryText;
        private System.Windows.Forms.Panel AdminRadioPanel;
        private System.Windows.Forms.RadioButton radioFullTime;
        private System.Windows.Forms.RadioButton radioPartTime;
        private System.Windows.Forms.DateTimePicker startTimePicker;
        private System.Windows.Forms.DateTimePicker endTimePicker;
        private System.Windows.Forms.Label AdminInfoLabel4;
        private System.Windows.Forms.GroupBox AdminDetailBox;
        private System.Windows.Forms.Label TeacherInfoLabel1;
        private System.Windows.Forms.Label TeacherInfoLabel2;
        private System.Windows.Forms.ComboBox TeacherSubject1Text;
        private System.Windows.Forms.Label TeacherInfoLabel3;
        private System.Windows.Forms.ComboBox TeacherSubject2Text;
        private System.Windows.Forms.TextBox TeacherSalaryText;
        private System.Windows.Forms.GroupBox TeacherDetailBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox StudentInfo2;
        private System.Windows.Forms.ComboBox StudentInfo3;
        private System.Windows.Forms.ComboBox StudentInfo4;
        private System.Windows.Forms.ComboBox StudentInfo1;
        private System.Windows.Forms.GroupBox StudentDetailBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordBox;
    }
}