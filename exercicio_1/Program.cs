using System;

namespace exercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine();
            Console.WriteLine("Qual o ano atual ? ");
            int anoatual = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("Em qual ano nasceu? ");
            int anonascimento = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int idade = anoatual - anonascimento;

            if (idade >= 18) {Console.WriteLine("Você pode votar este ano ! ");} 
            
            else {Console.WriteLine("Você não pode votar este ano ! ");}
        }
    }
}
