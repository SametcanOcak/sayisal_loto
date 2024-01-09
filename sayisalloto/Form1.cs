using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sayisalloto
{
    public partial class Form1 : Form
    {
        int sayı;
        int b;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Enabled = false;
            timer2.Interval = 1000;
            timer2.Enabled = false;
            label8.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            button1.Enabled = false;
            timer2.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random a = new Random();
            sayı = a.Next(1, 49);
            textBox1.Text = sayı.ToString();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            b++;
            label8.Text = b.ToString();
            if (b == 5)
                label1.Text = sayı.ToString();
            if (b == 10)
                label2.Text = sayı.ToString();
            if (b == 15)
                label3.Text = sayı.ToString();
            if (b == 20)
                label4.Text = sayı.ToString();
            if (b == 25)
                label5.Text = sayı.ToString();
            if (b == 30)
                label6.Text = sayı.ToString();
            if (b == 35)
            {
                label7.Text = sayı.ToString();


                timer2.Enabled = false;
                timer1.Enabled = false;
                MessageBox.Show("SAYISAL LOTO ÇEKİLİŞİMİZ SONA ERMİŞTİR !!! KAZANAN NUMARALAR AŞAĞIDA BELİRTİLMİŞTİR !!!");
            }
        }

        
    }
}
