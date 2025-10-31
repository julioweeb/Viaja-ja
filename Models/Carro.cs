using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viaja_ja.Models
{
    public class Carro : Veiculo
    {
        public int NumeroPortas { get; private set; }

        public Carro(string placa, string modelo, int ano, decimal valorDiaria, int numeroPortas) : base(placa, modelo, ano, valorDiaria) 
        {
            NumeroPortas = numeroPortas;
        }

        public override decimal CalcularValorAluguel(int dias)
        {
            decimal valorBase = base.CalcularValorAluguel(dias);
            return valorBase + 50m; // Adiciona uma taxa fixa de R$50,00 para carros
        }

    }
}
