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
            Console.Write("\nDigite 1 para somar \n2 para subtrair \n3 para dividir \n4 para multiplicar \nou 5 para sair....");
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
