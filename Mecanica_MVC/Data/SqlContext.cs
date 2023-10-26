using Microsoft.EntityFrameworkCore;
using Mecanica_MVC.Models;

namespace Mecanica_MVC.Data
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> _context) : base(_context)
        {

        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Funcionario> Funcionario { get; set; }
        public DbSet<Servico> Servico { get; set; }
        public DbSet<ServicosMecanica> ServicosMecanicas { get; set;}
    }
}
