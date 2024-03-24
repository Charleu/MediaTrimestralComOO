using System;

namespace MediaTrimestralOO
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public Aluno(string nome, double nota1, double nota2, double nota3)
        {
            Nome = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public double CalcularNotaFinal()
        {
            return (Nota1 * 30 + Nota2 * 35 + Nota3 * 35) / 100;
        }

        public override string ToString()
        {
            return $"Aluno: {Nome}\n Nota1: {Nota1}\n Nota2: {Nota2}\n Nota3: {Nota3}\n";
        }

        public void ExibirResultado()
        {
            string sep = new string('-', 50);
            double notaFinal = CalcularNotaFinal();
            Console.WriteLine(sep);
            Console.WriteLine($"Nota final de {Nome}: {notaFinal.ToString("F2")}");
            Console.WriteLine(sep);
            if (notaFinal >= 60)
            {
                Console.WriteLine(sep);
                Console.WriteLine("APROVADO!");
                Console.WriteLine(sep);
            }
            else
            {
                double pontosFaltantes = 60 - notaFinal;
                Console.WriteLine(sep);
                Console.WriteLine($"REPROVADO! Faltam {pontosFaltantes.ToString("F2")} pontos para ser aprovado.");
                Console.WriteLine(sep);
            }
        }
    }
}