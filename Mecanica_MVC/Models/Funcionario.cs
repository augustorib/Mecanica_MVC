using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mecanica_MVC.Models
{
    public class Funcionario
    {
        public Guid ID { get; set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public int Matricula  { get; set; }

        public string Cargo { get; set; }

        public DateTime DataAdmissao { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(string nome, string telefone, int matricula, string cargo)
        {
            ID = Guid.NewGuid();
            Nome = nome;
            Telefone = telefone;
            Matricula = matricula;
            Cargo = cargo;
        }
    }
}
