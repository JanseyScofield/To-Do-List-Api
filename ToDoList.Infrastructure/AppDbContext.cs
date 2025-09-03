using Microsoft.EntityFrameworkCore;
using ToDoList.Infrastructure.Modals;

namespace ToDoList.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<TaskModal> Tasks { get; set; }
        public DbSet<UsersModal> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TaskModal>(entity =>
            {
                entity.ToTable("Tasks");
                entity.HasKey(t => t.Id);

                entity.HasOne(t => t.User)
                  .WithMany()
                  .HasForeignKey(t => t.UserId)
                  .OnDelete(DeleteBehavior.Cascade);
            });

            modelBuilder.Entity<UsersModal>(entity =>
            {
                entity.ToTable("Users");
                entity.HasKey(u => u.Id);
            });
        }
    }
}
