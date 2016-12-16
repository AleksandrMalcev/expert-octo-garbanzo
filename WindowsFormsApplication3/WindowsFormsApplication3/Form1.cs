using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       int timerCounter = 0;
        public int chislo1, chislo2;
        Timer timer = new Timer();
        private void button1_Click(object sender, EventArgs e)
        {
            chislo1 = 0;
            chislo2 = 0;

            int v = Convert.ToInt32(textBox3.Text);
            textBox4.Text = "n";
            Timer timer = new Timer();
            //InitializeComponent();
            timer.Interval = 1000 ; //интервал между срабатываниями секунд
            timer.Tick += new EventHandler(timer_Tick); //подписываемся на события Tick
            timer.Start();
            //textBox4.Text = "15";
        }

        void timer_Tick(object sender, EventArgs e)
        {
            int v = Convert.ToInt32(textBox3.Text);
            ++timerCounter;
            if (timerCounter == v)
            {
                timer.Stop();
                label4.Text = "5";
                label5.Text = "4";
            }
        }
    }
}
