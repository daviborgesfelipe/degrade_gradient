using System;

namespace ExercicioOperacaoDivisao
{
    class Program
    {
        static void Main(string[] args)
        {
               
            Console.WriteLine("### Divisao de Numeros ###");
            Console.Write("Digite o dividendo: ");
            int dividendo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quociente = dividendo / divisor;

            int resto = dividendo % divisor;

            Console.WriteLine($"Quociente da divisao é igual á: {quociente}. O Resto da divisao é igual á: {resto}");
        }
    }
}
