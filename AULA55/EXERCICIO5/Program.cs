using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXERCICIO5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("insira a quantidade de itens: ");
            int q = Convert.ToInt32(Console.ReadLine());//declara e já le

            int[] quantidades = new int[q];
            decimal[] precos = new decimal[q];

            for (int i = 0; i < q; i++)
            {
                Console.Write("quantidade do produto" + i + ": ");
                int qtdade = Convert.ToInt32(Console.ReadLine());

                Console.Write("Preço do produto " + i + ": ");
                decimal preco = Convert.ToInt32(Console.ReadLine());

                quantidades[i] = qtdade;
                precos[i] = preco;

            }
            for (int i = 0; i < q; i++)
            {
                decimal subtotal = quantidades[i] * precos[i];
                Console.WriteLine("itens: " + i + ", Quantidade: " +quantidades[i]+ ", Preço: " +precos[i]+ ", Subtotal: " + subtotal);
                Console.Read();

            }
        }
    }
}
