using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdmitereMedicina
{
   public class GeneratorIntrebari
    {
        int indicatorIntrebare = 0;
        List<Intrebare> listaIntrebari = new List<Intrebare>();
        private void IncarcaIntrebari()
        {
            Intrebare intrebare1 = new Intrebare("Pozitia anatomica de referinta a corpului uman desemneaza corpul in : ", "A. Ortostatism" + Environment.NewLine
                                 + "B. Pe spate" + Environment.NewLine
                                 + "C. Decubit Dorsal" + Environment.NewLine
                                 + "D. Decubit lateral drept" + Environment.NewLine
                                 + "E. Decubit ventral", "A");
            Intrebare intrebare2 = new Intrebare("Pozitia anatomica de referinta a corpului uman desemneaza corpul in : ", "A. statism" + Environment.NewLine
                                 + "B. Ortostatism" + Environment.NewLine
                                 + "C. Decubit Dorsal" + Environment.NewLine
                                 + "D. Decubit lateral drept" + Environment.NewLine
                                 + "E. Decubit ventral", "B");

            listaIntrebari.Add(intrebare1);
            listaIntrebari.Add(intrebare2);


        }
        private void IncarcaIntrebariDinFisier()
        {
            var Text = File.ReadAllLines(@"C:\Users\H232112\Desktop\Clau\Med.txt", Encoding.UTF8);
            for (int i = 0; i < Text.Length; i++)
            {
                
                string linie = Text[i];
                var procesarelinie = linie.Split('@');
                var variante = procesarelinie[1].Split('|');
                string formatareVariante = "";
                for(int j=0;j<variante.Length;j++)
                {
                    formatareVariante += variante[j] + Environment.NewLine;
                }
           
               
                Intrebare intrebareNoua = new Intrebare(procesarelinie[0],formatareVariante,procesarelinie[2]);
                listaIntrebari.Add(intrebareNoua);
            }
        }
        public GeneratorIntrebari()
        {
            IncarcaIntrebari();
            IncarcaIntrebariDinFisier();
        }
        public Intrebare GetIntrebare()
        {
            Intrebare intrebaredetrimis = listaIntrebari[indicatorIntrebare];
            indicatorIntrebare++;
            if(indicatorIntrebare >=listaIntrebari.Count)
            {
                indicatorIntrebare = 0;
            }
            return intrebaredetrimis;
      
        }
        public int GetNumarIntrebari()
        {
            return listaIntrebari.Count;
        }


    }
}
