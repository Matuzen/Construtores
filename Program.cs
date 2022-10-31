using System;
using System.Globalization;

namespace Construtores
{
    class Program
    {
        static void Main(string[] args)
        {

            // Primeiro é declarado as variáveis que vão receber o que o usuário digitar
            // Depois ela será jogada na classe onde o atributo vai recebê-las

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());

            // Depois de declarar as variáveis, faça a instanciação do construtor

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();

            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");

            // ler a quantidade do usuário
            int qte = int.Parse(Console.ReadLine());
            // acrescentar essa quantidade no produto p
            // chamar a operação AdicionarProdutos()
            p.AdicionarProdutos(qte);

            Console.WriteLine("Dados atualizados: " + p);

            Console.WriteLine("Digite a quantidade a ser removidos do estoque: ");

            // ler a quantidade do usuário
            qte = int.Parse(Console.ReadLine());
            // acrescentar essa quantidade no produto p
            // chamar a operação AdicionarProdutos()
            p.RemoverProdutos(qte);
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}
