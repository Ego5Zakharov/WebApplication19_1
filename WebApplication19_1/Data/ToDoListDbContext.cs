using Microsoft.EntityFrameworkCore;
using WebApplication19_1.Models;

namespace WebApplication19_1.Data
{
    public class ToDoListDbContext:DbContext
    {
        public DbSet<ToDoList> ToDoLists { get; set; }
        public ToDoListDbContext(DbContextOptions<ToDoListDbContext> options ):base(options)
        {

        }

    }
}
