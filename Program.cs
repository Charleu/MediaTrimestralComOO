using System;

namespace MediaTrimestralOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o nome do aluno:");
            string nome = Console.ReadLine();
            Console.WriteLine($"Informe a nota do primeiro trimestre:");
            double nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Informe a nota do segundo trimestre:");
            double nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine($"Informe a nota do terceiro trimestre:");
            double nota3 = double.Parse(Console.ReadLine());

            Aluno aluno = new Aluno(nome, nota1, nota2, nota3);
            Console.WriteLine(aluno);
            aluno.ExibirResultado();
        }
    }
  }