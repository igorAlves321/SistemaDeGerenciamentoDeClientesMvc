using Microsoft.EntityFrameworkCore;
using SistemaDeGerenciamentoDeClientesMvc.Models;

namespace SistemaDeGerenciamentoDeClientesMvc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
