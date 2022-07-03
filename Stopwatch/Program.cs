using System;

namespace Stopwatch
{
    class Program
    {
        static void Main()
        {
            Menu();
        }

        //Menu function
        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("S - Segundos => 10s = 10 segundos" +
                              "\nM - Minutos => 1m = 1 minuto" +
                              "\n0 - Sair");
            Console.WriteLine("Quanto tempo deseja contar? ");

            string data = Console.ReadLine().ToLower();
            char type = char.Parse(data.Substring(data.Length -1, 1));
            int time = int.Parse(data.Substring(0, data.Length - 1));

            int multiplier = 1;

            if (type == 'm')
                multiplier = 60;

            if(time == 0)
                System.Environment.Exit(0);

            Start(time * multiplier);
        }

        //Função de cronometro
        static void Start(int time)
        {
            var currentTime = 0;

            while (currentTime != time)
            {
                Console.Clear();
                currentTime++;
                Console.WriteLine(currentTime.ToString());
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Stopwatch finalizado!");
            Thread.Sleep(2000);
            Menu();
        }
    }
}
