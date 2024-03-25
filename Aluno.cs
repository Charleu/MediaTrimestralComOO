using System;

namespace MediaTrimestralOO
{
    class Aluno
    {
        private double _nota1;
        private double _nota2;
        private double _nota3;

        public string Nome { get; set; }

        public double Nota1
        {
            get 
            {
                return _nota1;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Nota do primeiro trimestre não pode ser negativa");
                    return;
                }

                _nota1 = value;
            }
        }

        public double Nota2
        {
            get 
            {
                return _nota2;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Nota do segundo trimestre não pode ser negativa");
                    return;
                }

                _nota2 = value;
            }
        }

        public double Nota3
        {
            get 
            { 
                return _nota3; 
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Nota do terceiro trimestre não pode ser negativa");
                    return;
                }

                _nota3 = value;
            }
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