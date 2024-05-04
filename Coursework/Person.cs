using System;
using System.Data.SqlClient;

namespace Coursework
{
    // Enum defining user roles
    public enum Role
    {
        Teacher,
        Admin,
        Student,
    }

    // Enum defining school subjects
    public enum Subject
    {
        Mathematics,
        Physics,
        Chemistry,
        Biology,
        English,
        History,
        Geography,
        ComputerScience,
        Economics,
        Psychology,
        Sociology,
        Art,
        Music,
        PhysicalEducation,
        ForeignLanguage,
        Literature,
        Philosophy,
    }

    // Abstract base class for all persons
    public abstract class Person
    {
        // Properties for common attributes that all persons have
        public string Name { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public Role UserRole { get; set; }
        public string Password { get; set; }

        // Constructor to initialize attributes
        protected Person(string name, string telephone, string email, Role userRole, string password)
        {
            Name = name;
            Telephone = telephone;
            Email = email;
            UserRole = userRole;
            Password = password;
        }

        // Method to add a person with common attributes to the database 
        // Has a protected modifier so that only classes derived from Person can use
        protected int AddPersonToDatabase() {
            // SQL query to insert a person into database and retrieve the generated ID
            string addPersonQuery = "INSERT INTO Person (Name, Telephone, Email, Role, Password) VALUES (@Name, @Telephone, @Email, @Role, @Password); SELECT SCOPE_IDENTITY();";

            // Establishing a connection to the database
            using (SqlConnection connection = new SqlConnection(UserDatabase.connectionString))
            using (SqlCommand command = new SqlCommand(addPersonQuery, connection))
            {
                connection.Open();
                // Setting parameters for the SQL command
                command.Parameters.AddWithValue("@Name", this.Name);
                command.Parameters.AddWithValue("@Telephone", this.Telephone);
                command.Parameters.AddWithValue("@Email", this.Email);
                command.Parameters.AddWithValue("@Role", this.UserRole.ToString());
                command.Parameters.AddWithValue("@Password", this.Password);

                // Executing the command and retrieving the generated ID
                int personId = Convert.ToInt32(command.ExecuteScalar());

                // Returning the generated ID
                return personId;
            }
        }

        // Abstract method to be implemented by subclasses
        public abstract void AddToDatabase();

        // Method to update a person's common attributes in the database
        protected void UpdatePersonToDatabase(int personId, string name, string telephone, string email, string password)
        {
            // Updating person attributes
            Name = name;
            Telephone = telephone;
            Email = email;
            Password = password;

            // SQL query to update person
            string updateQuery = "UPDATE Person SET Name = @Name, Telephone = @Telephone, Email = @Email, Password = @Password WHERE Id = @Id";

            // Establishing a connection to the database
            using (var connection = new SqlConnection(UserDatabase.connectionString))
            using (var command = new SqlCommand(updateQuery, connection))
            {
                connection.Open();

                // Setting parameters for the SQL command
                command.Parameters.AddWithValue("@Name", name);
                command.Parameters.AddWithValue("@Telephone", telephone);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);
                command.Parameters.AddWithValue("@Id", personId);

                // Executing the command to update person details
                command.ExecuteNonQuery();
            }
        }
    }

    // Student class inheriting from Person
    public class Student : Person
    {
        // Properties for attributes specific to students
        public Subject CurrentSubject1 { get; set; }
        public Subject CurrentSubject2 { get; set; }
        public Subject PreviousSubject1 { get; set; }
        public Subject PreviousSubject2 { get; set; }

        // Constructor to initialize student attributes
        public Student(string name, string telephone, string email, Role userRole, string password,
            Subject currentSubject1, Subject currentSubject2, Subject previousSubject1, Subject previousSubject2)
            : base(name, telephone, email, userRole, password)
        {
            CurrentSubject1 = currentSubject1;
            CurrentSubject2 = currentSubject2;
            PreviousSubject1 = previousSubject1;
            PreviousSubject2 = previousSubject2;
        }

