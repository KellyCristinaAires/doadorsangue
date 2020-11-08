using System;

namespace maior2numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;

            Console.WriteLine("<<----Doação de sangue---->>");

            Console.Write("Qual é o seu nome? ");
            nome = Console.ReadLine();

            Console.WriteLine("Qual sua idade? ");
            idade = int.Parse(Console.ReadLine());

            if (idade >= 18 && idade <= 67)
            {
               Console.WriteLine($"{nome}, você pode ser doador de sangue!");
            }
            else
            {
               Console.WriteLine($"{nome}, você não pode ser doador de sangue!");
               Console.WriteLine("Pressione Enter para sair");
               Console.ReadKey();
            }
        }
    }
}
