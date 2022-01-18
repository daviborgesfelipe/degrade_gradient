using System;

namespace ExercicioDivisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Exercicio Divisao ###");
            
            float dividendo;
            float divisor;
            float quociente;

            Console.Write("Digite o dividendo: ");
            dividendo = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite o divisor: ");
            divisor = Convert.ToSingle(Console.ReadLine());

            quociente = dividendo / divisor;

            Console.Write($"Quociente: {quociente}");
        }
            
    }
}