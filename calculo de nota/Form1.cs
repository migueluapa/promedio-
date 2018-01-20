using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculo_de_nota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btningles_Click(object sender, EventArgs e)
        {
            lblmatricula.Text = "ID";
            lblnombre.Text = "nombre";
            lblapellido.Text = "LasT Name";
            lbltelefono.Text = "phone";

        }

        private void btnespanol_Click(object sender, EventArgs e)
        {
            lblmatricula.Text = "ID";
            lblnombre.Text = "nombre";
            lblapellido.Text = "apellido";
            lbltelefono.Text = "telefono";

        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            lblmatricula.Text = "";
            lblnombre.Text = "";
            lblapellido.Text = "";
            lbltelefono.Text = "";

        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            
            double matricula, nombre, apellido, telefono, examen, tareas, trabajo, nota;
            matricula = Convert.ToDouble(txtmatricula.Text);
            nombre = Convert.ToDouble(txtnombre.Text);
            apellido = Convert.ToDouble(txtapellido.Text);
            telefono = Convert.ToDouble(txttelefono.Text);
            examen = Convert.ToDouble(txtexamen.Text);
            tareas = Convert.ToDouble(txttareas.Text);
            trabajo = Convert.ToDouble(txttrabajo.Text);
            nota = Convert.ToDouble(txtnota.Text);
            txtresultado.Text = nota.ToString();


            nota = examen + tareas + trabajo;
            if (Convert.ToDouble(txtnota.Text) >= 70 && Convert.ToDouble(txtnota.Text) <= 100)

            


            {
                MessageBox.Show("Aprobado");

            }
            else if (Convert.ToDouble(txtnota.Text) <= 69 && Convert.ToDouble(txtnota.Text) <= 69)

            {
                MessageBox.Show("Reprovado");

            }
        }
    }
}
