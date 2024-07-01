using System;
using System.Threading;

namespace Crono
{
    class Program
    {

        static void Main(string[] args)
        {

            Menu();
            //Não posso esquecer de declara funções fora de main aqui, caso contrário elas não serão executadas.

        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S = 10 Segundos");
            Console.WriteLine("M = 1 Minuto");
            Console.WriteLine("0 = Sair");
            Console.WriteLine("Quanto tempo deseja contar?");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length - 1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;


            if (type == 'm')
            {
                multiplier = 60;
            }

            if (time == 0)
            {
                System.Environment.Exit(8);
            }

            PreStart(time * multiplier);

        }

        static void PreStart(int time)
        {
            Console.Clear();
            Console.WriteLine("Ready...");
            Thread.Sleep(1000);
            Console.WriteLine("Set...");
            Thread.Sleep(1000);
            Console.WriteLine("Go...");
            Thread.Sleep(2500);

            Start(time);

        }
        static void Start(int time)
        {
            int currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime);
                // Se pararmos o código aqui, ele irá rodar, mas nenhum resultado aparecerá no terminal devido a capacidade de processamento do computador. Para resolver essa stuação, teremos que pedir que ele espere um segundo para responder:
                Thread.Sleep(1000);
            }

            Console.WriteLine("Cronômetro finalizado. Voltando para o menu...");
            Thread.Sleep(2500);

            Menu();
        }
    }

}
