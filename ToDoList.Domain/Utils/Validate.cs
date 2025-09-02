namespace Domain.Utils
{
    public class Validate
    {
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
    }
}
