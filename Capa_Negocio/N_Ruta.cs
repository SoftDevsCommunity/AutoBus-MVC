using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Capa_Entidad;

namespace Capa_Negocio
{
    public class N_Ruta
    {
        D_Ruta objRuta = new D_Ruta();

        public List<E_Ruta> ListandoRutas(string buscar)
        {
            return objRuta.ListarRutas(buscar);
        }

        public List<E_Ruta> ListandoRutasDisponibles(string buscar)
        {
            return objRuta.ListarRutasDisponibles(buscar);
        }

        public void IngresandoRutas(E_Ruta Ruta)
        {
            objRuta.InsertarRuta(Ruta);
        }
    }
}
