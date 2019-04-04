using System;

namespace Aula3console
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uma escola de contratou para desenvolver um app que realize a media das notas dos alunos de uma sala ,
            //lembrando que a sala tem 5 alunos e anota vai de 0 a 10.0

            Console.WriteLine("Média de Alunos");

            float soma = 0;
            float media = 0;

            for (int i =0; i <5 ; )
           {
                Console.WriteLine("Digite a nota do aluno" + i + ":");
                float nota = 0;
                float.TryParse(Console.ReadLine(), out nota);
                soma += nota;
            }

            media = soma / 5;
            Console.WriteLine(" A Média é:" + media);

            Console.ReadLine();

        }
    }
}
