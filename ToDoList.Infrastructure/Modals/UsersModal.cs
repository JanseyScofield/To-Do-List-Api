using System.Security.Cryptography;

namespace ToDoList.Infrastructure.Modals
{
    public class UsersModal
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";
    }
}
