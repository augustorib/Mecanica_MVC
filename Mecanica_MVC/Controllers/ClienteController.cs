using Microsoft.AspNetCore.Mvc;
using Mecanica_MVC.Repository;
using Mecanica_MVC.Data;
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
            var dados =  _clienteRepository.ListarClientes();

            return View(dados);
        }
        public IActionResult FormCliente01()
        {
            return View();

        }

        [HttpPost]
        public IActionResult AddCliente(Cliente model)
        {
            var cliente = new Cliente(model.Nome, model.Telefone, model.Email, model.Carro);

            _clienteRepository.AdicionarClienteNoBanco(cliente);
            return View("FormCliente01");
        }
    }
}