        // Method to add a student to the database
        public override void AddToDatabase()
        {
            // Adding a corresponding person to the database and getting the generated ID
            int personId = this.AddPersonToDatabase();

            // SQL query to insert a student into database
            string addStudentQuery = "INSERT INTO Student (CurrentSubject1, CurrentSubject2, PreviousSubject1, PreviousSubject2, Person_Id) VALUES (@CurrentSubject1, @CurrentSubject2, @PreviousSubject1, @PreviousSubject2, @Person_Id)";
            using (SqlConnection connection = new SqlConnection(UserDatabase.connectionString))
            using (SqlCommand command = new SqlCommand(addStudentQuery, connection))
            {
                connection.Open();
                // Setting parameters for the SQL command
                command.Parameters.AddWithValue("@CurrentSubject1", this.CurrentSubject1.ToString());
                command.Parameters.AddWithValue("@CurrentSubject2", this.CurrentSubject2.ToString());
                command.Parameters.AddWithValue("@PreviousSubject1", this.PreviousSubject1.ToString());
                command.Parameters.AddWithValue("@PreviousSubject2", this.PreviousSubject2.ToString());
                command.Parameters.AddWithValue("@Person_Id", personId);
                // Executing the command to insert student details
                command.ExecuteNonQuery();
            }
        }

        // Method to update student details in the database
        public void UpdateToDatabase(int personId, string name, string telephone, string email, string password,
            string currentSubject1, string currentSubject2, string previousSubject1, string previousSubject2)
        {
            // Updating the corresponding person details
            UpdatePersonToDatabase(personId, name, telephone, email, password);

            // SQL query to update student details
            string updateQuery = "UPDATE Student SET CurrentSubject1 = @CurrentSubject1, CurrentSubject2 = @CurrentSubject2," +
                                    "PreviousSubject1 = @PreviousSubject1, PreviousSubject2 = @PreviousSubject2 " +
                                    "WHERE Person_Id = @Id";

            // Establishing a connection to the database
            using (var connection = new SqlConnection(UserDatabase.connectionString))
            using (var command = new SqlCommand(updateQuery, connection))
            {
                connection.Open();
                // Setting parameters for the SQL command
                command.Parameters.AddWithValue("@CurrentSubject1", currentSubject1.ToString());
                command.Parameters.AddWithValue("@CurrentSubject2", currentSubject2.ToString());
                command.Parameters.AddWithValue("@PreviousSubject1", previousSubject1.ToString());
                command.Parameters.AddWithValue("@PreviousSubject2", previousSubject2.ToString());
                command.Parameters.AddWithValue("@Id", personId);
                // Executing the command to update student details
                command.ExecuteNonQuery();
            }
        }
    }

    // Teacher class inheriting from Person
    public class Teacher : Person
    {
        // Properties for attributes specific to teachers
        public double Salary { get; set; }
        public Subject Subject1 { get; set; }
        public Subject Subject2 { get; set; }

        // Constructor to initialize teacher attributes
        public Teacher(string name, string telephone, string email, Role userRole, string password,
            double salary, Subject subject1, Subject subject2) : base(name, telephone, email, userRole, password)
        {
            Salary = salary;
            Subject1 = subject1;
            Subject2 = subject2;
        }

        // Method to add a teacher to the database
        public override void AddToDatabase()
        {
            // Adding a corresponding person to the database and getting the generated ID
            int personId = this.AddPersonToDatabase();

            // SQL query to insert a teacher into database
            string addTeacherQuery = "INSERT INTO Teacher (Salary, Subject1, Subject2, Person_Id) VALUES (@Salary, @Subject1, @Subject2, @Person_Id)";
            using (SqlConnection connection = new SqlConnection(UserDatabase.connectionString))
            using (SqlCommand command = new SqlCommand(addTeacherQuery, connection))
            {
                connection.Open();
                // Setting parameters for the SQL command
                command.Parameters.AddWithValue("@Salary", this.Salary);
                command.Parameters.AddWithValue("@Subject1", this.Subject1.ToString());
                command.Parameters.AddWithValue("@Subject2", this.Subject2.ToString());
                command.Parameters.AddWithValue("@Person_Id", personId);
                // Executing the command to insert student details
                command.ExecuteNonQuery();
            }
        }

