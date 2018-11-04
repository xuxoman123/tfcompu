using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeoriaDeJuegos
{
    public class CPersona
    {
        public int Credito { set; get; }

        


        public CPersona(int credito)
        {
            Credito = credito;
            
        }

        public void set_credito(int kredito) { Credito = kredito; }
    }
}
