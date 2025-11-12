using Microsoft.EntityFrameworkCore;
using Makand.Models;

namespace Makand.Data
{
    public class MakandContext: DbContext
    {
        public MakandContext(DbContextOptions<MakandContext> options) : base(options) { }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
