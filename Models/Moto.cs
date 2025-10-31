using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Viaja_ja.Models
{
    public class Moto : Veiculo
    {
        public int Cilindrada { get; private set; }

        public Moto(string placa, string modelo, int ano, decimal valorDiaria, int cilindrada) : base(placa, modelo, ano, valorDiaria) 
        {
            Cilindrada = cilindrada;
        }

        public override decimal CalcularValorAluguel(int dias)
        {
            decimal valorBase = base.CalcularValorAluguel(dias);
            return valorBase + 0.9m; // Moto tem desconto de 10%
        }

    }
}