using System;

namespace QuestaoD
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            Console.Write("Informe o nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.Clear();
            Console.Write("Insira o email do Aluno: ");
            aluno.Email = Console.ReadLine();
            Console.Clear();
            Console.Write("insira a Cidade do aluno: ");
            aluno.Cidade = Console.ReadLine();
            Menu:
            Console.Clear();
            Console.WriteLine("Informações do aluno: ");
            Console.WriteLine();
            Console.WriteLine($"Nome: {aluno.Nome}");
            Console.WriteLine($"Email: {aluno.Email}");
            Console.WriteLine($"Cidade: {aluno.Cidade}");
            Console.WriteLine($"Status: {aluno.Status}");
            Console.WriteLine();
            Console.WriteLine("1 - Alterar email.");
            Console.WriteLine("2 - Alterar Cidade.");
            Console.WriteLine("3 - Sair.");
            Console.WriteLine();
            Console.Write("Escolha uma opção: ");
            int opcao = Convert.ToInt16(Console.ReadLine());
            Console.Clear();
            switch(opcao)
            {
                case 1:
                    Console.Write("Insira o novo email do aluno: ");
                    aluno.Email = Console.ReadLine();
                    if (aluno.Email.Length < 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Email inválido.");
                        Console.ReadKey();
                        Console.Clear();
                        goto case 1;
                    }
                    goto Menu;

                case 2:
                    Console.Write("Insira a nova cidade do aluno: ");
                    aluno.Cidade = Console.ReadLine();
                    if (aluno.Cidade == null || aluno.Cidade.Length < 5)
                    {
                        Console.Clear();
                        Console.WriteLine("Cidade inválida.");
                        Console.ReadKey();
                        Console.Clear();
                        goto case 2;
                    }
                    goto Menu;

                case 3:
                    Console.WriteLine("Obrigado por utilizar nossos serviços.");
                    Console.ReadKey();
                    break;
            }


        }
    }
}
