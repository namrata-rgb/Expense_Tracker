using Microsoft.EntityFrameworkCore;

namespace first_api.Models
{
    public class AppDbContext: DbContext
    {
        internal readonly object Expense;

        public AppDbContext(DbContextOptions options): base(options) { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Expense> Expenses { get; set; }
    }
}
