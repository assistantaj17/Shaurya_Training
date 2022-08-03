using Microsoft.EntityFrameworkCore;
using UserService.Entities;

    namespace UsersService.Data
    {
        public class AppDbContext : DbContext
        {
            public DbSet<User> Users { get; set; }
            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            {
                optionsBuilder.UseSqlServer(@"Server=DESKTOP-AGCG1V3\SQLEXPRESS;Database=Shaurya_Training;Integrated Security=True;");
            }
        }
    }


