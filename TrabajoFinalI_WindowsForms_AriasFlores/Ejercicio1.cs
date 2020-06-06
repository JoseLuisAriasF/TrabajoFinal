using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics; //stopwtch
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinalI_WindowsForms_AriasFlores
{
    public partial class Ejercicio1 : Form
    {
        int milisegundos=0;
        int segundos;
        int minutos;
        int horas;
        public Ejercicio1()
        {
            InitializeComponent();
        }
        int i;
        private void btniniciar_Click(object sender, EventArgs e)
        {
           
                timer1.Enabled=true;
           
           
            
        }
        Stopwatch stopWatch = new Stopwatch();
        private void timer1_Tick(object sender, EventArgs e)
        {
            stopWatch.Start();
            if (stopWatch.IsRunning)
            {
             

                TimeSpan ts = stopWatch.Elapsed;
                lbhora.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:000}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 1);

            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
         //   stopWatch.Stop();
            lbhora.Text = "00:00:00:00";
            stopWatch.Reset();
          //  btnLap.Visible = false;
        }

        private void btniniciar_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}
