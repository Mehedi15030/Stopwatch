using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatchApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int hour, min, sec , ms = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            ms = 0;
            min = 0;
            sec = 0;
            hour = 0;
            label1.Text = 0 + ":" + 0 + ":" + 0 + ":" + 0.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = hour+":"+min +":"+sec+ ":"+ms.ToString();
            ms++;
            if (ms > 10)
            {
                sec++;
                ms = 0;
            }
            else
            {
                ms++;
            }
            if (sec > 60)
            {
                min++;
                sec = 0;
            }
            if (min > 60)
            {
                hour++;
                min = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
