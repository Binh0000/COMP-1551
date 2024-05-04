using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Coursework
{
    partial class AddUserForm
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
            this.RoleList = new System.Windows.Forms.ComboBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.telephoneBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.addNameLabel = new System.Windows.Forms.Label();
            this.addTelephoneLabel = new System.Windows.Forms.Label();
            this.addEmailLabel = new System.Windows.Forms.Label();
            this.addRoleLabel = new System.Windows.Forms.Label();
            this.AddUserButton = new System.Windows.Forms.Button();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.contextMenu1 = new System.Windows.Forms.ContextMenu();
            this.StudentInfoLabel1 = new System.Windows.Forms.Label();
            this.StudentInfoLabel2 = new System.Windows.Forms.Label();
            this.StudentInfoLabel3 = new System.Windows.Forms.Label();
            this.StudentInfoLabel4 = new System.Windows.Forms.Label();
            this.StudentInfo2 = new System.Windows.Forms.ComboBox();
            this.StudentInfo3 = new System.Windows.Forms.ComboBox();
            this.StudentInfo4 = new System.Windows.Forms.ComboBox();
            this.StudentInfo1 = new System.Windows.Forms.ComboBox();
            this.StudentDetailBox = new System.Windows.Forms.GroupBox();
            this.TeacherInfoLabel1 = new System.Windows.Forms.Label();
            this.TeacherInfoLabel2 = new System.Windows.Forms.Label();
            this.TeacherSubject1Text = new System.Windows.Forms.ComboBox();
            this.TeacherInfoLabel3 = new System.Windows.Forms.Label();
            this.TeacherSubject2Text = new System.Windows.Forms.ComboBox();
            this.TeacherSalaryText = new System.Windows.Forms.TextBox();
            this.TeacherDetailBox = new System.Windows.Forms.GroupBox();
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
            this.addPasswordLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.StudentDetailBox.SuspendLayout();
            this.TeacherDetailBox.SuspendLayout();
            this.AdminRadioPanel.SuspendLayout();
            this.AdminDetailBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoleList
            // 
            this.RoleList.FormattingEnabled = true;
            this.RoleList.Location = new System.Drawing.Point(268, 170);
            this.RoleList.Name = "RoleList";
            this.RoleList.Size = new System.Drawing.Size(309, 24);
            this.RoleList.TabIndex = 0;
            this.RoleList.SelectedIndexChanged += new System.EventHandler(this.RoleList_SelectedIndexChanged);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(268, 15);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(309, 22);
            this.nameBox.TabIndex = 1;
            this.nameBox.Text = "Example Name";
            // 
            // telephoneBox
            // 
            this.telephoneBox.Location = new System.Drawing.Point(268, 64);
            this.telephoneBox.Name = "telephoneBox";
            this.telephoneBox.Size = new System.Drawing.Size(309, 22);
            this.telephoneBox.TabIndex = 2;
            this.telephoneBox.Text = "0123456789";
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(268, 115);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(309, 22);
            this.emailBox.TabIndex = 3;
            this.emailBox.Text = "example@email.com";
            // 
            // addNameLabel
            // 
            this.addNameLabel.Location = new System.Drawing.Point(25, 15);
            this.addNameLabel.Name = "addNameLabel";
            this.addNameLabel.Size = new System.Drawing.Size(155, 31);
            this.addNameLabel.TabIndex = 4;
            this.addNameLabel.Text = "Name";
            // 
            // addTelephoneLabel
            // 
            this.addTelephoneLabel.Location = new System.Drawing.Point(25, 64);
            this.addTelephoneLabel.Name = "addTelephoneLabel";
            this.addTelephoneLabel.Size = new System.Drawing.Size(155, 31);
            this.addTelephoneLabel.TabIndex = 5;
            this.addTelephoneLabel.Text = "Telephone";
            // 
            // addEmailLabel
            // 
            this.addEmailLabel.Location = new System.Drawing.Point(25, 115);
            this.addEmailLabel.Name = "addEmailLabel";
            this.addEmailLabel.Size = new System.Drawing.Size(155, 31);
            this.addEmailLabel.TabIndex = 6;
            this.addEmailLabel.Text = "Email";
            // 
            // addRoleLabel
            // 
            this.addRoleLabel.Location = new System.Drawing.Point(25, 170);
            this.addRoleLabel.Name = "addRoleLabel";
            this.addRoleLabel.Size = new System.Drawing.Size(155, 31);
            this.addRoleLabel.TabIndex = 7;
            this.addRoleLabel.Text = "Role";
            // 
            // AddUserButton
            // 
            this.AddUserButton.Location = new System.Drawing.Point(25, 556);
            this.AddUserButton.Name = "AddUserButton";
            this.AddUserButton.Size = new System.Drawing.Size(103, 54);
            this.AddUserButton.TabIndex = 8;
            this.AddUserButton.Text = "Add User";
            this.AddUserButton.UseVisualStyleBackColor = true;
            this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // CancelBtn
            // 
            this.CancelBtn.Location = new System.Drawing.Point(628, 556);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(103, 54);
            this.CancelBtn.TabIndex = 10;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // StudentInfoLabel1
            // 
            this.StudentInfoLabel1.Location = new System.Drawing.Point(43, 43);
            this.StudentInfoLabel1.Name = "StudentInfoLabel1";
            this.StudentInfoLabel1.Size = new System.Drawing.Size(303, 26);
            this.StudentInfoLabel1.TabIndex = 0;
            this.StudentInfoLabel1.Text = "Current Subject 1";
            // 
            // StudentInfoLabel2
            // 
            this.StudentInfoLabel2.Location = new System.Drawing.Point(43, 95);
            this.StudentInfoLabel2.Name = "StudentInfoLabel2";
            this.StudentInfoLabel2.Size = new System.Drawing.Size(303, 26);
            this.StudentInfoLabel2.TabIndex = 1;
            this.StudentInfoLabel2.Text = "Current Subject 2";
            // 
            // StudentInfoLabel3
            // 
            this.StudentInfoLabel3.Location = new System.Drawing.Point(43, 144);
            this.StudentInfoLabel3.Name = "StudentInfoLabel3";
            this.StudentInfoLabel3.Size = new System.Drawing.Size(303, 26);
            this.StudentInfoLabel3.TabIndex = 2;
            this.StudentInfoLabel3.Text = "Previous Subject 1";
            // 
            // StudentInfoLabel4
            // 
            this.StudentInfoLabel4.Location = new System.Drawing.Point(43, 196);
            this.StudentInfoLabel4.Name = "StudentInfoLabel4";
            this.StudentInfoLabel4.Size = new System.Drawing.Size(303, 26);
            this.StudentInfoLabel4.TabIndex = 3;
            this.StudentInfoLabel4.Text = "Previous Subject 2";
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
            this.StudentDetailBox.Controls.Add(this.StudentInfoLabel4);
            this.StudentDetailBox.Controls.Add(this.StudentInfoLabel3);
            this.StudentDetailBox.Controls.Add(this.StudentInfoLabel2);
            this.StudentDetailBox.Controls.Add(this.StudentInfoLabel1);
            this.StudentDetailBox.Location = new System.Drawing.Point(19, 279);
            this.StudentDetailBox.Name = "StudentDetailBox";
            this.StudentDetailBox.Size = new System.Drawing.Size(706, 246);
            this.StudentDetailBox.TabIndex = 9;
            this.StudentDetailBox.TabStop = false;
            this.StudentDetailBox.Text = "Student";
            this.StudentDetailBox.Visible = false;
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
            this.TeacherDetailBox.Location = new System.Drawing.Point(19, 279);
            this.TeacherDetailBox.Name = "TeacherDetailBox";
            this.TeacherDetailBox.Size = new System.Drawing.Size(706, 246);
            this.TeacherDetailBox.TabIndex = 16;
            this.TeacherDetailBox.TabStop = false;
            this.TeacherDetailBox.Text = "Teacher";
            this.TeacherDetailBox.Visible = false;
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
            this.AdminDetailBox.Location = new System.Drawing.Point(19, 279);
            this.AdminDetailBox.Name = "AdminDetailBox";
            this.AdminDetailBox.Size = new System.Drawing.Size(706, 256);
            this.AdminDetailBox.TabIndex = 17;
            this.AdminDetailBox.TabStop = false;
            this.AdminDetailBox.Text = "Admin";
            this.AdminDetailBox.Visible = false;
            // 
            // addPasswordLabel
            // 
            this.addPasswordLabel.Location = new System.Drawing.Point(25, 221);
            this.addPasswordLabel.Name = "addPasswordLabel";
            this.addPasswordLabel.Size = new System.Drawing.Size(155, 31);
            this.addPasswordLabel.TabIndex = 19;
            this.addPasswordLabel.Text = "Password";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(268, 221);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(309, 22);
            this.passwordBox.TabIndex = 18;
            this.passwordBox.Text = "password123";
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(778, 749);
            this.Controls.Add(this.addPasswordLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.AdminDetailBox);
            this.Controls.Add(this.TeacherDetailBox);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.StudentDetailBox);
            this.Controls.Add(this.AddUserButton);
            this.Controls.Add(this.addRoleLabel);
            this.Controls.Add(this.addEmailLabel);
            this.Controls.Add(this.addTelephoneLabel);
            this.Controls.Add(this.addNameLabel);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.telephoneBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.RoleList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "AddUserForm";
            this.StudentDetailBox.ResumeLayout(false);
            this.TeacherDetailBox.ResumeLayout(false);
            this.TeacherDetailBox.PerformLayout();
            this.AdminRadioPanel.ResumeLayout(false);
            this.AdminDetailBox.ResumeLayout(false);
            this.AdminDetailBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.ContextMenu contextMenu1;

        private System.Windows.Forms.Button CancelBtn;
        
        private System.Windows.Forms.Button AddUserButton;

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox telephoneBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label addNameLabel;
        private System.Windows.Forms.Label addTelephoneLabel;
        private System.Windows.Forms.Label addEmailLabel;
        private System.Windows.Forms.Label addRoleLabel;

        private System.Windows.Forms.ComboBox RoleList;

        #endregion

        private Label StudentInfoLabel1;
        private Label StudentInfoLabel2;
        private Label StudentInfoLabel3;
        private Label StudentInfoLabel4;
        private ComboBox StudentInfo2;
        private ComboBox StudentInfo3;
        private ComboBox StudentInfo4;
        private ComboBox StudentInfo1;
        private GroupBox StudentDetailBox;
        private Label TeacherInfoLabel1;
        private Label TeacherInfoLabel2;
        private ComboBox TeacherSubject1Text;
        private Label TeacherInfoLabel3;
        private ComboBox TeacherSubject2Text;
        private TextBox TeacherSalaryText;
        private GroupBox TeacherDetailBox;
        private Label AdminInfoLabel1;
        private Label AdminInfoLabel2;
        private Label AdminInfoLabel3;
        private TextBox AdminSalaryText;
        private Panel AdminRadioPanel;
        private RadioButton radioFullTime;
        private RadioButton radioPartTime;
        private DateTimePicker startTimePicker;
        private DateTimePicker endTimePicker;
        private Label AdminInfoLabel4;
        private GroupBox AdminDetailBox;
        private Label addPasswordLabel;
        private TextBox passwordBox;
    }
}