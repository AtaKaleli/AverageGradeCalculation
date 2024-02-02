using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            double midterm1, midterm2, final, ortalama;

            ad = textBox1.Text;
            soyad = textBox2.Text;
            midterm1 = Convert.ToDouble(textBox3.Text);

            midterm2 = Convert.ToDouble(textBox4.Text);

            final = Convert.ToDouble(textBox5.Text);

            ortalama = (midterm1 * 30 / 100 + midterm2 * 30 / 100 + final * 40 / 100);

            listBox1.Items.Add("Ad: " + ad);
            listBox1.Items.Add("Soyad: " + soyad);
            listBox1.Items.Add("Dönem sonu notu: " + ortalama);


        }
    }
}
