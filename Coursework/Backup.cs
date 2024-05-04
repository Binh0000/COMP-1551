namespace Coursework
{
/*

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class MainForm : Form
    {
        private DataGridView _table = new DataGridView();
        public MainForm()
        {
            InitializeComponent();
            SetupTable();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            LoginForm.logoutFlag = true;
            this.Close();
        }

        private void addUserWindowButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddUserForm();
            addForm.ShowDialog();
        }
        
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true; // Cancel the form closing event
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void tableSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string index = (string) tableSelectionComboBox.SelectedItem;
            switch (index)
            {
                case "Student Table":
                    StudentTable.Visible = true;
                    AdminTable.Visible = false;
                    TeacherTable.Visible = false;
                    AllUserTable.Visible = false;
                    break;
                case "Admin Table":
                    StudentTable.Visible = false;
                    AdminTable.Visible = true;
                    TeacherTable.Visible = false;
                    AllUserTable.Visible = false;
                    break;
                case "Teacher Table":
                    StudentTable.Visible = false;
                    AdminTable.Visible = false;
                    TeacherTable.Visible = true;
                    AllUserTable.Visible = false;
                    break;
                case "All Users":
                    StudentTable.Visible = false;
                    AdminTable.Visible = false;
                    TeacherTable.Visible = false;
                    AllUserTable.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

 */


/*

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;

namespace Coursework
{
    partial class MainForm
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
            this.logoutButton = new System.Windows.Forms.Button();
            this.StudentTable = new System.Windows.Forms.DataGridView();
            this.addUserWindowButton = new System.Windows.Forms.Button();
            this.TeacherTable = new System.Windows.Forms.DataGridView();
            this.AdminTable = new System.Windows.Forms.DataGridView();
            this.tableSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AllUserTable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.StudentTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllUserTable)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(24, 760);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(115, 65);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // StudentTable
            // 
            this.StudentTable.AllowUserToAddRows = false;
            this.StudentTable.AllowUserToDeleteRows = false;
            this.StudentTable.AllowUserToOrderColumns = true;
            this.StudentTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentTable.Location = new System.Drawing.Point(24, 106);
            this.StudentTable.Name = "StudentTable";
            this.StudentTable.ReadOnly = true;
            this.StudentTable.RowTemplate.Height = 24;
            this.StudentTable.Size = new System.Drawing.Size(1385, 207);
            this.StudentTable.TabIndex = 1;
            // 
            // addUserWindowButton
            // 
            this.addUserWindowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserWindowButton.Location = new System.Drawing.Point(329, 756);
            this.addUserWindowButton.Name = "addUserWindowButton";
            this.addUserWindowButton.Size = new System.Drawing.Size(145, 68);
            this.addUserWindowButton.TabIndex = 2;
            this.addUserWindowButton.Text = "Add User";
            this.addUserWindowButton.UseVisualStyleBackColor = true;
            this.addUserWindowButton.Click += new System.EventHandler(this.addUserWindowButton_Click);
            // 
            // TeacherTable
            // 
            this.TeacherTable.AllowUserToAddRows = false;
            this.TeacherTable.AllowUserToDeleteRows = false;
            this.TeacherTable.AllowUserToOrderColumns = true;
            this.TeacherTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TeacherTable.Location = new System.Drawing.Point(24, 106);
            this.TeacherTable.Name = "TeacherTable";
            this.TeacherTable.ReadOnly = true;
            this.TeacherTable.RowTemplate.Height = 24;
            this.TeacherTable.Size = new System.Drawing.Size(1385, 207);
            this.TeacherTable.TabIndex = 3;
            // 
            // AdminTable
            // 
            this.AdminTable.AllowUserToAddRows = false;
            this.AdminTable.AllowUserToDeleteRows = false;
            this.AdminTable.AllowUserToOrderColumns = true;
            this.AdminTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AdminTable.Location = new System.Drawing.Point(24, 106);
            this.AdminTable.Name = "AdminTable";
            this.AdminTable.ReadOnly = true;
            this.AdminTable.RowTemplate.Height = 24;
            this.AdminTable.Size = new System.Drawing.Size(1385, 207);
            this.AdminTable.TabIndex = 4;
            // 
            // tableSelectionComboBox
            // 
            this.tableSelectionComboBox.AllowDrop = true;
            this.tableSelectionComboBox.FormattingEnabled = true;
            this.tableSelectionComboBox.Location = new System.Drawing.Point(12, 319);
            this.tableSelectionComboBox.Name = "tableSelectionComboBox";
            this.tableSelectionComboBox.Size = new System.Drawing.Size(377, 24);
            this.tableSelectionComboBox.TabIndex = 5;
            this.tableSelectionComboBox.Text = "fasdfasdf";
            this.tableSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.tableSelectionComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(570, 756);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 68);
            this.button1.TabIndex = 6;
            this.button1.Text = "Edit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(997, 756);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 68);
            this.button2.TabIndex = 7;
            this.button2.Text = "Delete User";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AllUserTable
            // 
            this.AllUserTable.AllowUserToAddRows = false;
            this.AllUserTable.AllowUserToDeleteRows = false;
            this.AllUserTable.AllowUserToOrderColumns = true;
            this.AllUserTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllUserTable.Location = new System.Drawing.Point(24, 106);
            this.AllUserTable.Name = "AllUserTable";
            this.AllUserTable.ReadOnly = true;
            this.AllUserTable.RowTemplate.Height = 24;
            this.AllUserTable.Size = new System.Drawing.Size(1385, 207);
            this.AllUserTable.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.AllUserTable);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tableSelectionComboBox);
            this.Controls.Add(this.AdminTable);
            this.Controls.Add(this.TeacherTable);
            this.Controls.Add(this.addUserWindowButton);
            this.Controls.Add(this.StudentTable);
            this.Controls.Add(this.logoutButton);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.StudentTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TeacherTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AdminTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllUserTable)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView AllUserTable;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;

        private System.Windows.Forms.ComboBox tableSelectionComboBox;

        private System.Windows.Forms.DataGridView AdminTable;

        private System.Windows.Forms.DataGridView TeacherTable;

        private System.Windows.Forms.Button addUserWindowButton;

        private System.Windows.Forms.DataGridView StudentTable;

        private void SetupTable()
        {
            //
            // Student table
            //
            var table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Telephone", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Role", typeof(Role));
            table.Columns.Add("Current Subject 1", typeof(string));
            table.Columns.Add("Current Subject 2", typeof(string));
            table.Columns.Add("Previous Subject 1", typeof(string));
            table.Columns.Add("Previous Subject 2", typeof(string));
            foreach (var s in Database.StudentList)
            {
                table.Rows.Add(s.Name, s.Telephone, s.Email, s.UserRole, 
                    s.CurrentSubject1, s.CurrentSubject2, s.PreviousSubject1, s.PreviousSubject2);
            }
            this.StudentTable.DataSource = table;
            
            //
            // Teacher table
            //
            var table1 = new DataTable();
            table1.Columns.Add("Name", typeof(string));
            table1.Columns.Add("Telephone", typeof(string));
            table1.Columns.Add("Email", typeof(string));
            table1.Columns.Add("Role", typeof(Role));
            table1.Columns.Add("Salary", typeof(string));
            table1.Columns.Add("Subject 1", typeof(string));
            table1.Columns.Add("Subject 2", typeof(string));
            foreach (var t in Database.TeacherList)
            {
                table1.Rows.Add(t.Name, t.Telephone, t.Email, t.UserRole, 
                    $"${t.Salary}", t.Subject1, t.Subject2);
            }
            this.TeacherTable.DataSource = table1;
            
            //
            // Admin table
            //
            var table2 = new DataTable();
            table2.Columns.Add("Name", typeof(string));
            table2.Columns.Add("Telephone", typeof(string));
            table2.Columns.Add("Email", typeof(string));
            table2.Columns.Add("Role", typeof(Role));
            foreach (var a in Database.AdminList)
            {
                table2.Rows.Add(a.Name, a.Telephone, a.Email, a.UserRole);
            }
            this.AdminTable.DataSource = table2;
            //
            // All Users table
            //
            var table3 = new DataTable();
            table3.Columns.Add("Name", typeof(string));
            table3.Columns.Add("Telephone", typeof(string));
            table3.Columns.Add("Email", typeof(string));
            table3.Columns.Add("Role", typeof(Role));
            foreach (var user in Database.UserList)
            {
                table3.Rows.Add(user.Name, user.Telephone, user.Email, user.UserRole);
            }
            this.AllUserTable.DataSource = table3;
            //
            // Combobox
            //
            tableSelectionComboBox.DataSource = new List<string> { "Student Table", "Teacher Table", "Admin Table", "All Users"};
        }
        
        private void SetupTeacherTable()
        {
            var table = new DataTable();
            table.Columns.Add("Name", typeof(string));
            table.Columns.Add("Telephone", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Role", typeof(Role));
            table.Columns.Add("Current Subject 1", typeof(string));
            table.Columns.Add("Current Subject 2", typeof(string));
            table.Columns.Add("Previous Subject 1", typeof(string));
            table.Columns.Add("Previous Subject 2", typeof(string));
            var temp = Database.StudentList;
            foreach (var s in Database.StudentList)
            {
                table.Rows.Add(s.Name, s.Telephone, s.Email, s.UserRole, 
                    s.CurrentSubject1, s.CurrentSubject2, s.PreviousSubject1, s.PreviousSubject2);
            }
            this.StudentTable.DataSource = table;
        }

        private System.Windows.Forms.Button logoutButton;

        #endregion
    }
}

 */
}