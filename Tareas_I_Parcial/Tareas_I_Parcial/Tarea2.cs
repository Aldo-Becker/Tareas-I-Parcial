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
    public partial class Tarea2 : Form
    {
        public Tarea2()
        {
            InitializeComponent();
        }

        private async void PromedioButton_Click(object sender, EventArgs e)
        {
            if (Nota1TextBox.Text == "")
            {
                errorProvider1.SetError(Nota1TextBox, "Ingrese una Nota");
                return;
            }
            if (Nota2TextBox.Text == "")
            {
                errorProvider1.SetError(Nota2TextBox, "Ingrese un Nota");
                return;
            }
            if (Nota3TextBox.Text == "")
            {
                errorProvider1.SetError(Nota3TextBox, "Ingrese un Nota");
                return;
            }
            if (Nota4TextBox.Text == "")
            {
                errorProvider1.SetError(Nota4TextBox, "Ingrese un Nota");
                return;
            }

            errorProvider1.Clear();

            decimal nota1 = Convert.ToDecimal(Nota1TextBox.Text);
            decimal nota2 = Convert.ToDecimal(Nota2TextBox.Text);
            decimal nota3 = Convert.ToDecimal(Nota3TextBox.Text);
            decimal nota4 = Convert.ToDecimal(Nota4TextBox.Text);

            decimal total = await PromedioAsync(nota1, nota2, nota3, nota4);

            if (total >= 65)
            {
                MessageBox.Show($"El Promedio Final del Estudiante es {total}, Por lo Tanto el Estudiante Aprobó la Clase.");
            }
            else
            {
                MessageBox.Show($"El Promedio Final del Estudiante es {total}, Por lo Tanto el Estudiante Reprobó la Clase.");
            }
        }

        private async Task<decimal> PromedioAsync(decimal n1, decimal n2, decimal n3, decimal n4)
        {
            decimal promedio = await Task.Run(() =>
            {
                return (n1 + n2 + n3 + n4) / 4;

            });
            return promedio;
        }
    }
}
