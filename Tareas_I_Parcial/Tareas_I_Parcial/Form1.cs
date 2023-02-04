using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tareas_I_Parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void VerificarButton_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(NúmeroTextBox.Text);

            ParImpar(numero);
            PositivoNegativo(numero);

            MessageBox.Show($"El Número Ingresado {numero} es: {ParImpar(numero)} y es {PositivoNegativo(numero)} ");
        }

        private string ParImpar(int num)
        {
            string resultado1;
            if (num % 2 == 0)
            {
                resultado1 = "Par";
            }
            else
            {
                resultado1 = "Impar";
            }
            return resultado1;
        }

        private string PositivoNegativo(int num)
        {
            string resultado2;
            if (num > 0)
            {
                resultado2 = "Positivo";
            }
            else
            {
                resultado2 = "Negativo";
            }
            return resultado2;
        }
    }
}
