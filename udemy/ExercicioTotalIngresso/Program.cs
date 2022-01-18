using System;

namespace ExercicioTotalIngresso
{
    class Program
    {
        static void Main(string[] args)
        {   
            int quantidade;
            decimal valorTotal;

            Console.Write("Digite o numero de ingresso desejado: ");
            quantidade = Convert.ToInt32(Console.ReadLine());

            valorTotal = quantidade * 59.90M;

            Console.Write($"Valor total do(s) {quantidade} ingresso(s) e de R${valorTotal}.");

        }
    }
}
