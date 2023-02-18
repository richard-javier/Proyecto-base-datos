using CapaNegocio;
using System;
using System.Data;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{

    public partial class Form1 : Form
    {
        
            //Intancio un objeto en la capa de negocio
            CN_GetData objectCN = new CN_GetData();
            public Form1()
            {
                InitializeComponent();
            }

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {

            }

            private void Form1_Load(object sender, EventArgs e)
            {
            // Obtener las provincias y llenar el ComboBox
            DataTable provincias = objectCN.CN_GetComboProvincia();
            comboBoxProvincia.DataSource = provincias;
            comboBoxProvincia.DisplayMember = "Provincia";

            // Obtener las ciudades de la primera provincia y llenar el DataGridView
            string provinciaSeleccionada = comboBoxProvincia.Text; // Obtener la provincia seleccionada
            DataTable ciudades = objectCN.CN_GetCiudad(1);
            dGProvincia.DataSource = ciudades;

            dGProvincia.DataSource = objectCN.CN_GetProvincia();
            
        }

        private void comboBoxProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener la provincia seleccionada y actualizar el DataGridView
            string provinciaSeleccionada = comboBoxProvincia.Text;
            DataTable ciudades = objectCN.CN_GetProvincia();
            dGProvincia.DataSource = ciudades;
        }
    }
}