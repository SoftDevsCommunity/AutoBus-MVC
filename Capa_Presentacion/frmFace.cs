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
    public partial class frmFace : Form
    {
        N_Chofer objNChofer = new N_Chofer();
        N_Ruta objNRuta = new N_Ruta();

        public frmFace()
        {
            InitializeComponent();
        }

        private void frmFace_Load(object sender, EventArgs e)
        {
            mostrarChoferCompleto("");
        }

        public void mostrarChoferCompleto(string buscar)
        {
            tablaChoferCompleto.DataSource = objNChofer.ListandoChoferCompleto(buscar);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            mostrarChoferCompleto(txtBuscar.Text);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAgregarChofer_Click(object sender, EventArgs e)
        {
            frmAgregarChofer agregarChofer = new frmAgregarChofer();
            agregarChofer.Show();
        }


        private void btnAgregarAutobus_Click(object sender, EventArgs e)
        {
            frmAgregarAutobus frmAddAutoBus = new frmAgregarAutobus();
            frmAddAutoBus.Show();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            mostrarChoferCompleto("");
        }

        private void btnAsignarAutobus_Click(object sender, EventArgs e)
        {
            frmAsignarAutobus frmAsignarBus = new frmAsignarAutobus();
            frmAsignarBus.Show();
        }

        private void btnAgregarRuta_Click(object sender, EventArgs e)
        {
            frmRuta fRuta = new frmRuta();
            fRuta.Show();
        }

        private void btnAsignarRuta_Click(object sender, EventArgs e)
        {
            frmAsignarAutobusRuta AsignarAR = new frmAsignarAutobusRuta();
            AsignarAR.Show();
        }
    }
}
