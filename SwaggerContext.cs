using Microsoft.EntityFrameworkCore;

namespace SwaggerDemo
{
    public class SwaggerContext : DbContext
    {
        public DbSet<Item> Items { get; set; }

        public SwaggerContext(DbContextOptions<SwaggerContext> options)
            : base(options)
        {
        }
    }
}