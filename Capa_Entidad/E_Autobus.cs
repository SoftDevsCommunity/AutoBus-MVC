using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidad
{
    public class E_Autobus
    {
        private int _Id_autobus;
        private int _Id_ruta;
        private string _Modelo;
        private string _Marca;
        private string _Nombre;
        private string _Apellido;
        private string _Cedula;
        private string _Color;
        private string _Placa;
        private string _Año;

        public int Id_autobus { get => _Id_autobus; set => _Id_autobus = value; }
        public int Id_ruta { get => _Id_ruta; set => _Id_ruta = value; }
        public string Cedula { get => _Cedula; set => _Cedula = value; }
        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Apellido { get => _Apellido; set => _Apellido = value; }
        public string Marca { get => _Marca; set => _Marca = value; }
        public string Modelo { get => _Modelo; set => _Modelo = value; }
        public string Color { get => _Color; set => _Color = value; }
        public string Placa { get => _Placa; set => _Placa = value; }
        public string Año { get => _Año; set => _Año = value; }
    }
}
