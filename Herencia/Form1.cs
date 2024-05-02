using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herencia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sumar sumar = new sumar();
            textBox3.Text = sumar.operar(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            restar restar = new restar();
            textBox3.Text = restar.operar(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            multiplicar multiplicar = new multiplicar();
            textBox3.Text = multiplicar.operar(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dividir dividir = new dividir();
            textBox3.Text = dividir.operar(int.Parse(textBox1.Text), int.Parse(textBox2.Text)).ToString();
        }
    }
}
