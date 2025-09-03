using Domain.Interfaces;
using Domain.Enums;

namespace Domain.Entities
{
    public class Tasks : IIdentifyEntity<int>
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
        public string Description { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime? FinishAt { get; private set; }
        public Status Status { get; private set; }
        public Users User { get; private set; }

        public Tasks(string name, string description, Status status, Users user)
        {
            Validate(name, description);
            Name = name;
            Description = description;
            CreatedAt = DateTime.Now;
            Status = status;
            User = user;
        }

        public void Update(string name, string description, Status status)
        {
            Validate(name, description);
            Name = name;
            Description = description;
            Status = status;
            if (Status == Status.Finished)
            {
                FinishAt = DateTime.Now;
            }
        }

        private void Validate(string name, string description)
        {
            Utils.Validate.ValidateName(name);
            Utils.Validate.ValidateDescription(description);
        }
    }
}
