using System.Linq;
using Mecanica_MVC.Models;

namespace Mecanica_MVC.Data
{
    public class SeedingServiceCliente
    {
        private readonly SqlContext _context;

        public SeedingServiceCliente(SqlContext context)
        {
            _context = context;
        }

        public void Seed()
        {
            if (_context.Cliente.Any())
            {
                return;
            }

            Cliente cliente  = new Cliente("Adasmastor","8888888",  "Adamastor@gmail.com", "Mitsubishi");
            Cliente cliente2 = new Cliente("Adamastor Retorno", "888778887", "Adamastor@gmail.com", "Mustang");
            Cliente cliente3 = new Cliente("Judit", "22222-2222", "Judit@gmail.com", "CrossFox");
            Cliente cliente4 = new Cliente("Julia", "7777-7777", "Julia@gmail.com", "Fiat");
            Cliente cliente5 = new Cliente("Jurandir", "99999-9999", "jurandir@gmail.com", "Toyota");
            Cliente cliente6 = new Cliente("Nikita", "55555-5555", "nikita@gmail.com", "Mitsubishi");
            Cliente cliente7 = new Cliente("Estevão", "45444544", "estevao@gmail.com", "Toyota");

            _context.Cliente.AddRange(cliente, cliente2, cliente3, cliente4, cliente5, cliente6, cliente7);
            _context.SaveChanges();

        }
    }
}
