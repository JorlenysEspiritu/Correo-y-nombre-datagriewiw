using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datagridview_correo
{
    public partial class Form1 : Form
    {
         DialogResult respuesta;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

           

            if (txt_nombre.Text == ""|| txt_correo.Text == "")
            {
                respuesta = MessageBox.Show("El campo Nombre esta vacio, Debes de llenarlo", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                
            }
            else
            {
                dataGridView1.Rows.Add(txt_nombre.Text, txt_correo.Text);
                txt_correo.Clear();
                txt_nombre.Clear();
                txt_nombre.Focus(); 
            }
            
            
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            int fila;
            if (dataGridView1.Rows.Count == 0)
            {
                 MessageBox.Show("No hay datos para eliminar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else 
            {
               DialogResult respuesta = MessageBox.Show("Desea eliminar este registro?", "Registro", MessageBoxButtons.YesNo);

                if (respuesta == DialogResult.Yes)
                {
                   
                    fila = dataGridView1.CurrentRow.Index;
                    dataGridView1.Rows.RemoveAt(fila);
                    MessageBox.Show("Registro eliminado", "Registro");
                }
            }
           
            
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            respuesta = MessageBox.Show("¿Quieres salir del programa?", "Programa", MessageBoxButtons.YesNo);
            Close();
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txt_correo.Clear();
            txt_nombre.Clear();
        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
