using Mecanica_MVC.Data;
using Mecanica_MVC.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica_MVC.Repository
{  
    public class ClienteRepository
    {
        private readonly SqlContext _context;

        public ClienteRepository(SqlContext context)
        {
            _context = context;
        }

        //Teste de listar clientes com método assincrono
        //public async Task<List<ClienteModel>> ListarClientes()

        //{
        //    var allClientes = new List<ClienteModel>();

        //    var clientes = await _context.Cliente.ToListAsync();

        //    if (clientes?.Any() == true)
        //    {
        //        foreach (var cliente in clientes)
        //        {
        //            var x = new ClienteModel()
        //            {
        //                ID = cliente.ID,
        //                Nome = cliente.Nome,
        //                Telefone = cliente.Telefone,
        //                Email = cliente.Email,
        //                Carro = cliente.Carro
        //            };

        //            allClientes.Add(x);
        //        }
        //    }

        //    return allClientes;

        //}

        //public async Task<List<Cliente>> ListarClientes()
        //{
        //    return await _context.Cliente.OrderBy(cliente => cliente.Nome).ToListAsync();
        //}

        //Testando Listagem sem ser assincrono
        public List<Cliente> ListarClientes()

        {
            var allClientes = new List<Cliente>();

            var clientes = _context.Cliente.ToList();

            if (clientes?.GetType() != null)
            {
                foreach (var cliente in clientes)
                {
                    var x = new Cliente()
                    {
                        ID = cliente.ID,
                        Nome = cliente.Nome,
                        Telefone = cliente.Telefone,
                        Email = cliente.Email,
                        Carro = cliente.Carro
                    };

                    allClientes.Add(x);
                }
            }

            return allClientes;

        }

        public void RemoverCliente(Guid id)
        {
          var removerCliente = _context.Cliente.FirstOrDefault(obj => obj.ID == id);
            
          if(removerCliente != null)
          {
            _context.Cliente.Remove(removerCliente);
            _context.SaveChanges();
          }

        }

        public Cliente BuscarClientePorID(Guid id)
        {
            var buscarCliente = _context.Cliente.FirstOrDefault(obj => obj.ID == id);

            if(buscarCliente != null)
            {
                return buscarCliente;
            }

            return null;
        }

        public void AtualizarCliente(Cliente model)
        {
            var clienteAtualizar = BuscarClientePorID(model.ID);

            clienteAtualizar.Nome = model.Nome;
            clienteAtualizar.Telefone = model.Telefone;
            clienteAtualizar.Email = model.Email;
            clienteAtualizar.Carro = model.Carro;

            _context.Cliente.Update(clienteAtualizar);
            _context.SaveChanges();

        }

        public void AdicionarClienteNoBanco(Cliente novoCliente)
        {
            _context.Cliente.Add(novoCliente);
            _context.SaveChanges();

        }

    }
}
