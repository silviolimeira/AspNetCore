using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Media
{
    class Aluno
    {
        public string Nome;
        public double[] Notas;
        private double Notafinal;

        public Aluno()
        {
            Notas = new double[3];
        }

        public void CalculaNotaFinal()
        {
            Notafinal = Notas[0] + Notas[1] + Notas[2];
        }

        public void MostraNotaFinal()
        {
            Console.WriteLine("NOTA FINAL = " + Notafinal.ToString("F2", CultureInfo.InvariantCulture));
            if (Notafinal < 60.0)
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM {0} PONTOS", (60.0 - Notafinal).ToString("F2", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("APROVADO");
            }
        }
    }
}
