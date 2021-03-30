using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Exercicio05
{
    class Produto
    {
        public string Nome;
        public decimal Preco;
        public float Quantidade;

        public decimal ValorTotalEmEstoque()
        {
            return Preco * (decimal)Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome +
                ", $ " +
                Preco.ToString("F2", CultureInfo.InvariantCulture) +
                ", " + Quantidade +
                " unidades, Total: $ " 
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
