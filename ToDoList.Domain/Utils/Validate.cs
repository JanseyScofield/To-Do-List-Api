using System.Text.RegularExpressions;

namespace Domain.Utils
{
    public class Validate
    {
        private static Regex _emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        private static Regex _passwordRegex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");

        public static void ValidateIntId(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Id must be greater than zero.");
            }
        }

        public static void ValidateName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be null or empty.");
            }

            if(name.Length > 100)
            {
                throw new ArgumentException("Name must be between 1 and 100 characters.");
            }
        }

        public static void ValidateDescription(string description)
        {
            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentException("Description cannot be null or empty.");
            }
        }

        public static void ValidateEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ArgumentException("Email cannot be null or empty.");
            }

            if (!_emailRegex.IsMatch(email))
            {
                throw new ArgumentException("Email format is invalid.");
            }
        }

        public static void ValidatePassword(string password) {
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentException("Password cannot be null or empty.");
            }
            if (_passwordRegex.IsMatch(password))
            {
                throw new ArgumentException("Password must be at least 8 characters long, contain at least one letter, one number, and one special character.");
            }
        }
    }
}
