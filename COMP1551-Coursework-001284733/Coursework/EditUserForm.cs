using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Xml.Linq;
using static Coursework.UserDatabase;

namespace Coursework
{
    public partial class EditUserForm : Form
    {
        // variable to hold the ID of the person to be updated
        private int person_id;
        public EditUserForm(int id)
        {
            InitializeComponent();

            // Store the ID of the person to be updated
            this.person_id = id;

            // Query to select the person with the ID above
            var selectPersonQuery = "SELECT * FROM Person WHERE Id = @Id";
            
            try
            {
                // Establishing a connection to the database
                using (SqlConnection connection = new SqlConnection(UserDatabase.connectionString))
                using (SqlCommand command = new SqlCommand(selectPersonQuery, connection))
                {
                    // Setting the parameter ID for the SQL command
                    command.Parameters.AddWithValue("@Id", id);

                    connection.Open();

                    // Execute the query and get the result
                    SqlDataReader reader = command.ExecuteReader();
                    if (!reader.Read()) // If a row was found
                    {
                        throw new Exception("User with ID " + id + " not found.");
                    }

                    // Retrieve values from the reader
                    string name = reader["Name"].ToString();
                    string telephone = reader["Telephone"].ToString();
                    string email = reader["Email"].ToString();
                    string role = reader["Role"].ToString();
                    string password = reader["Password"].ToString();
                    reader.Close();

                    // Switch to show/hide detail boxes based on edited user's role
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

                    // Using the retrieved data to fill in form fields
                    nameBox.Text = name;
                    telephoneBox.Text = telephone;
                    emailBox.Text = email;
                    roleLabel.Text = role;
                    passwordBox.Text = password;

                    // Query to select role-specific information
                    string selectRoleQuery = $"SELECT * FROM {role} WHERE Person_Id = @Person_Id";

                    // Creating another command object for the second query
                    using (SqlCommand command2 = new SqlCommand(selectRoleQuery, connection))
                    {
                        command2.Parameters.AddWithValue("@Person_Id", id);
                        SqlDataReader reader2 = command2.ExecuteReader();

                        // If a row was found
                        if (reader2.Read()) 
                        {
                            // Retrieving role-specific data from the reader
                            switch (role)
                            {
                                case "Student":
                                    StudentInfo1.Text = reader2["CurrentSubject1"].ToString();
                                    StudentInfo2.Text = reader2["CurrentSubject2"].ToString();
                                    StudentInfo3.Text = reader2["PreviousSubject1"].ToString();
                                    StudentInfo4.Text = reader2["PreviousSubject2"].ToString();
                                    break;
                                case "Teacher":
                                    TeacherSalaryText.Text = reader2["Salary"].ToString();
                                    TeacherSubject1Text.Text = reader2["Subject1"].ToString();
                                    TeacherSubject2Text.Text = reader2["Subject2"].ToString();
                                    break;
                                case "Admin":

                                    // Setting the format of the date time picker so that users can only select hour and minute
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

                                    AdminSalaryText.Text = reader2["Salary"].ToString();
                                    radioFullTime.Checked = (bool)reader2["IsFullTime"];
                                    radioPartTime.Checked = !radioFullTime.Checked;
                                    startTimePicker.Value = DateTime.Today.Add((TimeSpan)reader2["StartTime"]);
                                    endTimePicker.Value = DateTime.Today.Add((TimeSpan)reader2["EndTime"]);
                                    
                                    break;
                            }
                            reader2.Close();
                        }
                    }

                    // Checking access level of user
                    // If user is a student
                    if (Session.Role == Role.Student)
                    {
                        // Preventing students from changing their own email
                        emailBox.ReadOnly = true;
                    }
                    // If user is a teacher
                    else if (Session.Role == Role.Teacher)
                    {
                        // If a student's information is being edited
                        if (role == "Student")
                        {
                            // limit ability to change a student's information to only school subjects
                            nameBox.ReadOnly = true;
                            telephoneBox.ReadOnly = true;
                            emailBox.ReadOnly = true;
                            passwordBox.Visible = false;
                            passwordBox.ReadOnly = true;
                            passwordLabel.Visible = false;
                        }
                        // If a teacher's information is being edited
                        else
                        {
                            // Preventing teachers from changing their own email
                            emailBox.ReadOnly = true;
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // Event handler for the Save button click
        private void SaveEditBtn_Click(object sender, EventArgs e)
        {
            // Asking user for confirmation to save the updated information
            var result = MessageBox.Show("Do you want to save the changes you have made?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check if the user clicked Yes or No
            if (result == DialogResult.No)
                return;


            // If user clicked Yes
            try
            {
                // Getting the user-input values that are common in all persons
                string role = roleLabel.Text;
                string telephone = telephoneBox.Text;
                string name = nameBox.Text;
                string email = emailBox.Text;
                string password = passwordBox.Text;

                // Validating user-input name
                if (!IsValidName(name))
                {
                    // Display error message
                    MessageBox.Show("Please enter valid name.");
                    return;
                }

                // Validating user-input telephone number
                if (!IsValidPhoneNumber(telephone))
                {
                    // Display error message
                    MessageBox.Show("Please enter valid phone number.");
                    return;
                }

                // Validating user-input email
                if (!IsValidEmail(email))
                {
                    // Display error message
                    MessageBox.Show("Please enter valid name.");
                    return;
                }

                // Switch to get the user-input values that are role-specific
                switch (role)
                {
                    case "Student":
                        // Getting the user-input subjects of student
                        string cs1 = StudentInfo1.Text;
                        string cs2 = StudentInfo2.Text;
                        string ps1 = StudentInfo3.Text;
                        string ps2 = StudentInfo4.Text;

                        // Check if the subjects chosen by user are duplicated
                        if (UserDatabase.HasDuplicate(new string[] { cs1, cs2, ps1, ps2}))
                        {
                            throw new Exception("There are duplicate subjects.");
                        }

                        // Identify the student to be updated from the list of students
                        Student student = StudentList.Find(s => s.Email == email);
                        // Updating the student in both the list and the database
                        student.UpdateToDatabase(person_id, name, telephone, email, password,
                            cs1, cs2, ps1, ps2);
                        break;
                    case "Teacher":
                        // Getting the user-input subjects and salary of teacher
                        var teacherSalary = Convert.ToDouble(TeacherSalaryText.Text);
                        Subject subject1 = (Subject)Enum.Parse(typeof(Subject),TeacherSubject1Text.Text);
                        Subject subject2 = (Subject)Enum.Parse(typeof(Subject), TeacherSubject2Text.Text);

                        // Check if the subjects selected by user are duplicated
                        if (UserDatabase.HasDuplicate(new string[] { TeacherSubject1Text.Text, TeacherSubject2Text.Text }))
                            // Display error message
                            throw new Exception("There are duplicate subjects.");

                        // Identify the teacher to be updated from the list of teachers
                        Teacher teacher = TeacherList.Find(t => t.Email == email);
                        // Updating the teacher in both the list and the database
                        teacher.UpdateToDatabase(person_id, name, telephone, email, password,
                            teacherSalary, subject1, subject2);
                        break;
                    case "Admin":
                        // Getting the user-input salary, shift type and work time of admin
                        var adminSalary = Convert.ToDouble(AdminSalaryText.Text);
                        bool isFullTime = radioFullTime.Checked;
                        TimeSpan start = startTimePicker.Value.TimeOfDay;
                        TimeSpan end = endTimePicker.Value.TimeOfDay;

                        // Identify the admin to be updated from the list of admins
                        Admin admin = AdminList.Find(a => a.Email == email);
                        // Updating the admin in both the list and the database
                        admin.UpdateToDatabase(person_id, name, telephone, email, password,
                            adminSalary, isFullTime, start, end);
                        break;
                }

                MessageBox.Show("User info successfully updated.");
                this.Close();
            } catch (Exception ex)
            {
                // Handle any exceptions that may occur
                MessageBox.Show($"Error: {ex.Message}");
            }            
        }

        // Event handler for the Save button click 
        private void CancelBtn_Click(object sender, EventArgs e)
        {
            // Ask for confirmation from user
            var result = MessageBox.Show("Do you want to cancel and discard all changes?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check if the user clicked Yes or No
            if (result == DialogResult.Yes)
                // Close the current information-editing window
                this.Close();
        }
    }
}