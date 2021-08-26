using System;
using System.Globalization;

namespace produtos
{
    class produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionaProduto(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoveProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome +", $"+Preco.ToString("F2", CultureInfo.InvariantCulture)+", "+Quantidade+" unidades, e "+ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture)+" de valor total";
        }
    }
}
