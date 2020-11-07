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
    public partial class frmAgregarChofer : Form
    {
        E_ChoferCompleto objEChofer = new E_ChoferCompleto();
        N_Chofer objNChofer = new N_Chofer();

        public frmAgregarChofer()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            txtCedula.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            objEChofer.Cedula = txtCedula.Text;
            objEChofer.Nombre = txtNombre.Text;
            objEChofer.Apellido = txtApellido.Text;
            string fecha = dataTimeFecha.Text;
            objEChofer.Fecha_nacimiento = Convert.ToDateTime(fecha);

            objNChofer.IngresandoChofer(objEChofer);

            LimpiarCampos();

            MessageBox.Show("Chofer agregado con éxito");

        }

    }
}
