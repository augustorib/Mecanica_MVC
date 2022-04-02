using Mecanica_MVC.Models;
using System.Collections.Generic;

namespace Mecanica_MVC.Repository
{
    public class ClienteRepository
    {
        public List<Cliente> ListarClientes()
        {
            return DataSource();
        }

        public List<Cliente> DataSource()
        {
            List<Cliente> lista = new List<Cliente>();
            
            var cliente = new Cliente("Jurandir", "99999-9999", "jurandir@gmail.com", "Prisma");
            var cliente2 = new Cliente("Jurandir2", "88888-9999", "jurandir2@gmail.com", "Toyota");
            var cliente3 = new Cliente("Jurandir3", "77777-9999", "jurandir3@gmail.com", "Gol");

            lista.Add(cliente);
            lista.Add(cliente2);
            lista.Add(cliente3);

            return lista;
        }

    }
}
