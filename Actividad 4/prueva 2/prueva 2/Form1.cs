using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueva_2
{
    public partial class Form1 : Form 
    {

        public Form1()
        {
            InitializeComponent();
        }
        Operaciones2 x = new Operaciones2();
        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            Operaciones2 oper = new Operaciones2();
            double resultado = oper.Sumar(a, b);
            txtResultado.Text = resultado.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            Operaciones2 oper = new Operaciones2();
            double resultado = oper.Restar(a, b);
            txtResultado.Text = resultado.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
