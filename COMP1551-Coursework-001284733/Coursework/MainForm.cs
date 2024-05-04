using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Coursework
{
    public partial class MainForm : Form
    {

        //Method for setting up the DataGridView table
        private void SetupTable()
        {
            try
            {
                // Get the selected table from the table selection combobox
                var selectedRole = tableSelectionComboBox.SelectedItem as string;

                // Initialize the query to retrieve data from a table
                string query = "";

                // Complete the query based on the selected option of the combobox
                switch (selectedRole)
                {
                    case "All Users":
                        query = "SELECT Id, Name, Telephone, Email, Role FROM Person";
                        break;
                    case "Student Table":
                        query = "SELECT S.Person_Id AS Id, P.Name, P.Telephone, P.Email, P.Role, S.CurrentSubject1, S.CurrentSubject2, S.PreviousSubject1, S.PreviousSubject2 FROM Person P " +
                            "INNER JOIN Student S ON P.Id = S.Person_Id";
                        break;
                    case "Teacher Table":
                        query = "SELECT T.Person_Id as Id, P.Name, P.Telephone, P.Email, P.Role, T.Salary, T.Subject1, T.Subject2 FROM Person P " +
                            "INNER JOIN Teacher T ON P.Id = T.Person_Id";
                        break;
                    case "Admin Table":
                        query = "SELECT A.Person_Id as Id, P.Name, P.Telephone, P.Email, P.Role, A.Salary, A.IsFullTime, A.StartTime, A.EndTime FROM Person P " +
                            "INNER JOIN Admin A ON P.Id = A.Person_Id";
                        break;
                    default:
                        query = "SELECT Id, Name, Telephone, Email, Role FROM Person";
                        break;
                }
                // Create a new DataTable to hold the query result
                DataTable dt = new DataTable();

                // Establish a connection with the database
                using (SqlConnection connection = new SqlConnection(UserDatabase.connectionString))
                {
                    connection.Open();
                    // Fill the DataTable with the data retrieved from the database using SqlDataAdapter
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        adapter.Fill(dt);
                    }
                }

                // Set the data source of the DataGridView to the DataTable above
                AllUserTable.DataSource = dt;

                // Clear the console text box
                console.Text = "";

                // Display students and their details in the console
                console.Text += "Students:\n";
                foreach (Student s in UserDatabase.StudentList)
                {
                    console.Text += $"{s.Name}, {s.Email}, {s.Telephone}, {s.UserRole}, {s.CurrentSubject1}, {s.CurrentSubject2}, {s.PreviousSubject1}, {s.PreviousSubject2}\n";
                }

                // Display teachers and their details in the console
                console.Text += "Teachers:\n";
                foreach (Teacher t in UserDatabase.TeacherList)
                {
                    console.Text += $"{t.Name}, {t.Email}, {t.Telephone}, {t.UserRole}, {t.Salary}, {t.Subject1}, {t.Subject2}\n";
                }

                // Display admins and their details in the console
                console.Text += "Admins:\n";
                foreach (Admin a in UserDatabase.AdminList)
                {
                    Console.WriteLine("Admins:");
                    console.Text += $"{a.Name}, {a.Email}, {a.Telephone}, {a.UserRole}, {a.Salary}, {(a.IsFullTime ? "Full-Time" : "Part-Time")}, {a.StartTime}, {a.EndTime}\n";
                }
            }
            catch (Exception ex)
            {
                // Handle any error 
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public MainForm()
        {
            InitializeComponent();
            //Set title of the form
            this.Text = "Desktop Information System";
            // Add an event handler for form closing event
            this.FormClosing += Form_FormClosing;

            // Call method for setting up DataGridView table
            SetupTable();

            // Set the default selection for the table selection combobox
            tableSelectionComboBox.SelectedIndex = 0;
        }

        // Event handler for changing the selection in the table selection combo box
        private void TableSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Refresh the DataGridView to load and display new data from database
            SetupTable();
        }

        // Event handler for the logout button click
        private void logoutButton_Click(object sender, EventArgs e)
        {
            // close the current form
            this.Close();
        }

        // Event handler for the form closing event
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ask for user confirmation before closing the form
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
                // If user chose no, cancel closing the form                
                e.Cancel = true;
            } else
            {
                // else, destroy current session and continue closing form
                Session.SessionDestroy();
            }            
        }

        // Event handler for the "Add User" button click
        private void addUserWindowButton_Click(object sender, EventArgs e)
        {
            // Open the form for adding user and suspend the current form
            var addForm = new AddUserForm();
            addForm.ShowDialog();

            // Refresh the table 
            SetupTable();
        }

        // Event handler for the "Edit User" button click
        private void EditUserWindowButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if a row is selected for editing
                if (AllUserTable.SelectedRows.Count <= 0)
                {
                    // Display error message
                    throw new Exception("Please select a row to edit.");
                }
                // Check if multiple rows are selected for editing
                if (AllUserTable.SelectedRows.Count > 1)
                {
                    // Display error message
                    throw new Exception("Only one row can be edited at a time.");
                }
                // Get the ID of the selected user
                var selectedRow = AllUserTable.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                // Open the form for editing user and suspend the current form
                var editForm = new EditUserForm(id);
                editForm.ShowDialog();

                // Refresh the table 
                SetupTable();
            }
            catch (Exception ex)
            {
                // Handle any error
                MessageBox.Show(ex.Message);
                return;
            }

        }

        // Event handler for the "Delete User" button click
        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check if any row is selected for deleting
                if (AllUserTable.SelectedRows.Count <= 0)
                {
                    // Display error message
                    throw new Exception("Please select a row or rows to delete.");
                }

                // Ask for confirmation before deleting the selected persons
                var result = MessageBox.Show("Do you want to delete these users?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check if the user clicked Yes or No
                if (result == DialogResult.No)
                { return; }

                // Loop through each selected row to delete the user(s)
                foreach (DataGridViewRow row in AllUserTable.SelectedRows)
                {
                    // Get the role of the user
                    string role = row.Cells["Role"].Value.ToString();
                    // Get the ID of the user
                    int id = Convert.ToInt32(row.Cells["ID"].Value); 

                    // Query for deleting person from database with matching ID
                    var deletePersonQuery = $"DELETE FROM Person WHERE Id = {id}";
                    using (var connection = new SqlConnection(UserDatabase.connectionString))
                    {
                        connection.Open();
                        // Query for deleting person from the corresponding role table
                        var deleteRoleQuery = $"DELETE FROM {role} WHERE Person_Id = @Person_Id";

                        // Execute the delete queries
                        using (var command = new SqlCommand(deleteRoleQuery, connection))
                        using (var command2 = new SqlCommand(deletePersonQuery, connection))
                        {
                            // Add parameter value for the first query
                            command.Parameters.AddWithValue("@Person_Id", id);
                            command.ExecuteNonQuery();

                            command2.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("User successfully deleted.");
                // Reload the table after deletion
                SetupTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Event handler for the "Refresh" button click
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            // Refresh the table 
            SetupTable();
        }
    }
}