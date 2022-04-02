using Microsoft.AspNetCore.Mvc;
using Mecanica_MVC.Repository;

namespace Mecanica_MVC.Controllers
{ 
    public class ClienteController : Controller
    {
        private readonly ClienteRepository _clienteRepository = null;
        
        public ClienteController()
        {
            _clienteRepository = new ClienteRepository();
        }
        public IActionResult Index()
        {
 

            return View(_clienteRepository.DataSource());
        }

        public IActionResult AddCliente()
        {
            return View();
        }
    }
}