        // Method to update teacher details in the database
        public void UpdateToDatabase(int personId, string name, string telephone, string email, string password,
            double salary, Subject subject1, Subject subject2)
        {
            // Updating the corresponding person details
            UpdatePersonToDatabase(personId, name, telephone, email, password);

            // SQL query to update teacher details
            string updateQuery = "UPDATE Teacher SET Salary = @Salary, Subject1 = @Subject1," +
                "Subject2 = @Subject2 WHERE Person_Id = @Id";

            // Establishing a connection to the database
            using (var connection = new SqlConnection(UserDatabase.connectionString))
            using (var command = new SqlCommand(updateQuery, connection))
            {
                connection.Open();
                // Setting parameters for the SQL command
                command.Parameters.AddWithValue("@Salary", salary);
                command.Parameters.AddWithValue("@Subject1", subject1.ToString());
                command.Parameters.AddWithValue("@Subject2", subject2.ToString());
                command.Parameters.AddWithValue("@Id", personId);

                // Executing the command to update teacher details
                command.ExecuteNonQuery();                
            }
        }
    }

    // Admin class inheriting from Person
    public class Admin : Person
    {
        // Properties for attributes specific to teachers
        public double Salary { get; set; }
        public bool IsFullTime { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        // Constructor to initialize admin attributes
        public Admin(string name, string telephone, string email, Role userRole, string password,
            double salary, bool isFullTime, TimeSpan startTime, TimeSpan endTime) : base(name, telephone, email, userRole, password)
        {
            Salary = salary;
            IsFullTime = isFullTime;
            StartTime = startTime;
            EndTime = endTime;
        }

        // Method to add an admin to the database
        public override void AddToDatabase()
        {
            // Adding a corresponding person to the database and getting the generated ID
            int personId = this.AddPersonToDatabase();

            // SQL query to insert a teacher into database
            var addAdminQuery = "INSERT INTO Admin (Salary, IsFullTime, StartTime, EndTime, Person_Id) VALUES (@Salary, @IsFullTime, @StartTime, @EndTime, @Person_Id)";
            using (SqlConnection connection = new SqlConnection(UserDatabase.connectionString))
            using (SqlCommand command = new SqlCommand(addAdminQuery, connection))
            {
                connection.Open();

                // Setting parameters for the SQL command
                command.Parameters.AddWithValue("@Salary", this.Salary);
                command.Parameters.AddWithValue("@IsFullTime", this.IsFullTime);
                command.Parameters.AddWithValue("@StartTime", this.StartTime);
                command.Parameters.AddWithValue("@EndTime", this.EndTime);
                command.Parameters.AddWithValue("@Person_Id", personId);
                // Executing the command to insert student details
                command.ExecuteNonQuery();
            }
        }

        // Method to update admin details in the database
        public void UpdateToDatabase(int personId, string name, string telephone, string email, string password,
            double salary, bool isFullTime, TimeSpan startTime, TimeSpan endTime)
        {
            // Updating the corresponding person details
            UpdatePersonToDatabase(personId, name, telephone, email, password);

            // SQL query to update admin details
            string updateQuery = "UPDATE Admin SET Salary = @Salary, IsFullTime = @IsFullTime," +
                                    "StartTime = @StartTime, EndTime = @EndTime WHERE Person_Id = @Id";

            // Establishing a connection to the database
            using (var connection = new SqlConnection(UserDatabase.connectionString))
            using (var command = new SqlCommand(updateQuery, connection))
            {
                connection.Open();
                // Setting parameters for the SQL command
                command.Parameters.AddWithValue("@Salary", salary);
                command.Parameters.AddWithValue("@IsFullTime", isFullTime);
                command.Parameters.AddWithValue("@StartTime", startTime);
                command.Parameters.AddWithValue("@EndTime", endTime);
                command.Parameters.AddWithValue("@Id", personId);

                // Executing the command to update admin details
                command.ExecuteNonQuery();                
            }
        }
    }
}
