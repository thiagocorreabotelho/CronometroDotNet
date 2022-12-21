using System;
using System.Threading;

namespace CronometroDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            


            Console.WriteLine("------ SEJA BEM VINDO(A) AO NOSSO CRONÔMETRO .NET CORE ------");
            Console.WriteLine();
            Console.WriteLine("SELECIONE ABAIXO O QUE VOCÊ DESEJA FAZER!");
            Console.WriteLine("LEMBRANDO QUE VOCÊ DEVE INFORMAR O TEMPO MAIS O TIPO EXEMPLO: 10S OU 10M");
            Console.WriteLine();
            Console.WriteLine("S = SEGUNDOS");
            Console.WriteLine("M = MINUTOS");
            Console.WriteLine("0 = SAIR");
            Console.WriteLine("QUANTO TEMPO DESEJA CONTAR?");

            string valorDigitado = Console.ReadLine().ToLower();
            char tipo = char.Parse(valorDigitado.Substring(valorDigitado.Length - 1, 1));
            int tempo = int.Parse(valorDigitado.Substring(0, valorDigitado.Length - 1));
            int multiplicacao = 1;

            if (tipo == 'm')
                multiplicacao = 60;

            if (tempo == 0)
                System.Environment.Exit(0);

            Calculo((tempo * multiplicacao));
        }

        static void Calculo(int tempo)
        {
            int meuTempo = 0;

            while (meuTempo != tempo)
            {
                Console.Clear();
                meuTempo++;
                Console.WriteLine(meuTempo);
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("Fim");
            Thread.Sleep(2500);
            Menu();
        }
    }
}
