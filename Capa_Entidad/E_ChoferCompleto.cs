using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class E_ChoferCompleto
    {
        private string _Cedula;
        private string _Nombre;
        private string _Apellido;
        DateTime _fecha_nacimiento = new DateTime();
        private string _Marca;
        private string _Modelo;
        private string _Ruta;
        private int _Id_Autobus;

        public string Cedula { get => _Cedula; set => _Cedula = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public DateTime Fecha_nacimiento { get => _fecha_nacimiento; set => _fecha_nacimiento = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public string Modelo { get => _Modelo; set => _Modelo = value; }
        public string Ruta { get => _Ruta; set => _Ruta = value; }
        public int Id_Autobus { get => _Id_Autobus; set => _Id_Autobus = value; }
    }
}
