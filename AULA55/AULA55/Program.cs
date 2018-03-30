using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA55
{
    class Program
    {
        static void Main(string[] args)
        {
            lampada l1 = new lampada();//cria o objeto
            Console.WriteLine(l1.EstaAcesa());
            l1.Acender();
            Console.WriteLine(l1.EstaAcesa());
            l1.Apagar();
            Console.WriteLine(l1.EstaAcesa());







            Console.ReadLine();
        }
    }
}
