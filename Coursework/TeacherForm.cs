using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Coursework
{
    public partial class TeacherForm : Form
    {
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
                    case "Teacher Table":
                        query = "SELECT T.Person_Id as Id, P.Name, P.Telephone, P.Email, P.Role, T.Salary, T.Subject1, T.Subject2 FROM Person P " +
                            "INNER JOIN Teacher T ON P.Id = T.Person_Id";
                        break;
                    default:
                        query = "SELECT S.Person_Id AS Id, P.Name, P.Telephone, P.Email, P.Role, S.CurrentSubject1, S.CurrentSubject2, S.PreviousSubject1, S.PreviousSubject2 FROM Person P " +
                            "INNER JOIN Student S ON P.Id = S.Person_Id";
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
            }
            catch (Exception ex)
            {
                // Handle any error 
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public TeacherForm()
        {
            InitializeComponent();
            //Set title of the form
            this.Text = "Desktop Information System";
            // Add an event handler for form closing event
            this.FormClosing += Form_FormClosing;
            // Set the default table selection to student table
            tableSelectionComboBox.SelectedIndex = 0;
            // Call method for setting up DataGridView table
            SetupTable();

        }

        // Event handler for the "Edit Profile" button click
        private void EditUserWindowButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Check and prevent user from selecting rows from table of teachers to edit
                if (tableSelectionComboBox.Text == "Teacher Table")
                    // Display error message
                    throw new Exception("You cannot edit other teachers' information.");

                // Check if any row is selected for editing
                if (AllUserTable.SelectedRows.Count <= 0)
                    // Display error message
                    throw new Exception("Please select a row to edit.");

                // Check if more than one row is selected for editing
                if (AllUserTable.SelectedRows.Count > 1)
                {
                    // Display error message
                    throw new Exception("Only one row can be edited at a time.");
                }
                // Get the ID of the selected user
                var selectedRow = AllUserTable.SelectedRows[0];
                int id = Convert.ToInt32(selectedRow.Cells["ID"].Value);

                // Open the form for editing person with the selected user's ID as parameter, and suspend current form
                var editForm = new EditUserForm(id);
                editForm.ShowDialog();

                // Refresh table after editing
                SetupTable();
            }
            catch (Exception ex)
            {
                // Handle any error 
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        // Event handler for the "Refresh" button click
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            // Refresh the FlowLayoutPanel
            SetupTable();
        }

        // Event handler for the "Logout" button click
        private void logoutButton_Click(object sender, EventArgs e)
        {
            // Close this form
            this.Close();
        }

        // Event handler for the form closing event
        private void Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ask for user confirmation before closing the form
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                // If user chose no, cancel closing the form                
                e.Cancel = true;
            }
            else
            {
                // else, destroy current session and continue closing form
                Session.SessionDestroy();
            }
        }

        // Event handler for changing the selection in the table selection combo box
        private void tableSelectionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Refresh the DataGridView to load and display new data from database
            SetupTable();
        }

        // Event handler for the "Edit Profile" button click
        private void editProfileButton_Click(object sender, EventArgs e)
        {
            // Open the form for editing user with the current user's ID as parameter, and suspend current form
            var editForm = new EditUserForm(Session.Id);
            editForm.ShowDialog();

            // Refresh the FlowLayoutPanel
            SetupTable();
        }
    }
}