using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class N_Chofer
    {
        D_ChoferCompleto objChofer = new D_ChoferCompleto();

        public List<E_ChoferCompleto> ListandoChoferCompleto(string buscar)
        {
            return objChofer.ListChoferCompleto(buscar);
        }

        public List<E_ChoferCompleto> ListandoChofer(string buscar)
        {
            return objChofer.CargarChofer(buscar);
        }

        public List<E_ChoferCompleto> ListandoChoferDisponible(string buscar)
        {
            return objChofer.CargarChoferDisponible(buscar);
        }

        public void IngresandoChofer(E_ChoferCompleto ChoferCompleto)
        {
            objChofer.InsertarChofer(ChoferCompleto);
        }

        public void IngresarChoferAutobus(E_ChoferCompleto ChoferCompleto)
        {
            objChofer.InsertarChoferAutoBus(ChoferCompleto);
        }
    }
}
