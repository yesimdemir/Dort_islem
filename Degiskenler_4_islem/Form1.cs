﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_4_islem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1, sayi2, toplam, fark, carpim, bolum;
            sayi1 = Convert.ToInt32(textBox1.Text);
            sayi2 = Convert.ToInt32(textBox2.Text);
            toplam = sayi1 + sayi2;
            fark = (Math.Abs(sayi1 - sayi2));
            carpim = sayi1 * sayi2;
            bolum = sayi1 / sayi2;
            MessageBox.Show("Toplam: " + toplam + "\n" + "Fark: " + fark + "\n" + "Çarpım: " + carpim + "\n" + "Bölüm: " + bolum);
        }
    }
}
