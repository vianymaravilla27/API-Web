using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace Web_Api.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<Item> Items { get; set; } = null!;
    }
}
