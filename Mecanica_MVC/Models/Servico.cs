using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica_MVC.Models
{
    public class Servico
    {
        public Guid ID { get; set; }

        public string Tipo { get; set; }

        public DateTime Data { get; set; }

        public double Preco { get; set; }

        public string FuncionarioServico { get; set; }

        public string CarroServico { get; set; }

        public Servico()
        {

        }

        public Servico(string tipo, double preco, string funcionarioServico, string carroServico)
        {
            ID = Guid.NewGuid();
            Data = DateTime.Now;
            Tipo = tipo;
            Preco = preco;
            FuncionarioServico = funcionarioServico;
            CarroServico = carroServico;
        }
    }
}
