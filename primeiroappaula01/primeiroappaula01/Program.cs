﻿//ATENÇÃO, ESTE É UM SOFTWARE PARA TESTE DE TODO O SISTEMA, O CODIGO FONTE PFOI PASSADO EM AULA PELO PROFESSOR FELIPE ORIANI EM 01/03/2018 NA FACULDADE ANHANGUERA DE PIRACICABA
//ESTE SOFTWARE NÃO POSSUI O INTUITO DE TER UMA CONTINUAÇÃO, E APENAS PARA APRENDIZADO

// ][EN]ATTENTION, THIS IS A SOFTWARE FOR TESTING THE WHOLE SYSTEM, THE SOURCE CODE WAS DONE IN A CLASSROOM BY TEACHER FELIPE ORIANI ON 03/03/2018 AT THE ANHANGUERA COLLEGE OF PIRACICABA
// THIS SOFTWARE DOES NOT HAVE THE INTUIT TO HAVE A CONTINUATION, AND JUST FOR LEARNING

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//primeira aula 1-3-18
//professor felipe Oriani


namespace primeiroappaula01
{
    class Program
    {
        static void Main(string[] args)
        {
            // tipos primitivos 
            /*int i;
            long inteirolongo;

            string texto;
            char caracteres;

            double numeros;
            decimal nfinanceiros;

            bool booleanos;
            */
            //---->conversoes -->Convert.
            //--------------------------------
            int n1, n2, res, ope;
            Console.Write("Digite os dois numeros a serem usados: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("outro numero: ");
            n2 = int.Parse(Console.ReadLine());
            Console.Write("\nDigite 1 para somar \n2 para subtrair \n3 para multiplicar \n4 para dividir \nou 5 para sair....");
            ope = int.Parse(Console.ReadLine());
            if (ope == 1)
            {
                res = (n1 + n2);
                Console.Write("O resultado da soma é: \n" + res);

            }
            else if (ope == 2)
            {
                res = (n1 - n2);
                Console.Write("O resultado da subtração é: \n" + res);

            }
            else if (ope == 3)
            {
                res = (n1 * n2);
                Console.Write("O resultado da multiplicação é: \n" + res);

            }
            else if (ope == 4)
            {
                res = (n1 / n2);
                Console.Write("O resultado da divisão é: \n" + res);

            }
            else
            {
                Console.Write("\n\nSaindo ....");
                Environment.Exit(-1);
            }
            
            

            //Console.Write(nome + " " + sobrenome);

            Console.ReadLine();

        }
    }
}
