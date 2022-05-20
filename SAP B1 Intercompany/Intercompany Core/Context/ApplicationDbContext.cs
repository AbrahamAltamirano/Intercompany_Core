using Microsoft.EntityFrameworkCore;
using Intercompany_Core;
using Intercompany_Core.Entities;

namespace Intercompany_Core
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Transaccion> Transaccion { get; set; }
    }
}
