
using Microsoft.EntityFrameworkCore;
using AllatOrokbefogadas.API.Models;

namespace AllatOrokbefogadas.API.Data
{
    public class AllatDbContext : DbContext
    {
        public AllatDbContext(DbContextOptions<AllatDbContext> options)
            : base(options)
        {
        }

        public DbSet<Allat> Allatok { get; set; }
    }
}
