using System;
using System.Globalization;

namespace Construtores
{
    class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }

        // operação Valor Total em Estoque
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        // essa operação nao retorna um valor de saída, ao contrário, ela adiciona a variavel uma quantidade
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        // Sobreposição
        public override string ToString()
        {
            // Transformar um produto em string
            // Quando o objeto é colocado dentro de um Console.WriteLine, ele vai chamar o método TToString e faz a conversão
            return Nome + ", $ " + Preco.ToString("F2", CultureInfo.InvariantCulture)
                    + ", "
                    + Quantidade
                    + " unidades, Total: $ "
                    + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
