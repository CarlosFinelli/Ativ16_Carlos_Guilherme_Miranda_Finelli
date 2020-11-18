using System;

namespace QuestaoB
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Produto produto = new Produto();
            Console.Write("Insira o nome do produto: ");
            produto.Nome = Console.ReadLine();
            Console.Clear();
            Console.Write("Insira o Preço do produto: ");
            produto.Preco = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira a quantidade desse produto: ");
            produto.Quantidade = Convert.ToInt16(Console.ReadLine());
        Menu:
            Console.Clear();
            Console.WriteLine($"Nome do produto: {produto.Nome}");
            Console.WriteLine($"Preço do produto: {produto.Preco}");
            Console.WriteLine($"Quantidade em estoque: {produto.Quantidade}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("1 - Alterar Preço.");
            Console.WriteLine("2 - Adicionar produto.");
            Console.WriteLine("3 - Remover produto.");
            Console.WriteLine("4 - Valor total em estoque.");
            Console.WriteLine("5 - Finalizar programa.");
            Console.WriteLine();
            Console.Write("Selecione uma opção: ");
            opcao = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            switch(opcao)
            {
                case 1:
                    Console.Write("Insira o novo preço do produto: ");
                    produto.setPreco = Convert.ToDouble(Console.ReadLine());
                    goto Menu;

                case 2:
                    Console.Write("Insira a quantidade que irá adicionar ao produto: ");
                    produto.AdicionarProduto = Convert.ToInt16(Console.ReadLine());
                    goto Menu;

                case 3:
                    Console.Write("Insira a quantidade que irá remover do produto: ");
                    produto.RemoverProdutos = Convert.ToInt16(Console.ReadLine());
                    goto Menu;

                case 4:
                    Console.WriteLine($"Valor total em estoque: {produto.ValorTotalEmEstoque}");
                    Console.ReadKey();
                    goto Menu;

                case 5:
                    Console.WriteLine("Obrigado por utilizar nossos serviços.");
                    Console.ReadKey();
                    break;

            }
        }
    }
}
