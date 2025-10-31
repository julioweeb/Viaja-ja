

using Viaja_ja.Models;

namespace Viaja_ja
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Locação de Veiculos - Iniciando...");

            Carro carro = new Carro("XML-1722", "FOX", 2004, 150, 4);
            Moto moto = new Moto("ABC-9076", "F950", 2020, 180, 150);

            Console.WriteLine(carro);
            Console.WriteLine(moto);

            Console.ReadKey();
        }
    }
}