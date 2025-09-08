using Domain.Interfaces;
using Domain.Entities;

namespace ToDoList.Infrastructure.Models
{
    public class UsersModel : IModel<Users, int>
    {
        public int Id { get; set; } = 0;
        public string Name { get; set; } = "";
        public string Email { get; set; } = "";
        public string Password { get; set; } = "";

        public void ConvertDomainToModel(Users entity)
        {
            Id = entity.Id;
            Name = entity.Name;
            Email = entity.Email;
            Password = entity.Password;
        }
    }
}
