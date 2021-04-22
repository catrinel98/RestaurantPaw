using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yees
{
    
   public class ColectieComenzi:ICloneable
    {
        private List<Comenzi> comenzi;
        public ColectieComenzi()
        {
            comenzi = new List<Comenzi>();
        }


        public ColectieComenzi(List<Comenzi> Lista)
        {
            comenzi = Lista;
        }

        public List<Comenzi> Comenzi { get => comenzi; set => comenzi = value; }

        public object Clone()
        {
            ColectieComenzi colectie = (ColectieComenzi)this.MemberwiseClone();
            List<Comenzi> lista = new List<Comenzi>();
            foreach (Comenzi c in comenzi)
                lista.Add(c);
            colectie.comenzi= lista;
            return colectie;
        }
        public override string ToString()
        {
            string result = "";
            foreach (Comenzi c in comenzi)
            {
                result += c.ToString() + Environment.NewLine;
            }
            return result;
        }
        public static ColectieComenzi operator +(ColectieComenzi c, Comenzi ca)
        {
            c.comenzi.Add(ca);
            return c;
        }

    }
}
