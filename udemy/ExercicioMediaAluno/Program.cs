using System;

namespace ExercicioMediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("### Media Aritimetica do Aluno ###");
            
            float m1;
            float m2;
            float m3;
            float media;

            Console.Write("Digite primeira nota: ");
            m1 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite segunda nota: ");
            m2 = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite terceira nota: ");
            m3 = Convert.ToSingle(Console.ReadLine());
 
            media = (m1 + m2 + m3) / 3;

            Console.WriteLine($"Media do aluno: {media}");
        }
    }
}
