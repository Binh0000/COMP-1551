using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Coursework
{
    public partial class StudentForm : Form
    {
        private void SetupTable()
        {
            try
            {
                // SQL query to retrieve some of the information of the students in database
                string query = "SELECT S.Person_Id AS Id, P.Name, P.Email, P.Role, S.CurrentSubject1, S.CurrentSubject2, S.PreviousSubject1, S.PreviousSubject2 FROM Person P " +
                            "INNER JOIN Student S " +
                            "ON P.Id = S.Person_Id";

                //Create a new DataTable to hold the query result
                DataTable dt = new DataTable();

                // Establish a connection to the database
                using (SqlConnection connection = new SqlConnection(UserDatabase.connectionString))
                {
                    connection.Open();

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        // Fill the DataTable with data from the database
                        adapter.Fill(dt);
                    }
                }

                // Clear existing controls from StudentListPanel
                StudentListPanel.Controls.Clear();

                // Iterate through each row in the DataTable
                foreach (DataRow row in dt.Rows)
                {
                    // Calculate an appropriate width for the panel to display student information
                    int panWidth = StudentListPanel.ClientSize.Width - SystemInformation.VerticalScrollBarWidth;

                    // Create a panel to display student information and set up its appearance and properties
                    var pan = new FlowLayoutPanel
                    {
                        BorderStyle = BorderStyle.FixedSingle,
                        FlowDirection = FlowDirection.TopDown,
                        //AutoSize = true,
                        Size = new Size(750, 750)
                    };

                    // Create labels to display the information retrieved from the database and add them to StudentListPanel
                    Label nameLbl = new Label();
                    pan.Controls.Add(nameLbl);
                    nameLbl.Text = $"Name: {row["Name"].ToString()}";
                    nameLbl.AutoSize = true;

                    Label emailLbl = new Label();
                    pan.Controls.Add(emailLbl);
                    emailLbl.Text = $"Email: {row["Email"].ToString()}";
                    emailLbl.AutoSize = true;

                    Label roleLbl = new Label();
                    pan.Controls.Add(roleLbl);
                    roleLbl.Text = $"Role: {row["Role"].ToString()}";
                    roleLbl.AutoSize = true;

                    Label cs1Lbl = new Label();
                    pan.Controls.Add(cs1Lbl);
                    cs1Lbl.Text = $"CurrentSubject1: {row["CurrentSubject1"].ToString()}";
                    cs1Lbl.AutoSize = true;

                    Label cs2Lbl = new Label();
                    pan.Controls.Add(cs2Lbl);
                    cs2Lbl.Text = $"CurrentSubject2: {row["CurrentSubject2"].ToString()}";
                    cs2Lbl.AutoSize = true;

                    Label ps1Lbl = new Label();
                    pan.Controls.Add(ps1Lbl);
                    ps1Lbl.Text = $"PreviousSubject1: {row["PreviousSubject1"].ToString()}";
                    ps1Lbl.AutoSize = true;

                    Label ps2Lbl = new Label();
                    pan.Controls.Add(ps2Lbl);
                    ps2Lbl.Text = $"PreviousSubject2: {row["PreviousSubject2"].ToString()}";
                    ps2Lbl.AutoSize = true;

                    // Set the size of the panel
                    pan.Size = new Size(StudentListPanel.Width -50, 100);

                    // Change the font size of all information labels to 12
                    foreach (Control control in pan.Controls)
                    {
                        Label label = (Label)control;
                        label.Font = new Font(label.Font.FontFamily, 12, label.Font.Style); 
                    }

                    // Add the panel to StudentListPanel
                    StudentListPanel.Controls.Add(pan);
                }

            }
            catch (Exception ex)
            {
                // Handle any error
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        public StudentForm()
        {
            InitializeComponent();

            //Set the title of this form
            this.Text = "Desktop Information System";
            // Add event handler for form closing event
            this.FormClosing += Form_FormClosing;

            // Configure StudentListPanel - a FlowLayoutPanel to group and display student informations
            StudentListPanel.AutoScroll = true;
            StudentListPanel.FlowDirection = FlowDirection.LeftToRight;
        }

        // Event handler for the "Edit Profile" button click
        private void EditProfileButton_Click(object sender, EventArgs e)
        {
            // Open the form for editing user with the current student's ID as parameter, and suspend current form
            var editForm = new EditUserForm(Session.Id);
            editForm.ShowDialog();

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
            if (MessageBox.Show("Are you sure you want to exit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) {
                // If user chose no, cancel closing the form                
                e.Cancel = true;
            } else
            {
                // else, destroy current session and continue closing form
                Session.SessionDestroy();
            }            
        }

        // Event handler for the "Refresh" button click
        private void RefreshBtn_Click_1(object sender, EventArgs e)
        {
            // Refresh the FlowLayoutPanel
            SetupTable();
        }
    }
}