using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoriaDeJuegos
{
    class CComputadora
    {
        public int CreditoBot { set; get; }

        public CComputadora(int credito)
        {
            CreditoBot = credito;

        }

        public void set_credito(int kredito) { CreditoBot = kredito; }
    }
}
