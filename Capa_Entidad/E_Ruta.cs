using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class E_Ruta
    {
        private int _Id_ruta;
        private string _Ruta;

        public int Id_ruta { get => _Id_ruta; set => _Id_ruta = value; }
        public string Ruta { get => _Ruta; set => _Ruta = value; }
    }
}
