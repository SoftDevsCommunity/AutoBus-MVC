using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class N_Autobus
    {
        D_Autobus objAutobus = new D_Autobus();

        public List<E_Autobus> ListandoAutobus(string buscar)
        {
            return objAutobus.ListarAutobus(buscar);
        }

        public List<E_Autobus> ListandoAutobusDisponible(string buscar)
        {
            return objAutobus.ListarAutobusDisponible(buscar);
        }

        public void IngresarAutobus(E_Autobus Autobus)
        {
            objAutobus.InsertarAutobus(Autobus);
        }

        public void IngresarAutobusRuta(E_Autobus Autobus)
        {
            objAutobus.InsertarAutoBusRuta(Autobus);
        }
    }
}
