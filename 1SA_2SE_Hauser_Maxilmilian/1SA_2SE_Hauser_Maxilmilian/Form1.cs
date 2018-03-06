using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1SA_2SE_Hauser_Maxilmilian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Auto Auto1 = new Auto();

        private void Aktual(object sender, EventArgs e)
        {
            textBox7.Text = "Marke: " + textBox1.Text + Environment.NewLine + "Farbe: " + comboBox1.Text + Environment.NewLine + "PS: " + textBox2.Text + Environment.NewLine + "Tankgröße: " + textBox3.Text + Environment.NewLine + "Verbrauch: " + textBox4.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Auto1.Erstellen(textBox1.Text,comboBox1.Text,textBox2.Text,textBox3.Text,textBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.Value = Auto1.Tanken(textBox5.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            progressBar1.Value = Auto1.Fahren(textBox6.Text);
        }

    }

    public class Auto
    {
        private string Marke, Farbe;
        private int PS, TG, V, th;

        public void Erstellen(string M,string F,string P,string T, string Ver)
        {
            Marke = M;
            Farbe = F;
            if(P!="")
            PS = Convert.ToInt32(P);
            if (T != "")
            TG = Convert.ToInt32(T);
            if (Ver != "")
            V = Convert.ToInt32(Ver);
        }

        public int Tanken(string t)
        {
            int r;
            th = th + Convert.ToInt32(t);
            r = (th*100)/TG;
            if (r > 100)
            {
                r = 100;
            }
            return r;
        }

        public int Fahren(string t)
        {
            int r;
            th = th - Convert.ToInt32(t)*V;
            r = (th * 100) / TG;
            return r;
        }
    }
    }

