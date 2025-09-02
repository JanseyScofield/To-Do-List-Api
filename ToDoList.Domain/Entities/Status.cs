using Domain.Interfaces;

namespace Domain.Entities
{
    public class Status : IIdentifyEntity<int>
    {
        private int _id;

        public int Id
        {
            get => _id;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Id must be greater than zero.");
                }
                _id = value; 
            }
        }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public Status(string name, string description)
        {
            Validate(name, description);
            Name = name;
            Description = description;
        }

        private void Validate(string name, string description)
        {
            Utils.Validate.ValidateName(name);
            Utils.Validate.ValidateDescription(description);
        }
    }
}
