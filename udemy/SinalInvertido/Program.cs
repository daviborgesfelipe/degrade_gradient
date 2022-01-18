using System;

namespace SinalInvertido
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int resultado;

            Console.Write("Digite um numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            resultado = numero * -1;

            Console.WriteLine($"Resultado: {resultado}");
        }
    }
}
