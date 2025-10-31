using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viaja_ja.Models
{
    public class Cliente : Pessoa
    {
        public string Telefone { get; private set; }

        public Cliente(string nome, string cpf, string telefone) : base(nome, cpf) 
        { 
            Telefone = telefone;
        }

        public override string ToString()
        {
            return $"{Nome} ({Cpf}) - Tel: {Telefone}";
        }
    }
}
