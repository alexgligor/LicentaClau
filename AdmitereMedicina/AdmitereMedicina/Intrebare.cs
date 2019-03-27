using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmitereMedicina
{
   public class Intrebare
    {
        public string text;
        public string variante;
        public string raspunsCorect;
    public Intrebare(string text,string variante,string raspunsCorect)
        {
          this.text = text;
          this.variante = variante;
          this.raspunsCorect = raspunsCorect;
         }

    }
    
}
