﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula2
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime agora = DateTime.Now;
            agora = agora.AddDays(5);
          
            Console.WriteLine(agora.Day);
            Console.WriteLine(agora.Month);
            Console.WriteLine(agora.Year);

            Console.WriteLine(agora.Hour);
            Console.WriteLine(agora.Minute);
            Console.WriteLine(agora.Second);

            TimeSpan tempo = new TimeSpan(2, 42, 14);
            //tempo.Ticks
            TimeSpan TEMPO2 = new TimeSpan(1, 0, 14);

            TimeSpan TEMPO3 = tempo + TEMPO2;
            Console.WriteLine(TEMPO3.Hours);
            Console.WriteLine(TEMPO3.Minutes);
            Console.WriteLine(TEMPO3.Seconds);

            //Console.WriteLine("00101010100100100100101001010100101010");
            //-------------PRIMEIRA PARTE DA AULA---------------
            /*Console.WriteLine("----Nome completo----\n digite o primeiro nome: ");
            string pnome = Console.ReadLine();
            Console.WriteLine("Digite o segundo nome: ");
            string segnome = Console.ReadLine();
            Console.WriteLine("Digite o terceiro nome: ");
            string thenome = Console.ReadLine();
            Console.WriteLine(pnome + " " + segnome + " " + thenome);
            */
            Console.ReadLine();

        }
    }
}
