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
    public partial class frmRuta : Form
    {
        E_Ruta objERuta = new E_Ruta();
        N_Ruta objNRuta = new N_Ruta();

        public frmRuta()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            objERuta.Ruta = txtRuta.Text;
            objNRuta.IngresandoRutas(objERuta);

            MessageBox.Show("Ruta ingresada con éxito");

            txtRuta.Clear();
        }
    }
}
