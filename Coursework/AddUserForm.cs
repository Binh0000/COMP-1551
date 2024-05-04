using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using static Coursework.UserDatabase;

namespace Coursework
{
    public partial class AddUserForm : Form
    {
        public AddUserForm()
        {
            InitializeComponent();

            // Set title of the form
            this.Text = "Add User";

            // Adjust display text based on whether an user is signed in or not
            if (Session.Id == 0)
            {
                AddUserButton.Text = "Sign up";
            }

            // Add user roles to the combobox and set the default to be Student
            RoleList.Items.AddRange(new string[] { "Student", "Teacher", "Admin" });
            RoleList.DropDownStyle = ComboBoxStyle.DropDownList;
            RoleList.SelectedItem = "Student";

            //Set admin's default shift type to be full-time
            radioFullTime.Checked = true;

            //Set admin's DateTimePicker to allow user to select only hour and minute
            startTimePicker.Format = DateTimePickerFormat.Custom;
            startTimePicker.CustomFormat = "HH:mm";
            startTimePicker.ShowUpDown = true;
            startTimePicker.ShowCheckBox = false;
            startTimePicker.Value = DateTime.Now.Date;

            endTimePicker.Format = DateTimePickerFormat.Custom;
            endTimePicker.CustomFormat = "HH:mm";
            endTimePicker.ShowUpDown = true;
            endTimePicker.ShowCheckBox = false;
            endTimePicker.Value = DateTime.Now.Date;

            StudentDetailBox.Text = "Student Details";
        }
        
