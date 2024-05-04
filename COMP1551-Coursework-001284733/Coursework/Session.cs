namespace Coursework
{
    // Class for storing the data of the user account that is logged in on the system
    public static class Session
    {
        // private static variables for storing the current user's data
        private static int id;
        private static string name;
        private static string email;
        private static string password;
        private static Role role;

        // Public static property for 'id'
        public static int Id
        {
            get { return id; }
            set { id = value; }
        }

        // Public static property for 'name'
        public static string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Public static property for 'email'
        public static string Email
        {
            get { return email; }
            set { email = value; }
        }

        // Public static property for 'password'
        public static string Password
        {
            get { return password; }
            set { password = value; }
        }

        // Public static property for 'role'
        public static Role Role
        {
            get { return role; }
            set { role = value; }
        }

        // Method for clearing this session's data
        public static void SessionDestroy()
        {
            // Set fields to default values or null
            id = 0; 
            name = null; 
            email = null; 
            password = null; 
            role = default(Role);
        }

        // Method for adding user's data to this session
        public static void SessionSetup(int id, string name, string email, string password, Role role)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Role = role;
        }
    }
}
