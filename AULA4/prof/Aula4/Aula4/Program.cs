using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4
{
    class Program
    {
        /*
         Construa um programa console para a gestão de uma conta bancária:
            Apresente um menu com as opções (utilize um switch / case):
                0 – Sair
                    Encerre o programa.
                1 – Consultar Saldo
                    Apresente um saldo em conta;
                2 – Sacar valor;
                    Pergunte o valor do saque;
                    Se o valor for menor que o disponível em saldo, não permita o saque;
                    Senão, subtrai-o o valor no saldo;
                3 – Depositar valor;
                    Pergunte o valor do depósito e some-o no saldo;             
        */

        static void Main(string[] args)
        {
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
                    valor = Convert.ToDouble(Console.ReadLine());

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
                    valor = Convert.ToDouble(Console.ReadLine());

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
            
        }
    }
}
