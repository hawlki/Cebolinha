using System;

namespace Cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Beep();

            Console.WriteLine("-----------------------------");
            Console.WriteLine("Etec Adolpho Berezin");
            Console.WriteLine("Feito por Israel Camilo Lopes");
            Console.WriteLine("1I3");
            Console.WriteLine("-----------------------------");

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.Write("Por favor, digite alguma coisa que tenha o uso da letra \"R\": ");
            String algumaCoisa = Console.ReadLine();
            algumaCoisa = algumaCoisa.Replace("r","l").Replace("rr","l");
            algumaCoisa = algumaCoisa.Replace("R","L").Replace("RR","L");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("clique em uma tecla para continuar");
            Console.ReadKey();
            Console.WriteLine("----------------------------------------------");

            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Veja como uma pessoa com dislaila falaria: ");
            Console.WriteLine($"{algumaCoisa}");
            Console.ResetColor();
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("clique em uma tela para encerrar este programa");
            Console.ReadKey();
            
            Console.Clear();
        }
    }
}
