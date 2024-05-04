using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Coursework
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        // Event handler for the login button click
        private void LoginButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Retrieve user input email and password from 
                string email = emailTextBox.Text;
                string password = passwordTextBox.Text;

                // Check if email and password have correct format
                if (!UserDatabase.IsValidEmail(email) || !UserDatabase.IsValidPassword(password)) {
                    // Display error message
                    throw new Exception("Invalid email or password.");
                }                    

                // Query to retrieve all persons with matching email with user input
                string verifyEmailQuery = "SELECT COUNT(*) FROM Person WHERE Email = @Email";

                // Establish a connection with the database
                using (SqlConnection connection = new SqlConnection(UserDatabase.connectionString))
                using (SqlCommand command = new SqlCommand(verifyEmailQuery, connection))
                {
                    connection.Open();
                    // Add email parameter to the SQL query
                    command.Parameters.AddWithValue("@Email", email);
                    // Execute the query and retrieve the count of matching persons
                    int count = (int)command.ExecuteScalar();
                    if (count <= 0)
                        // Display error message if there are no matching persons
                        throw new Exception("No account is associated with this email address.");
                }

                // Query to retrieve all persons with matching email AND password with user input
                string verifyPasswordQuery = "SELECT * FROM Person WHERE Email = @Email AND Password = @Password";

                // Establish a connection with the database
                using (SqlConnection connection = new SqlConnection(UserDatabase.connectionString))
                using (SqlCommand command = new SqlCommand(verifyPasswordQuery, connection))
                {
                    connection.Open();
                    // Add parameters to the SQL query
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Password", password);

                    // Create reader to execute query and retrieve matching persons
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // If there is matching person
                        if (reader.Read())
                        {
                            // Retrieve person's information with reader and set up session to save person's information
                            Session.SessionSetup((int)reader["Id"], (string)reader["Name"], (string)reader["Email"], (string)reader["Password"],
                                (Role)Enum.Parse(typeof(Role), (string)reader["Role"]));
                        } else
                            throw new Exception("Incorrect password.");
                    }                        
                }
            } catch (Exception ex) {
                // Display error message and stop method
                MessageBox.Show(ex.Message);
                return;
            }

            // Open the apprioriate form based on user's role after hiding and suspending the login form
            if (Session.Role == Role.Admin) {
                var mainForm = new MainForm();
                this.Hide();
                mainForm.ShowDialog();
            } 
            else if (Session.Role == Role.Student) {
                var studentForm = new StudentForm();
                this.Hide(); 
                studentForm.ShowDialog();
            } 
            else {
                var teacherForm = new TeacherForm();
                this.Hide();
                teacherForm.ShowDialog();
            }
            
            // Clear the email and password textbox and unhide the login form
            passwordTextBox.Text = "";
            emailTextBox.Text = "";
            Show();
        }

        // Event handler for the signup button click
        private void signupBtn_Click(object sender, EventArgs e)
        {
            // Open the modified add user form
            var SignUpForm = new AddUserForm();
            SignUpForm.ShowDialog();
        }
    }
}