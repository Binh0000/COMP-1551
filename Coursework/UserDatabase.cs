using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.IO;

namespace Coursework
{
    // Static class containing methods and functionalities manage the user database
    public static class UserDatabase
    {
        //test connectionStr
        //public static string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True";

        // Connection string used to connect to the local database where records of users are saved
        public static string curDir = Directory.GetCurrentDirectory();
        
        public static string connectionString = $"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"{curDir}\\Database1.mdf\";Integrated Security=True";


        //Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename="C:\Users\phian_\Desktop\Greenwich\semester 5\COMP1551-Coursework-001284733\Coursework\Database1.mdf";Integrated Security=True

        // Lists to store instances of different types of users
        public static List<Student> StudentList = new List<Student>();
        public static List<Teacher> TeacherList = new List<Teacher>();
        public static List<Admin> AdminList = new List<Admin>();

        // Static constructor to load the records from the database to the lists when the program is started
        static UserDatabase()
        {
            // Query to retrieve data from the "Person" table
            var query1 = "SELECT * FROM Person";
            // Establishing a connection to the database
            using (var connection = new SqlConnection(connectionString))
            {
                // Opening the connection
                connection.Open();
                // Creating a command to execute the first query
                using (var command = new SqlCommand(query1, connection))
                // Executing the command while creating a reader to iterate over the table's records
                using (var reader = command.ExecuteReader())
                {
                    // Looping through each records
                    while (reader.Read())
                    {
                        // Retrieving fields from the "Person" table
                        string name = (string)reader["Name"];
                        string telephone = (string)reader["Telephone"];
                        string email = (string)reader["Email"];
                        string role = (string)reader["Role"];
                        string password = (string)reader["Password"];

                        // Constructing a query to select from a table corresponding to the user's role
                        var query2 = $"SELECT * FROM {role}";

                        // Establishing a new connection for the second query
                        using (var connection2 = new SqlConnection(connectionString))
                        {
                            // Opening the new connection
                            connection2.Open();

                            // Creating a command to execute the second query
                            using (var command2 = new SqlCommand(query2, connection2))

                            // Executing the command and creating a reader to iterate over the table's records
                            using (var reader2 = command2.ExecuteReader())
                            {
                                // Switching based on the user's role
                                switch (role)
                                {
                                    case "Student":
                                        // If there are still records left
                                        if (reader2.Read())
                                        {
                                            // Retrieve data from the "Student" table
                                            string cs1 = (string)reader2["CurrentSubject1"];
                                            string cs2 = (string)reader2["CurrentSubject2"];
                                            string ps1 = (string)reader2["PreviousSubject1"];
                                            string ps2 = (string)reader2["PreviousSubject2"];

                                            // Create a new Student object with the retrieved data
                                            Student student = new Student(name, telephone, email, Role.Student, password,
                                                (Subject)Enum.Parse(typeof(Subject), cs1),
                                                (Subject)Enum.Parse(typeof(Subject), cs2),
                                                (Subject)Enum.Parse(typeof(Subject), ps1),
                                                (Subject)Enum.Parse(typeof(Subject), ps2)
                                            );
                                            // Adding the Student object to the StudentList
                                            StudentList.Add(student);
                                        }
                                        break;
                                    case "Teacher":
                                        // If there are still records left
                                        if (reader2.Read())
                                        {
                                            // Retrieve data from the "Teacher" table
                                            double teacherSalary = (double)reader2["Salary"];
                                            string subject1 = (string)reader2["Subject1"];
                                            string subject2 = (string)reader2["Subject2"];

                                            // Create a new Teacher object with the retrieved data
                                            var teacher = new Teacher(name, telephone, email, Role.Teacher, password, teacherSalary,
                                                (Subject)Enum.Parse(typeof(Subject), subject1),
                                                (Subject)Enum.Parse(typeof(Subject), subject2)
                                            );

                                            // Adding the Teacher object to the TeacherList
                                            TeacherList.Add(teacher);
                                        }
                                        break;
                                    case "Admin":
                                        // If there are still records left
                                        if (reader2.Read())
                                        {
                                            // Retrieve data from the "Admin" table
                                            double adminSalary = (double)reader2["Salary"];
                                            bool isFullTime = (bool)reader2["IsFullTime"];
                                            TimeSpan start = (TimeSpan)reader2["StartTime"];
                                            TimeSpan end = (TimeSpan)reader2["EndTime"];

                                            // Create a new Admin object with the retrieved data
                                            var a = new Admin(name, telephone, email, Role.Admin, password,
                                                adminSalary, isFullTime, start, end);
                                            // Adding the Admin object to the AdminList
                                            AdminList.Add(a);
                                        }
                                        break;
                                }
                            }
                        }
                    }
                }
            }
        }

        // Method to validate a name using regular expressions
        public static bool IsValidName(string name)
        {
            // Returns false if the string either only contains only whitespace, is empty, or characters that aren't in the alphabet
            return Regex.IsMatch(name, @"^[a-zA-Z\s]+$") && !Regex.IsMatch(name, @"^[\s]*$");
        }

        // Method to validate a phone number using regular expressions
        public static bool IsValidPhoneNumber(string num)
        {
            // Returns false if the string contains characters that aren't numbers from 0 to 9
            return Regex.IsMatch(num, @"^[0-9]+$");
        }

        // Method to validate an email address using regular expressions
        public static bool IsValidEmail(string email)
        {
            // Returns true if the string follows the pattern: (string only containing characters in alphabet and numbers) + @ 
            // + (string only containing characters in alphabet and numbers)
            var pattern = @"^[a-zA-Z0-9.]+@[a-zA-Z0-9.]+$";
            return Regex.IsMatch(email, pattern);
        }

        // Method to validate a password using regular expressions
        public static bool IsValidPassword(string password)
        {
            // Returns true if string length is greater than 5 and does not contain white space, tab, or new line character
            return password.Length >= 5 && !password.Contains(" ") && !password.Contains("\t") && !password.Contains("\n");
        }

        // Method to validate a salary using regular expressions
        public static bool IsValidSalary(string salary)
        {
            // Check if user input is a valid double
            if (!double.TryParse(salary, out double result))
            {
                return false;
            }

            // Check if salary is a non-negative number
            return result >= 0;
        }

        // Method to check for duplicates in a list of strings
        public static bool HasDuplicate(string[] strings)
        {
            // Iterate over the list from parameter
            for (int i = 0; i < strings.Length; i++)
            {
                for (int j = i + 1; j < strings.Length; j++)
                {
                    // Return true if a string has a duplicate
                    if (strings[i] == strings[j]) { return true; }
                }
            }
            return false;
        }
    }
}