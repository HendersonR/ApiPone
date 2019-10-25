using Microsoft.EntityFrameworkCore;

namespace ApiPone.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options)
        {
        }

        public DbSet<TodoContext> TodoItems { get; set; }
    }
}
}