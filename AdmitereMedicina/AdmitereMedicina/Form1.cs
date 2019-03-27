using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdmitereMedicina
{
    public partial class Form1 : Form
    {
        private Intrebare intrebare;
        private GeneratorIntrebari generatorIntrebari;
        private int intrebariCorecte = 0;
        private int intrebariGresite = 0;
        private object listaIntrebari;

        public Form1()
        {
            InitializeComponent();
            generatorIntrebari = new GeneratorIntrebari();
            IncarcaVarianta();
           

        }
        private void IncarcaVarianta()
        {
            intrebare = generatorIntrebari.GetIntrebare();

            continutIntrebare.Text = intrebare.text;
            varianteRaspuns.Text = intrebare.variante;

            ReimprospatareInterfata();
        }

        private void buttonRaspunde_Click(object sender, EventArgs e)
        {

            string raspunsulUtilizatorului = "";
            if (raspunsA.BackColor == Color.OrangeRed)
            {
                raspunsulUtilizatorului += "A";
            }

            if (raspunsB.BackColor == Color.OrangeRed)
            {
                raspunsulUtilizatorului += "B";
            }

            if (raspunsC.BackColor == Color.OrangeRed)
            {
                raspunsulUtilizatorului += "C";
            }

            if (raspunsD.BackColor == Color.OrangeRed)
            {
                raspunsulUtilizatorului += "D";
            }

            if (raspunsE.BackColor == Color.OrangeRed)
            {
                raspunsulUtilizatorului += "E";
            }
            if(raspunsulUtilizatorului == intrebare.raspunsCorect)
            {
                intrebariCorecte++;
            }
            else
            {
                intrebariGresite++;
            }


            IncarcaVarianta();
        }

        private void buttonUrmatorul_Click(object sender, EventArgs e)
        {
            IncarcaVarianta();
        }
        private void ReimprospatareInterfata()
        {
            if (intrebariGresite + intrebariCorecte >= generatorIntrebari.GetNumarIntrebari())
            {
                MessageBox.Show("Intrebari corecte: " + intrebariCorecte + " Intrebari gresite: " + intrebariGresite, "Test Finalizat");
                //Salvare istoric rezultate. 
                SalvareRezultate();

                intrebariCorecte = 0;
                intrebariGresite = 0;
               
            }
            raspunsA.BackColor = Color.FromArgb(224, 224, 224);
            raspunsB.BackColor = Color.FromArgb(224, 224, 224);
            raspunsC.BackColor = Color.FromArgb(224, 224, 224);
            raspunsD.BackColor = Color.FromArgb(224, 224, 224);
            raspunsE.BackColor = Color.FromArgb(224, 224, 224);
            statusIntrebariCorecte.Text = "Corecte:" + intrebariCorecte;
            statusIntrebariGresite.Text = "Gresite: " + intrebariGresite;

            
            
            statusIntrebariRamase.Text = "Intrebari ramase: " +(intrebariGresite+intrebariCorecte+1)+"/"+ generatorIntrebari.GetNumarIntrebari();

        }
        private void SalvareRezultate()
        {
            string numeFisier = "Istoric.txt";

            File.AppendAllText(numeFisier, DateTime.Now.ToString() + " - Intrebari corecte: " + intrebariCorecte + " Intrebari gresite: " + intrebariGresite + Environment.NewLine);
        }

        private void raspunsA_Click(object sender, EventArgs e)
        {
            ApasareButon(raspunsA);
        }
        private void ApasareButon(Button button)
        {

            if (button.BackColor == Color.OrangeRed)
            {
                button.BackColor = Color.Coral;
            }
            else
            {
                button.BackColor = Color.OrangeRed;
            }
        }

        private void raspunsB_Click(object sender, EventArgs e)
        {
            ApasareButon(raspunsB);
        }

        private void raspunsC_Click(object sender, EventArgs e)
        {
            ApasareButon(raspunsC);
        }

        private void raspunsD_Click(object sender, EventArgs e)
        {
            ApasareButon(raspunsD);
        }

        private void raspunsE_Click(object sender, EventArgs e)
        {
            ApasareButon(raspunsE);
        }
    }
       
}
