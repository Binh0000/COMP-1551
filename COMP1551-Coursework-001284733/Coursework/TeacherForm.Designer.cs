namespace Coursework
{
    partial class TeacherForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.studentTableAdapter = new Coursework.Database1DataSetTableAdapters.StudentTableAdapter();
            this.personTableAdapter = new Coursework.Database1DataSetTableAdapters.PersonTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.personBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new Coursework.Database1DataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Coursework.Database1DataSetTableAdapters.TableAdapterManager();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.AllUserTable = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.editStudentButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.editProfileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllUserTable)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // personTableAdapter
            // 
            this.personTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(31, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 140);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // personBindingSource
            // 
            this.personBindingSource.DataMember = "Person";
            this.personBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.database1DataSet;
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
            // RefreshBtn
            // 
            this.RefreshBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.Location = new System.Drawing.Point(17, 529);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(145, 68);
            this.RefreshBtn.TabIndex = 22;
            this.RefreshBtn.Text = "Refresh";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // AllUserTable
            // 
            this.AllUserTable.AllowUserToAddRows = false;
            this.AllUserTable.AllowUserToDeleteRows = false;
            this.AllUserTable.AllowUserToOrderColumns = true;
            this.AllUserTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AllUserTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllUserTable.Location = new System.Drawing.Point(21, 21);
            this.AllUserTable.Name = "AllUserTable";
            this.AllUserTable.ReadOnly = true;
            this.AllUserTable.RowHeadersWidth = 51;
            this.AllUserTable.RowTemplate.Height = 24;
            this.AllUserTable.Size = new System.Drawing.Size(1220, 564);
            this.AllUserTable.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.AllUserTable);
            this.panel2.Location = new System.Drawing.Point(178, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1278, 775);
            this.panel2.TabIndex = 23;
            // 
            // tableSelectionComboBox
            // 
            this.tableSelectionComboBox.AllowDrop = true;
            this.tableSelectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tableSelectionComboBox.FormattingEnabled = true;
            this.tableSelectionComboBox.Items.AddRange(new object[] {
            "Student Table",
            "Teacher Table"});
            this.tableSelectionComboBox.Location = new System.Drawing.Point(21, 416);
            this.tableSelectionComboBox.Name = "tableSelectionComboBox";
            this.tableSelectionComboBox.Size = new System.Drawing.Size(141, 24);
            this.tableSelectionComboBox.TabIndex = 26;
            this.tableSelectionComboBox.SelectedIndexChanged += new System.EventHandler(this.tableSelectionComboBox_SelectedIndexChanged);
            // 
            // editStudentButton
            // 
            this.editStudentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStudentButton.Location = new System.Drawing.Point(17, 172);
            this.editStudentButton.Name = "editStudentButton";
            this.editStudentButton.Size = new System.Drawing.Size(145, 68);
            this.editStudentButton.TabIndex = 21;
            this.editStudentButton.Text = "Edit Students";
            this.editStudentButton.UseVisualStyleBackColor = true;
            this.editStudentButton.Click += new System.EventHandler(this.EditUserWindowButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutButton.Location = new System.Drawing.Point(31, 718);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(115, 65);
            this.logoutButton.TabIndex = 20;
            this.logoutButton.Text = "Log out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // editProfileButton
            // 
            this.editProfileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProfileButton.Location = new System.Drawing.Point(17, 268);
            this.editProfileButton.Name = "editProfileButton";
            this.editProfileButton.Size = new System.Drawing.Size(145, 68);
            this.editProfileButton.TabIndex = 25;
            this.editProfileButton.Text = "Edit Profile";
            this.editProfileButton.UseVisualStyleBackColor = true;
            this.editProfileButton.Click += new System.EventHandler(this.editProfileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 384);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 25);
            this.label1.TabIndex = 27;
            this.label1.Text = "View:";
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableSelectionComboBox);
            this.Controls.Add(this.editProfileButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.editStudentButton);
            this.Controls.Add(this.logoutButton);
            this.Name = "TeacherForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AllUserTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database1DataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private Database1DataSetTableAdapters.PersonTableAdapter personTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource personBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.DataGridView AllUserTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button editStudentButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ComboBox tableSelectionComboBox;
        private System.Windows.Forms.Button editProfileButton;
        private System.Windows.Forms.Label label1;
    }
}