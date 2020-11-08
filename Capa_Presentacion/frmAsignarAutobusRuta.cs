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
    public partial class frmAsignarAutobusRuta : Form
    {
        N_Autobus objNAutobus = new N_Autobus();
        E_Autobus objEAutobus = new E_Autobus();
        N_Ruta objNRuta = new N_Ruta();
        public frmAsignarAutobusRuta()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void CargarTablaAutobus(string buscar)
        {
            tablaAutobus.DataSource = objNAutobus.ListandoAutobusAsignados(buscar);
        }

        private void CargarTablasRutas(string buscar)
        {
            tablaRuta.DataSource = objNRuta.ListandoRutasDisponibles(buscar);
        }

        private void tablasVacia()
        {
            if (tablaRuta.Rows.Count == 0 || tablaAutobus.Rows.Count == 0)
            {
                MessageBox.Show("No hay autobus o ruta disponibles");
            }
        }

        private void frmAsignarAutobusRuta_Load(object sender, EventArgs e)
        {
            CargarTablaAutobus("");
            CargarTablasRutas("");
            AccionesTablasAutobus();
            AccionesTablasRutas();
            tablasVacia();
        }

        private void AccionesTablasAutobus()
        {
            tablaRuta.AutoResizeColumns();
      
        }

        private void AccionesTablasRutas()
        {
            tablaRuta.AutoResizeColumns();
        }

        private void txtBuscarAutobus_TextChanged(object sender, EventArgs e)
        {
            CargarTablaAutobus(txtBuscarAutobus.Text);
        }

        private void txtBuscarRuta_TextChanged(object sender, EventArgs e)
        {
            CargarTablasRutas(txtBuscarRuta.Text);
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            string idAutobus = tablaAutobus.CurrentRow.Cells[0].Value.ToString();
            string idRuta = tablaRuta.CurrentRow.Cells[0].Value.ToString();

            objEAutobus.Id_autobus = Convert.ToInt32(idAutobus);
            objEAutobus.Id_ruta = Convert.ToInt32(idRuta);

            objNAutobus.IngresarAutobusRuta(objEAutobus);
            CargarTablaAutobus("");
            CargarTablasRutas("");

        }
    }
}
