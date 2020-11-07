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
    public partial class frmAsignarAutobus : Form
    {
        N_Chofer objNChofer = new N_Chofer();
        N_Autobus objNAutobus = new N_Autobus();
        E_ChoferCompleto objEChoferCompleto = new E_ChoferCompleto();

        public frmAsignarAutobus()
        {
            InitializeComponent();
        }

        private void MostrarChoferes(string buscar)
        {
            tablaChofer.DataSource = objNChofer.ListandoChoferDisponible(buscar);
        }

        private void MostrarAutobus(string buscar)
        {
            tablaAutobus.DataSource = objNAutobus.ListandoAutobusDisponible(buscar);
        }

        private void txtBuscarChofer_TextChanged(object sender, EventArgs e)
        {
            MostrarChoferes(txtBuscarChofer.Text);
        }

        private void tablasVacia()
        {
            if(tablaChofer.Rows.Count == 0 || tablaAutobus.Rows.Count == 0)
            {
                MessageBox.Show("No hay chofer o autobus disponible");
            }
        }

        private void frmAsignarAutobus_Load(object sender, EventArgs e)
        {
            MostrarChoferes("");
            MostrarAutobus("");
            AccionesTablasChofer();
            AccionesTablasAutobus();
            tablasVacia();
        }

        private void AccionesTablasChofer()
        {
            tablaChofer.Columns[0].Width = 100;
            tablaChofer.Columns[1].Width = 100;
            tablaChofer.Columns[2].Width = 100;
            tablaChofer.Columns[3].Width = 100;
        }

        private void AccionesTablasAutobus()
        {
            tablaAutobus.Columns[0].Width = 30;
            tablaAutobus.Columns[1].Width = 30;
            tablaAutobus.Columns[2].Width = 60;
            tablaAutobus.Columns[3].Width = 70;
            tablaAutobus.Columns[4].Width = 20;
            tablaAutobus.Columns[5].Width = 60;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtBuscarAutobus_TextChanged(object sender, EventArgs e)
        {
            MostrarAutobus(txtBuscarAutobus.Text);
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string cedula = tablaChofer.CurrentRow.Cells[0].Value.ToString();
            string idbus = tablaAutobus.CurrentRow.Cells[0].Value.ToString();

            objEChoferCompleto.Cedula = cedula;
            objEChoferCompleto.Id_Autobus = Convert.ToInt32(idbus);

            objNChofer.IngresarChoferAutobus(objEChoferCompleto);

            MessageBox.Show("Se ha hecho la anexión con éxito.");

            MostrarChoferes("");
            MostrarAutobus("");
        }
    }
}
