using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using PRJ_FINAL_MP09_MP03.Data;

namespace PRJ_FINAL_MP09_MP03.Models // o .Data si está ahí
{
    public class TodoContextFactory : IDesignTimeDbContextFactory<TodoContext>
    {
        public TodoContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TodoContext>();
            optionsBuilder.UseSqlite("DataSource=todo.db");

            return new TodoContext(optionsBuilder.Options);
        }
    }
}
