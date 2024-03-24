﻿using System;

namespace MediaTrimestralOO
{
    class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public Aluno(string nome)
        {
            Nome = nome;
        }

        public void InformarNotas(double nota1, double nota2, double nota3)
        {
            string sep = new string('-', 50);
            Console.WriteLine(sep);
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
        }

        public double CalcularNotaFinal()
        {
            return (Nota1 * 30 + Nota2 * 35 + Nota3 * 35) / 100;
        }

        public void ExibirResultado()
        {
            string sep = new string('-', 50);
            double notaFinal = CalcularNotaFinal();
           
            Console.WriteLine($"Nota final de {Nome}: {notaFinal.ToString("F2")}");
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