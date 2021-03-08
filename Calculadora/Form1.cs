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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_Numero2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            txt_Numero1.Clear();
            txt_Numero2.Clear();
            txt_Numero3.Clear();

            txt_Numero1.Focus();

        }

        private void rbt_Suma_CheckedChanged(object sender, EventArgs e)
        {
            Cal calculadora = new Cal();

            //double Suma = prueba.Suma(Convert.ToDouble(txtvalor1.Text), Convert.ToDouble(txtvalor2.Text));
            //txt_Numero3.Text = Convert.ToString(calculadora.Suma(Convert.ToDouble(txt_Numero1.Text), Convert.ToDouble(txt_Numero2.Text)));
            

        }

        private void rbt_Resta_CheckedChanged(object sender, EventArgs e)
        {
            //Cal calculadora = new Cal();
            //txt_Numero3.Text = Convert.ToString(calculadora.Resta(Convert.ToDouble(txt_Numero1.Text), Convert.ToDouble(txt_Numero2.Text)));
        }

        private void rbt_Multiplicacion_CheckedChanged(object sender, EventArgs e)
        {
            //Cal calculadora = new Cal();
            //txt_Numero3.Text = Convert.ToString(calculadora.Multiplicacion(Convert.ToDouble(txt_Numero1.Text), Convert.ToDouble(txt_Numero2.Text)));
        }

        private void rbt_Division_CheckedChanged(object sender, EventArgs e)
        {
            //Cal calculadora = new Cal();
            //txt_Numero3.Text = Convert.ToString(calculadora.Division(Convert.ToDouble(txt_Numero1.Text), Convert.ToDouble(txt_Numero2.Text)));
        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            Cal calculadora = new Cal();
            
            if (rbt_Suma.Checked == true)
            { 
               txt_Numero3.Text = Convert.ToString(calculadora.Suma(Convert.ToDouble(txt_Numero1.Text), Convert.ToDouble(txt_Numero2.Text)));
            }

           else if (rbt_Resta.Checked == true)
           {
                txt_Numero3.Text = Convert.ToString(calculadora.Resta(Convert.ToDouble(txt_Numero1.Text), Convert.ToDouble(txt_Numero2.Text)));
           }
            else if (rbt_Multiplicacion.Checked == true)
            {
                txt_Numero3.Text = Convert.ToString(calculadora.Multiplicacion(Convert.ToDouble(txt_Numero1.Text), Convert.ToDouble(txt_Numero2.Text)));
            }

            else if (rbt_Division.Checked == true)
            {
                txt_Numero3.Text = Convert.ToString(calculadora.Division(Convert.ToDouble(txt_Numero1.Text), Convert.ToDouble(txt_Numero2.Text)));
            }
        }
    }
}