        private void AddUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                string prompt = (Session.Id == 0? "Are you sure you want to register an account" : "Do you want to add this user?");
                var result = MessageBox.Show(prompt, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check if the user clicked Yes or No
                if (result == DialogResult.No) { return; }
                
                // Get the user-input values
                var name = nameBox.Text;
                var telephone = telephoneBox.Text;
                var email = emailBox.Text;
                var role = RoleList.SelectedItem.ToString();
                var password = passwordBox.Text;

                // Query to find persons with the same email as the user-input email
                string verifyEmailQuery = "SELECT COUNT(*) FROM Person WHERE Email = @Email";

                // Establish connection to the database
                using (SqlConnection connection = new SqlConnection(UserDatabase.connectionString))
                using (SqlCommand command = new SqlCommand(verifyEmailQuery, connection))
                {
                    connection.Open();

                    // Add parameter to the query
                    command.Parameters.AddWithValue("@Email", email);

                    // Get the count of persons
                    int count = (int)command.ExecuteScalar();
                    // If there exist a person with the same email, display error message
                    if (count > 0)
                        throw new Exception("This email is already linked to another account.");
                }

                // Handle invalid name and display error message
                if (!IsValidName(name))
                {
                    throw new Exception("Invalid name format.");
                }

                // Handle invalid telephone number and display error message
                if (!IsValidPhoneNumber(telephone))
                {
                    // Handle invalid telephone number
                    throw new Exception("Invalid telephone number format.");
                }

                // Handle invalid email and display error message
                if (!IsValidEmail(email))
                {
                    // Handle invalid email
                    throw new Exception("Invalid email format.");
                }

                // Handle invalid password and display error message
                if (!IsValidPassword(password))
                {
                    // Handle invalid email
                    throw new Exception("Invalid password format.");
                }

                // Switch to determine which role's specific information is to be added to the database and the corresponding list
                switch (role)
                {
                    case "Student":

                        var cs1 = StudentInfo1.SelectedItem.ToString();
                        var cs2 = StudentInfo2.SelectedItem.ToString();
                        var ps1 = StudentInfo3.SelectedItem.ToString();
                        var ps2 = StudentInfo4.SelectedItem.ToString();

                        // Check if user selected duplicate subjects
                        if (HasDuplicate(new string[] { cs1, cs2, ps1, ps2 }))
                        {
                            throw new Exception("There are duplicate subjects.");
                        }

                        // Create a student from the user-input values and add it to the appropriate list
                        Student student = new Student(name, telephone, email, Role.Student, password, 
                            (Subject)Enum.Parse(typeof(Subject), cs1),
                            (Subject)Enum.Parse(typeof(Subject), cs2),
                            (Subject)Enum.Parse(typeof(Subject), ps1),
                            (Subject)Enum.Parse(typeof(Subject), ps2)
                        );
                        StudentList.Add(student);   
                        // Call method to add this student to the database
                        student.AddToDatabase();

                        break;

                    case "Teacher":

                        double teacherSalary;
                        var ts1 = TeacherSubject1Text.Text;
                        var ts2 = TeacherSubject2Text.Text;

                        // Check if user input a valid salary value
                        if (!IsValidSalary(TeacherSalaryText.Text))
                        {
                            throw new Exception("Please enter valid salary.");
                        } else
                            double.TryParse(TeacherSalaryText.Text, out teacherSalary);

                        // Check if user selected duplicate subjects
                        if (HasDuplicate(new string[] {ts1, ts2}))
                        {
                            throw new Exception("There are duplicate subjects.");
                        }

                        // Create a teacher from the user-input values and add it to the appropriate list
                        Teacher teacher = new Teacher(name, telephone, email, Role.Teacher, password, teacherSalary,
                            (Subject)Enum.Parse(typeof(Subject), ts1),
                            (Subject)Enum.Parse(typeof(Subject), ts2)
                        );
                        TeacherList.Add(teacher);
                        // Call method to add this student to the database
                        teacher.AddToDatabase();

                        break;

                    case "Admin":
                        double adminSalary;
                        var isFullTime = radioFullTime.Checked;

                        // Check if user input a valid salary value
                        if (!IsValidSalary(AdminSalaryText.Text))
                        {
                            throw new Exception("Please enter valid salary.");
                        }
                        else
                            double.TryParse(AdminSalaryText.Text, out adminSalary);

                        TimeSpan startTime = startTimePicker.Value.TimeOfDay;
                        TimeSpan endTime = endTimePicker.Value.TimeOfDay;

                        // Check if the end of the working hour is before the start
                        if (startTime > endTime)
                        {
                            throw new Exception("Start time can't be after end time.");
                        }

                        // Create an admin from the user-input values and add it to the appropriate list
                        Admin admin = new Admin(name, telephone, email, Role.Admin, password,
                            adminSalary, isFullTime, startTime, endTime);
                        AdminList.Add(admin);
                        // Call method to add this admin to the database
                        admin.AddToDatabase();
                            
                        break;
                }

                // Display approriate message depending on whether an user is logged in or not
                MessageBox.Show(Session.Id == 0? "Account resgistered" : "User added!");
                this.Close();
                                
            } 
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Event handler for selecting options from the role combobox
        private void RoleList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected role
            var role = RoleList.SelectedItem.ToString();
            // Switch to show the appropriate input form for the selected role and hide the others
            switch (role)
            {
                case "Student":
                    StudentDetailBox.Visible = true;
                    TeacherDetailBox.Visible = false;
                    AdminDetailBox.Visible = false;
                                        
                    StudentDetailBox.BringToFront();
                    TeacherDetailBox.SendToBack();
                    AdminDetailBox.SendToBack();
                    
                    break;
                case "Teacher":
                    StudentDetailBox.Visible = false;
                    TeacherDetailBox.Visible = true;
                    AdminDetailBox.Visible = false;
                    
                    StudentDetailBox.SendToBack();
                    TeacherDetailBox.BringToFront();
                    AdminDetailBox.SendToBack();
                    
                    break;
                case "Admin":
                    StudentDetailBox.Visible = false;
                    TeacherDetailBox.Visible = false;
                    AdminDetailBox.Visible = true;
                    
                    StudentDetailBox.SendToBack();
                    TeacherDetailBox.SendToBack();
                    AdminDetailBox.BringToFront();
                    
                    break;
            }
        }

        // Event handler for clicking cancel button
        private void CancelButton_Click(object sender, EventArgs e)
        {
            //Ask user for confirmation
            var result = MessageBox.Show("Cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check if the user clicked Yes or No
            if (result == DialogResult.Yes)
            {
                // If yes, close form
                this.Close();
            }
        }
    }
}