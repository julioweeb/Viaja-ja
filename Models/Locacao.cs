using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viaja_ja.Models
{
    public class Locacao
    {
        public Cliente Cliente { get; private set; }
        public Veiculo Veiculo { get; private set; }
        public int Dias { get; private set; }
        public decimal ValorTotal { get; private set; }

        public Locacao(Cliente cliente, Veiculo veiculo, int dias)
        {
            Cliente = cliente;
            Veiculo = veiculo;
            Dias = dias;
            ValorTotal = veiculo.CalcularValorAluguel(dias);
        }

        public override string ToString()
        {
            return $"{Cliente.Nome} alugou {Veiculo.Modelo} por {Dias} dias - Total: R$ {ValorTotal:F2}";
        }
    }
}