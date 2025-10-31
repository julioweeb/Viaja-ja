using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viaja_ja.Models
{
    public abstract class Pessoa
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }

        protected Pessoa(string nome, string cpf) 
        {
            Nome = nome;
            Cpf = cpf;
        }
    }
}
