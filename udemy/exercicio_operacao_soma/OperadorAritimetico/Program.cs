using System;

namespace OperadorAritimetico
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("### Soma de Numeros ###");
            Console.Write("Digite um numero: ");
            int parcelaA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite outro numero: ");
            int parcelaB = Convert.ToInt32(Console.ReadLine());

            int soma = parcelaA + parcelaB;

            Console.WriteLine($"Resultado: {soma}");
        }
    }
}
