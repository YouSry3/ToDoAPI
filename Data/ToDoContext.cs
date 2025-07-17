using Microsoft.EntityFrameworkCore;
using ToDoApi.Models;
using TodoApplicationAPI.Models;

namespace ToDoApi.Data
{
    public class ToDoContext : DbContext
    {
        public ToDoContext(DbContextOptions<ToDoContext> options)
            : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<ToDoItem> ToDoItems { get; set; }
    }
}
