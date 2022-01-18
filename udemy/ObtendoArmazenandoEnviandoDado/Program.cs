using System;

namespace ObtendoArmazenandoEnviandoDado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do professor: ");
            var nomeProfessor = Console.ReadLine();
            var nomeProfessorMaiusculo = nomeProfessor.ToUpper();
            Console.WriteLine($"O nome do professor é {nomeProfessorMaiusculo}");
        }
    }
}
