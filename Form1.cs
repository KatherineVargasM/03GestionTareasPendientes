using System;
using System.Windows.Forms;

namespace GestionTareasPendientes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            if (txtTarea.Text == "")
            {
                MessageBox.Show("Error. Ingresa una tarea.");
            }
            else
            {
                lstTareas.Items.Add(txtTarea.Text);
                txtTarea.Clear();
            }
        }

        private void btnEliminarTarea_Click(object sender, EventArgs e)
        {
            if (lstTareas.SelectedIndex != -1)
            {
                DialogResult dialogResult =
                   MessageBox.Show("¿Esta seguro que desea eliminar esta tarea?", "Tarea",
                   MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    lstTareas.Items.RemoveAt(lstTareas.SelectedIndex);
                    MessageBox.Show("Se elimino con exito.");
                }
                else
                {
                    MessageBox.Show("Se cancelo la operacion.");
                }
            }
            else
            {
                MessageBox.Show("Error. Selecciona una tarea para eliminar.");
            }
        }
    }
}
