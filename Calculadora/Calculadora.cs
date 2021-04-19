using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operador;

        public Calculadora() => InitializeComponent();

        Suma s = new Suma();
        Resta r = new Resta();
        Multiplicacion m = new Multiplicacion();
        Division d = new Division();


        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void btn0_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "9";
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + "00";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            tbxDisplay.Text = tbxDisplay.Text + ",";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {

            operador = "÷";
            try
            {
                primero = float.Parse(tbxDisplay.Text);
                tbxDisplay.Clear();
            }
            catch
            {
                MessageBox.Show("Debe ingresar los datos a calcular primero.");
            }

        }

        private void btnX_Click(object sender, EventArgs e)
        {

            operador = "X";
            try
            {
                primero = float.Parse(tbxDisplay.Text);
                tbxDisplay.Clear();
            }
            catch {
                MessageBox.Show("Debe ingresar los datos a calcular primero.");
            }

        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            operador = "-";
            try
            {

                primero = float.Parse(tbxDisplay.Text);
                tbxDisplay.Clear();
            }
            catch
            {
                MessageBox.Show("Debe ingresar los datos a calcular primero.");
            }
        }

        private void btnMas_Click(object sender, EventArgs e)
        {


            operador = "+";
            try
            {

                primero = float.Parse(tbxDisplay.Text);
                tbxDisplay.Clear();
            }
            catch
            {
                MessageBox.Show("Debe ingresar los datos a calcular primero.");
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                segundo = float.Parse(tbxDisplay.Text);
                double sum;
                double res;
                double mul;
                double div;

                switch (operador)
                {
                    case "+":
                        sum = s.Sumar((primero), (segundo));

                        tbxDisplay.Text = sum.ToString();
                        break;
                    case "-":
                        res = r.Restar((primero), (segundo));

                        tbxDisplay.Text = res.ToString();
                        break;
                    case "÷":
                        div = d.Dividir((primero), (segundo));

                        tbxDisplay.Text = div.ToString();

                        break;
                    case "X":
                        mul = m.Mult((primero), (segundo));

                        tbxDisplay.Text = mul.ToString();

                        break;
                }
            }
            catch
            {
                MessageBox.Show("Necesita ingresar datos a calcular primero.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {

                if (tbxDisplay.Text.Length == 1)
                    tbxDisplay.Text = "";
                tbxDisplay.Text = tbxDisplay.Text.Substring(0, tbxDisplay.Text.Length - 1);
            }
            catch
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tbxDisplay.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Muchas Gracias por utilizarme!~.");
            Application.Exit();
        }

        private void Mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Max_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void Logo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t~ Creador ~ \n        Jairo Gabriel Melo\n\t 2019-8625");
        }
    }
}