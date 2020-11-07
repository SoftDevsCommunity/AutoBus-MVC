using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;
using Capa_Entidad;
using System.Data;

namespace Capa_Datos
{
    public class D_Autobus
    {
        OracleConnection conexion = new OracleConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Autobus> ListarAutobus (string buscar)
        {
            conexion.Open();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CARGARAUTOBUS";
            OracleParameter par1 = new OracleParameter();
            par1.OracleDbType = OracleDbType.RefCursor;
            par1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(par1);
            OracleParameter par2 = new OracleParameter("v_modelo", buscar);
            cmd.Parameters.Add(par2);
            cmd.ExecuteNonQuery();
            OracleRefCursor cursor = (OracleRefCursor)par1.Value;
            OracleDataReader read = cursor.GetDataReader();

            List<E_Autobus> Listar = new List<E_Autobus>();

            while (read.Read())
            {
                Listar.Add(new E_Autobus
                {
       
                    Modelo = read.GetString(0),
                    Marca = read.GetString(1),
                    Nombre = read.GetString(2),
                    Apellido = read.GetString(3),
                    Cedula = read.GetString(4),
                    Color = read.GetString(5),
                    Placa = read.GetString(6),
                    Año = read.GetString(7)

                });
            }

            conexion.Close();
            return Listar;
        }

        public List<E_Autobus> ListarAutobusDisponible(string buscar)
        {
            conexion.Open();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CARGARAUTOBUSDISPONIBLE";
            OracleParameter par1 = new OracleParameter();
            par1.OracleDbType = OracleDbType.RefCursor;
            par1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(par1);
            OracleParameter par2 = new OracleParameter("v_modelo", buscar);
            cmd.Parameters.Add(par2);
            cmd.ExecuteNonQuery();
            OracleRefCursor cursor = (OracleRefCursor)par1.Value;
            OracleDataReader read = cursor.GetDataReader();

            List<E_Autobus> Listar = new List<E_Autobus>();

            while (read.Read())
            {
                Listar.Add(new E_Autobus
                {

                    Id_autobus = read.GetInt32(0),
                    Marca = read.GetString(1),
                    Modelo = read.GetString(2),
                    Placa = read.GetString(3),
                    Color = read.GetString(4),
                    Año = read.GetString(5)

                });
            }

            conexion.Close();
            return Listar;
        }

        public void InsertarAutobus (E_Autobus Autobus)
        {
            conexion.Open();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_INSERTARAUTOBUS";
            OracleParameter par1 = new OracleParameter("v_marca", Autobus.Marca);
            cmd.Parameters.Add(par1);
            OracleParameter par2 = new OracleParameter("v_modelo", Autobus.Modelo);
            cmd.Parameters.Add(par2);
            OracleParameter par3 = new OracleParameter("v_placa", Autobus.Placa);
            cmd.Parameters.Add(par3);
            OracleParameter par4 = new OracleParameter("v_color", Autobus.Color);
            cmd.Parameters.Add(par4);
            OracleParameter par5 = new OracleParameter("v_año", Autobus.Año);
            cmd.Parameters.Add(par5);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }

        public void InsertarAutoBusRuta (E_Autobus Autobus)
        {
            conexion.Open();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_INSERTARAUTOBUS_RUTA";
            OracleParameter par1 = new OracleParameter("v_id_autobus", Autobus.Id_autobus);
            cmd.Parameters.Add(par1);
            OracleParameter par2 = new OracleParameter("v_id_ruta", Autobus.Id_ruta);
            cmd.Parameters.Add(par2);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
