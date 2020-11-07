using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocio;

namespace Capa_Presentacion
{
    public partial class frmAgregarAutobus : Form
    {

        E_Autobus objEAutobus = new E_Autobus();
        N_Autobus objNAutobus = new N_Autobus();

        public frmAgregarAutobus()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtMarca.Clear();
            txtModelo.Clear();
            txtPlaca.Clear();
            txtColor.Clear();
            txtAño.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            objEAutobus.Marca = txtMarca.Text;
            objEAutobus.Modelo = txtModelo.Text;
            objEAutobus.Placa = txtPlaca.Text;
            objEAutobus.Color = txtColor.Text;
            objEAutobus.Año = txtAño.Text;

            objNAutobus.IngresarAutobus(objEAutobus);

            LimpiarCampos();

            MessageBox.Show("El registro se almacenó correctamente");
        }
    }
}
