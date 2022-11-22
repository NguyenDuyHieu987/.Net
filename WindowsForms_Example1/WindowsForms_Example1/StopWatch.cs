using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Example1
{
    public partial class StopWatch : Form
    {
        int Seconds, Minute, Tick, Hour;
        bool isActive;
        public StopWatch()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            isActive = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            isActive = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(isActive)
            {
                Tick++;
                if (Tick == 100)
                {
                    Seconds++;
                    Tick = 0;
                    if (Seconds == 60)
                    {
                        Minute++;
                        Seconds = 0;
                        if (Minute == 60)
                        {
                            Hour++;
                            Minute = 0;
                        }
                    }      
                }
            }

            DrawTime();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            isActive = false;

            ResetTime();
        }
        Example1 ex;
        private void btnShow_Click(object sender, EventArgs e)
        {
            ex = new Example1();
            ex.Show();
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            
            ex.Visible = false ;
        }

        private void ResetTime()
        {
            Hour = 0;
            Seconds = 0;
            Minute = 0;
            Tick = 0;
        }

        private void DrawTime()
        {
            lbTick.Text = String.Format("{0:00}", Tick);
            lbSeconds.Text = String.Format("{0:00}", Seconds);
            lbMinute.Text = String.Format("{0:00}", Minute);
            lbMinute.Text = String.Format("{0:00}", Hour);
        }
        private void StopWatch_Load(object sender, EventArgs e)
        {
            isActive = false;
            ResetTime();
        }
    }
}
