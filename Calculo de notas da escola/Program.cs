using System;

namespace Calculo_de_notas_da_escola
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno n = new Aluno();

            Console.WriteLine("Digite o nome do aluno: ");
            n.Nome = Console.ReadLine();

            Console.WriteLine("Digite as 3 notas do aluno: ");
            n.Nota1 = int.Parse(Console.ReadLine());
                    
            n.Nota2 = int.Parse(Console.ReadLine());
                       
            n.Nota3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Nota final:" + n.Media());

            if (n.Media() >= 60)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram: " + n.Rest());
            }

            
        }
    }
}
