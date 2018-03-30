using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AULA55
{
    public class lampada
    {
        private bool acesa;

        public lampada()//constructor
        {
            acesa = false;
        }
        public void Acender()
        {
            if (acesa == false)
                acesa = true;
        }
        public void Apagar()
        {
            if (acesa == true)
                acesa = false;
        }
        public bool EstaAcesa()
        {
            return acesa;
        }
    }
}
