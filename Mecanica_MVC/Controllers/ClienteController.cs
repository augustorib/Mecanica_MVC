using Microsoft.AspNetCore.Mvc;
using Mecanica_MVC.Repository;
using Mecanica_MVC.Data;
using Mecanica_MVC.Models;
using System.Threading.Tasks;

namespace Mecanica_MVC.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteRepository _clienteRepository = null;

        public ClienteController(ClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }


        //public async Task<IActionResult> Index()
        //{
        //   var dados = await _clienteRepository.ListarClientes();

        //    return View(dados);
        //}


        //Testando sem async
        public IActionResult Index()
        {
            var dados = _clienteRepository.ListarClientes();

            return View(dados);
        }
        public IActionResult FormCliente01()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken] // evitar crsf
        public IActionResult AddCliente(Cliente model)
        {
            var cliente = new Cliente(model.Nome, model.Telefone, model.Email, model.Carro);

            _clienteRepository.AdicionarClienteNoBanco(cliente);
            return View("FormCliente01");
        }



        //[HttpPut]
        //public IActionResult AtualizarCliente(ClienteModel model)
        //{
        //    var atualizarCliente = _clienteRepository.BuscarClientePorID(model.ID);

        //    if(atualizarCliente != null)
        //    {
        //        return View(atualizarCliente);
        //    }

        //    return RedirectToAction(nameof(Index));
        //}

        public IActionResult DetalhesCliente(ClienteModel model)
        {
            return View(model);
        }

        public IActionResult AtualizarCliente(ClienteModel model)
        {
            return View(model);
        }


        public IActionResult SalvarClienteAtualizado(ClienteModel model)
        {
            _clienteRepository.AtualizarCliente(model);
           
            return RedirectToAction(nameof(Index));
        }


        public IActionResult DeletarCliente(ClienteModel model)
        {
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RemoverCliente(ClienteModel model)
        {

            _clienteRepository.RemoverCliente(model.ID);
            return RedirectToAction(nameof(Index));
        }



    }
}
