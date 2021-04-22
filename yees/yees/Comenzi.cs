using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yees
{
    [Serializable]
     public class Comenzi
    {
        private int pret;
        private int cantitate;
        private string numeclient;
        public Comenzi(int p, int c, string nc)
        {
            pret = p;
            cantitate = c;
            numeclient= nc;
        }

        public int Pret { get => pret; set => pret = value; }
        public int Cantitate { get => cantitate; set => cantitate = value; }
        public string Numeclient { get => numeclient; set => numeclient = value; }


        public override string ToString()
        {
            return "Clientul  " + numeclient + "  a comandat  " + "\t" + cantitate + " produse la pretul " + "\t" + pret;
    }
    }

   
}

   
