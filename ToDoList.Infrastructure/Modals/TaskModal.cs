namespace ToDoList.Infrastructure.Modals
{
    public class TaskModal
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public DateTime CreatedAt { get; set; } = new();

        public DateTime? FinishAt { get; set; } = new();
        public byte StatusId { get; set; } = new();
        public int UserId { get; set; } = new();
        public UsersModal User { get; set; } = new();
    }
}
