using System.Xml.Linq;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class Users : IIdentifyEntity<int>
    {
        private int _id;

        public int Id
        {
            get => _id;
            set
            {
                Utils.Validate.ValidateIntId(value);
                _id = value;
            }
        }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }

        public Users(string name, string email, string password)
        {
            Validate(name, email, password);
            Name = name;
            Email = email;
            Password = password;
        }

        public void Update(string name, string email, string password)
        {
            Validate(name, email, password);
            Name = name;
            Email = email;
            Password = password;
        }

        private void Validate(string name, string email, string password)
        {
            Utils.Validate.ValidateName(name);
            Utils.Validate.ValidateEmail(email);
            Utils.Validate.ValidatePassword(password);
        }
    }
}
