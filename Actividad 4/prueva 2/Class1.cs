using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Operacion
{
        // Clase Operaciones
        public class Operaciones
        {
        // Sobrecarga de métodos
        public int Sumar(int a, int b)
        {
            return a + b;
        }

        public double Sumar(double a, double b)
        {
            return a + b;
        }

        public int Restar(int a, int b)
        {
            return a - b;
        }

        public double Restar(double a, double b)
        {
            return a - b;
        }
        // Constructor
        public Form1()
        {
            InitializeComponent();
        }

        // Evento de clic del botón Sumar
        private void btnSumar_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtA.Text);
            int b = Convert.ToInt32(txtB.Text);
            Operaciones oper = new Operaciones();
            int resultado = oper.Sumar(a, b);
            txtResultado.Text = resultado.ToString();
        }

        // Evento de clic del botón Restar
        private void btnRestar_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            Operaciones oper = new Operaciones();
            double resultado = oper.Restar(a, b);
            txtResultado.Text = resultado.ToString();
        }
    }
}
