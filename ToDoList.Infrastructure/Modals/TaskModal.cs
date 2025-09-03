using Domain.Interfaces;
using Domain.Entities;

namespace ToDoList.Infrastructure.Modals
{
    public class TaskModal : IModal<Tasks, int>
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public DateTime CreatedAt { get; set; } = new();
        public DateTime? FinishAt { get; set; } = new();
        public byte StatusId { get; set; } = new();
        public int UserId { get; set; } = new();
        public UsersModal User { get; set; } = new();

        public void ConvertDomainToModel(Tasks entity)
        {
            Id = entity.Id;
            Name = entity.Name;
            Description = entity.Description;
            CreatedAt = entity.CreatedAt;
            FinishAt = entity.FinishAt;
            StatusId = (byte)entity.Status;
            UserId = entity.User.Id;
            User.ConvertDomainToModel(entity.User);
        }
    }
}
