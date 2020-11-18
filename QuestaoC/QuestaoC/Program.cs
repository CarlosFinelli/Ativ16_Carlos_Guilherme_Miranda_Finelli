using System;

namespace QuestaoC
{
    class Program
    {
        static void Main(string[] args)
        {
            Professor professor = new Professor();
            Console.Write("Insira o nome do Professor: ");
            professor.Nome = Console.ReadLine();
            Console.Clear();
            Console.Write("Insira o sobrenome do professor: ");
            professor.Sobrenome = Console.ReadLine();
            Console.Clear();
            Console.Write("Insira o telefone do professor: ");
            professor.Telefone = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.Write("O professor usa óculos? (true = sim, false = não): ");
            professor.Oculos = Convert.ToBoolean(Console.ReadLine());
            Menu:
            Console.Clear();
            Console.WriteLine("Informações do professor: ");
            Console.WriteLine();
            Console.WriteLine($"Nome: {professor.Nome}");
            Console.WriteLine($"Sobrenome: {professor.Sobrenome}");
            Console.WriteLine($"Telefone: {professor.Telefone}");
            Console.WriteLine($"Usa óculos: {professor.Oculos}");
            Console.WriteLine();
            Console.WriteLine("1 - Alterar telefone.");
            Console.WriteLine("2 - Alterar uso de óculos.");
            Console.WriteLine("3 - Sair do programa.");
            Console.WriteLine();
            Console.Write("Selecione uma opção: ");
            int opcao = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch(opcao)
            {
                case 1:
                    Console.Write("Insira o novo telefone do professor: ");
                    professor.Telefone = Convert.ToInt32(Console.ReadLine());
                    goto Menu;

                case 2:
                    Console.Write("Informe se o professor usa óculos (true = sim, false = não): ");
                    professor.Oculos = Convert.ToBoolean(Console.ReadLine());
                    goto Menu;

                case 3:
                    Console.WriteLine("Obrigado por utilizar nossos serviços.");
                    Console.ReadKey();
                    break;
            }

        }
    }
}
