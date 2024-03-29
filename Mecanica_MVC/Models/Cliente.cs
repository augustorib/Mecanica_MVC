﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica_MVC.Models
{
    public class Cliente
    {
        public Guid ID { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; set; }

        public string Carro { get; set; }

        public Cliente()
        {

        }
        public Cliente(string nome, string telefone, string email, string carro)
        {
            ID = Guid.NewGuid();
            Nome = nome;
            Telefone = telefone;
            Email = email;
            Carro = carro;
        }
    }
}
