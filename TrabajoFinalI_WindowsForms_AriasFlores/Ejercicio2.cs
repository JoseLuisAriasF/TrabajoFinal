using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinalI_WindowsForms_AriasFlores
{
    public partial class Ejercicio2 : Form
    {
        
        public Ejercicio2()
        {
            InitializeComponent();
        }
        double retiro=0;

        private void btnretiro_Click(object sender, EventArgs e)
        {
            double centimos;
            
            double cerodiez=0,ceroveinte=0,cerocincuenta=0,uno=0,dos=0,cinco=0;
            int doscientos = 0, cien = 0, cincuenta = 0, veinte = 0, diez = 0;
         //   int retiro;

            retiro = Convert.ToDouble(txtretiro.Text);

            centimos = retiro - Math.Round(retiro);
         
            txtretiroc.Text = centimos.ToString();

            // retiro=Math.Round(retiro);
            //calculo numero de billetes de 200 soles 115.5
            /*
            doscientos = Math.Round( retiro)/ 200;
            retiro = Math.Round( retiro - (doscientos * 200)); */
            
            //calculo numero de billetes de 100 soles

            cien = Convert.ToInt32(retiro) / 100;
            retiro = Math.Round(retiro - (cien * 100));
          

            //calculo numero de billetes de 50 soles
            cincuenta = Convert.ToInt32(retiro) / 50;
            retiro = Math.Round( retiro - (cincuenta * 50));
           
            //calculo numero de billetes de 20 soles
            veinte = Convert.ToInt32( retiro) / 20;
            retiro = Math.Round(retiro - (veinte * 20));

            //calculo numero de billetes de 10 soles
            diez = Convert.ToInt32(retiro) / 10;
            retiro = Math.Round( retiro - (diez * 10));
            //MONEDAS 
            /*
            cien = Convert.ToInt32(retiro) / 100;
            retiro = Math.Round(retiro - (cien * 100)); */


            cinco = Convert.ToInt32(retiro) / 5;
            retiro = Math.Round(retiro- (cinco * 5));

            dos = Convert.ToInt32(retiro) / 2;
            retiro = Math.Round( retiro - (dos * 2));

            uno = Convert.ToInt32(retiro) / 1;
            retiro = Math.Round( retiro- (uno * 1));

            cerocincuenta = Convert.ToInt32(retiro) / 1/2;
            retiro =Math.Round(retiro - (cerocincuenta * 1/2));

            if (doscientos>0)
            {
                lbdoscientos.Text = doscientos.ToString();
            }

            if (cien>0)
            {
                lbcien.Text = cien.ToString();
            }

            if (cincuenta > 0)
            {
                lbcinc.Text = cincuenta.ToString();
            }

            if (veinte > 0)
            {
                lbvien.Text= veinte.ToString();
            }
            if (diez > 0)
            {
                lbdiez.Text = diez.ToString();
            }

            if (cinco > 0)
            {
                lbcinco.Text = cinco.ToString();
            }
            if (dos > 0)
            {
                lbdos.Text = dos.ToString();
            }

            if (uno > 0)
            {
                lbuno.Text = uno.ToString();
            }

            if (cerocincuenta > 0)
            {
                lbcerocincuenta.Text = cerocincuenta.ToString();
            }

            if (ceroveinte > 0)
            {
                lbcerodos.Text = ceroveinte.ToString();
            }

            if (cerodiez > 0)
            {
                lbcerouno.Text = cerodiez.ToString();
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            retiro = 0;
        }
    }
}
