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
        private string _Fecha_nacimiento;
        private string _Marca;
        private string _Modelo;
        private string _Ruta;
        private int _Id_Autobus;

        public string Cedula { get => _Cedula; set => _Cedula = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Fecha_nacimiento { get => _Fecha_nacimiento; set => _Fecha_nacimiento = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public string Modelo { get => _Modelo; set => _Modelo = value; }
        public string Ruta { get => _Ruta; set => _Ruta = value; }
        public int Id_Autobus { get => _Id_Autobus; set => _Id_Autobus = value; }
    }
}
