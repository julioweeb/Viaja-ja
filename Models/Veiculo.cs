using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viaja_ja.Models
{
    public abstract class Veiculo
    {
        public string Placa { get; private set; }
        public string Modelo { get; private set; }
        public int Ano { get; private set; }
        public decimal ValorDiaria { get; protected set; }
        public bool Disponivel { get; private set; }

        protected Veiculo(string placa, string modelo, int ano, decimal valorDiaria) 
        {
            Placa = placa;
            Modelo = modelo;
            Ano = ano;
            ValorDiaria = valorDiaria;
            Disponivel = true;
        }

        public virtual decimal CalcularValorAluguel(int dias) 
        {
            return ValorDiaria * dias;
        }

        public void Alugar() 
        {
            Disponivel = false;
        }

        public void Devolver() 
        {
            Disponivel = true;
        }

        public override string ToString()
        {
            return $"{Modelo} ({Placa}) - Ano {Ano} - {(Disponivel ? "Disponivel" : "Alugado")}";
        }
    }
}
