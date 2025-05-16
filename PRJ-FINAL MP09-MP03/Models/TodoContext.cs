using Microsoft.EntityFrameworkCore;
using PRJ_FINAL_MP09_MP03.Models;

namespace PRJ_FINAL_MP09_MP03.Data
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options) : base(options) { }

        public DbSet<TodoItem> TodoItems { get; set; }
        public DbSet<User> Users { get; set; } // Agregar DbSet para la tabla de usuarios

        public DbSet<Playlist> Playlists { get; set; }

        public DbSet<ApiKey> ApiKeys { get; set; }

        

    }
}