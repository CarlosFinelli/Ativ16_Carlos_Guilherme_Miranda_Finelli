using System;

namespace QuestaoA
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            inicio:
            Console.Write("Insira a Largura do Retângulo: ");
            retangulo.Largura = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            Console.Write("Insira a Altura do Retângulo: ");
            retangulo.Altura = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            retangulo.Result = retangulo.Altura * retangulo.Largura;
            Console.WriteLine($"Área do retângulo: {retangulo.Result}");
            Console.WriteLine();
            retangulo.Result = 2 * (retangulo.Altura + retangulo.Largura);
            Console.WriteLine($"Perímetro do retângulo: {retangulo.Result}");
            Console.WriteLine();
            retangulo.Result = Math.Sqrt(Math.Pow(retangulo.Altura, 2) + Math.Pow(retangulo.Largura, 2));
            Console.WriteLine($"Diagonal do retângulo: {retangulo.Result}");
            Console.WriteLine();
            Console.WriteLine();
            Console.ReadKey();
            Console.Write("Deseja realizar outro cálculo? (1 = Sim, 2 = Não): ");
            int opcao = Convert.ToInt16(Console.ReadLine());
            if (opcao == 1)
            {
                goto inicio;
            } else
            {
                Console.Clear();
                Console.WriteLine("Obrigado por utilizar o programa.");
                Console.ReadKey();
            }
        }
    }
}
