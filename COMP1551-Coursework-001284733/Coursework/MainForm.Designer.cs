using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.logoutButton = new System.Windows.Forms.Button();
            this.addUserWindowButton = new System.Windows.Forms.Button();
            this.tableSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.editUserWindowButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.AllUserTable = new System.Windows.Forms.DataGridView();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.console = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Coursework.Database1DataSet();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.personTableAdapter = new Coursework.Database1DataSetTableAdapters.PersonTableAdapter();
            this.tableAdapterManager = new Coursework.Database1DataSetTableAdapters.TableAdapterManager();
            this.studentTableAdapter = new Coursework.Database1DataSetTableAdapters.StudentTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AllUserTable)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(26, 732);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(115, 65);
            this.logoutButton.TabIndex = 0;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // addUserWindowButton
            // 
            this.addUserWindowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUserWindowButton.Location = new System.Drawing.Point(26, 184);
            this.addUserWindowButton.Name = "addUserWindowButton";
            this.addUserWindowButton.Size = new System.Drawing.Size(145, 68);
            this.addUserWindowButton.TabIndex = 2;
            this.addUserWindowButton.Text = "Add User";
            this.addUserWindowButton.UseVisualStyleBackColor = true;
            this.addUserWindowButton.Click += new System.EventHandler(this.addUserWindowButton_Click);
            // 
            // tableSelectionComboBox
            // 
            this.tableSelectionComboBox.AllowDrop = true;
            this.tableSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableSelectionComboBox.FormattingEnabled = true;
            this.tableSelectionComboBox.Items.AddRange(new object[] {
            "All Users",
            "Student Table",
            "Teacher Table",
            "Admin Table"});
            this.tableSelectionComboBox.Location = new System.Drawing.Point(26, 662);
            this.tableSelectionComboBox.Name = "tableSelectionComboBox";
            this.tableSelectionComboBox.Size = new System.Drawing.Size(145, 24);
            this.tableSelectionComboBox.TabIndex = 5;
            this.tableSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.TableSelectionComboBox_SelectedIndexChanged);
            // 
            // editUserWindowButton
            // 
            this.editUserWindowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editUserWindowButton.Location = new System.Drawing.Point(26, 294);
            this.editUserWindowButton.Name = "editUserWindowButton";
            this.editUserWindowButton.Size = new System.Drawing.Size(145, 68);
            this.editUserWindowButton.TabIndex = 6;
            this.editUserWindowButton.Text = "Edit User";
            this.editUserWindowButton.UseVisualStyleBackColor = true;
            this.editUserWindowButton.Click += new System.EventHandler(this.EditUserWindowButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserButton.Location = new System.Drawing.Point(26, 409);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(145, 68);
            this.deleteUserButton.TabIndex = 7;
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // AllUserTable
            // 
            this.AllUserTable.AllowUserToAddRows = false;
            this.AllUserTable.AllowUserToDeleteRows = false;
            this.AllUserTable.AllowUserToOrderColumns = true;
            this.AllUserTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllUserTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllUserTable.Location = new System.Drawing.Point(19, 18);
            this.AllUserTable.Name = "AllUserTable";
            this.AllUserTable.ReadOnly = true;
            this.AllUserTable.RowHeadersWidth = 51;
            this.AllUserTable.RowTemplate.Height = 24;
            this.AllUserTable.Size = new System.Drawing.Size(1220, 564);
            this.AllUserTable.TabIndex = 8;
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.Location = new System.Drawing.Point(26, 525);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(145, 68);
            this.RefreshBtn.TabIndex = 8;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoScrollMargin = new System.Drawing.Size(0, 200);
            this.panel2.AutoScrollMinSize = new System.Drawing.Size(0, 10);
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.console);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.AllUserTable);
            this.panel2.Location = new System.Drawing.Point(211, 73);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1278, 724);
            this.panel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 663);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Output";
            // 
            // console
            // 
            this.console.Location = new System.Drawing.Point(24, 682);
            this.console.Name = "console";
            this.console.Size = new System.Drawing.Size(983, 116);
            this.console.TabIndex = 10;
            this.console.Text = "";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(505, 841);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 9;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.database1DataSet;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(26, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 140);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdminTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PersonTableAdapter = this.personTableAdapter;
            this.tableAdapterManager.StudentTableAdapter = this.studentTableAdapter;
            this.tableAdapterManager.TeacherTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Coursework.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 616);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "View:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.addUserWindowButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.tableSelectionComboBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.editUserWindowButton);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.logoutButton);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.AllUserTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button RefreshBtn;

        private System.Windows.Forms.DataGridView AllUserTable;

        private System.Windows.Forms.Button editUserWindowButton;
        private System.Windows.Forms.Button deleteUserButton;

        private System.Windows.Forms.ComboBox tableSelectionComboBox;

        private System.Windows.Forms.Button addUserWindowButton;

        private System.Windows.Forms.Button logoutButton;

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Database1DataSet database1DataSet;
        private BindingSource personBindingSource;
        private Database1DataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Database1DataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private BindingSource studentBindingSource;
        private Panel panel1;
        private RichTextBox console;
        private Label label1;
        private Label label2;
    }
}