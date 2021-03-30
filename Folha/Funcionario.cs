using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Folha
{
    class Funcionario
    {
        public string Nome;
        public decimal SalarioBruto;
        public decimal Imposto;

        public decimal SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * ((decimal) porcentagem / 100);
        }

        public override string ToString()
        {
            return Nome + ", $ " + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
