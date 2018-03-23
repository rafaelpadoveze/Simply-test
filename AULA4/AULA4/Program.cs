using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;//tentativa de abrir o drive

namespace AULA4
{
    class Program
    {
        static double ObterValor()//função usada no codigo
        {
            Console.Write("digite um valor: ");
            double valor;
            valor = Convert.ToDouble(Console.ReadLine());
            return valor;

            //return 0;//precisa retornar algo senão dá erro
        }
        static void Main(string[] args)
        {
            

            /*
            //--------------for-------------------
            int[] numeros = new int[] {5,7,2,6};
            for (int i = 0; i < 20; i++)
            {
                Console.Write(i + " ");
                //Console.WriteLine(numeros[i]);
            }
            Console.WriteLine("\n");
            for (int j = 20; j > 0; j--)
            {
                Console.Write(j + " ");
            }
            //for (int indice = 0; indice < vetor.Lenght; indice++)
            //{
            //    Console.WriteLine(vetkor[indice]);
            //}
            int indice = 1;
            while (indice < numeros.Length)
            {
                if (indice > 2)
                {
                    break;
                }
            }
            */
            //------------------------------------------------------------------------------
            //inicio prog banco-----------------------------------------
            /*
            int opcao;
            decimal saldo = 0;
            decimal temp;
            do
            {
                Console.WriteLine("\n\n\n------------------------------------------");
                Console.WriteLine("| | DIGITE 1 PARA CONSULTAR SEU SALDO   | |");
                Console.WriteLine("| | DIGITE 2 PARA SACAR                 | |");
                Console.WriteLine("| | DIGITE 3 PARA DEPÓSITO              | |");
                Console.WriteLine("| | OU DIGITE 0 PARA SAIR               | |");
                Console.WriteLine("------------------------------------------");
                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.WriteLine("Seu saldo atual é: " + saldo.ToString("C2"));//formatação reais
                    Console.WriteLine("Pressione Enter para continuar.........");
                    Console.ReadLine();
                    Console.Clear();
                }
                else if (opcao == 2)
                {
                    Console.Write("Quanto deseja Retirar?\nR$");
                    temp = Convert.ToInt32(Console.ReadLine());
                    saldo = saldo - temp;
                    Console.WriteLine("seu dinheiro sairá pelo drive de cd abaixo...");

                    //existente em outra versão
                    

                    Console.WriteLine("Pressione Enter para continuar.........");
                    Console.ReadLine();
                    Console.Clear();
                    temp = 0;
                }
                else if (opcao == 3)
                {
                    Console.Write("Informe o valor de deposito... \nR$");
                    temp = Convert.ToInt32(Console.ReadLine());
                    saldo = saldo + temp;
                    Console.WriteLine("Seu dinheiro foi depositado com sucesso!!!");
                    Console.WriteLine("Pressione Enter para continuar.........");
                    Console.ReadLine();
                    Console.Clear();
                    temp = 0;
                }
                else
                {
                    Console.WriteLine("OPÇÂO INVALIDA");
                }
                

            }
            while (opcao != 0);
            Console.WriteLine("OBRIGADO POR UTILIZAR O BANCO DO BRASIL 4.0, AGORA SEU SALDO SERÁ ZERADO");
             * */
            //-------------fim prog banco---------------------------------------------------------------------
            //-------------------------------------------------------------------------------------------
            int opcao = 0;
            double saldo = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("0 - Sair");
                Console.WriteLine("1 - Consultar Saldo");
                Console.WriteLine("2 - Sacar Valor");
                Console.WriteLine("3 - Depositar Valor");

                Console.Write("Opcao: ");

                opcao = Convert.ToInt32(Console.ReadLine());

                if (opcao == 1)
                {
                    // Consultar Saldo
                    Console.WriteLine("Seu saldo atual é: " + saldo.ToString("C2"));
                    Console.ReadLine();
                }
                else if (opcao == 2)
                {
                    double valor;

                    if (saldo == 0)
                    {
                        Console.WriteLine("Saldo insuficiente.");
                        Console.ReadLine();
                        continue;
                    }

                    Console.Write("Informe o valor do saque: ");
                    //valor = Convert.ToDouble(Console.ReadLine());
                    valor = ObterValor();

                    if (saldo < valor)
                    {
                        Console.WriteLine("Saldo insuficiente.");
                        Console.ReadLine();
                        continue;
                    }

                    saldo = saldo - valor;

                    Console.WriteLine("Saque realizado. Novo saldo: " + saldo.ToString("C2"));
                    Console.ReadLine();
                }
                else if (opcao == 3)
                {
                    double valor;

                    Console.Write("Informe o valor do deposito: ");
                    //valor = Convert.ToDouble(Console.ReadLine());
                    valor = ObterValor();

                    if (valor <= 0)
                    {
                        Console.WriteLine("Valor invalido.");
                        Console.ReadLine();
                        continue;
                    }

                    saldo += valor;

                    Console.WriteLine("Deposito realizado. Novo saldo: " + saldo.ToString("C2"));
                    Console.ReadLine();
                }


            } while (opcao != 0);

            Console.ReadLine();
        }
    }
}
