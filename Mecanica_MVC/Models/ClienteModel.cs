using System;

namespace Mecanica_MVC.Models
{
    public class ClienteModel
    {
        public Guid ID { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string Carro { get; set; }

    }
}
