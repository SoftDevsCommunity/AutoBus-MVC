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
    public class D_Ruta
    {
        OracleConnection conexion = new OracleConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_Ruta> ListarRutas(string buscar)
        {
            conexion.Open();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CARGARRUTA";
            OracleParameter par1 = new OracleParameter();
            par1.OracleDbType = OracleDbType.RefCursor;
            par1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(par1);
            OracleParameter par2 = new OracleParameter("v_ruta", buscar);
            cmd.Parameters.Add(par2);
            cmd.ExecuteNonQuery();
            OracleRefCursor cursor = (OracleRefCursor)par1.Value;
            OracleDataReader read = cursor.GetDataReader();

            List<E_Ruta> Listar = new List<E_Ruta>();

            while (read.Read())
            {
                Listar.Add(new E_Ruta
                {

                    Id_ruta = read.GetInt32(0),
                    Ruta = read.GetString(1)

                });
            }

            conexion.Close();
            return Listar;
        }

        public List<E_Ruta> ListarRutasDisponibles(string buscar)
        {
            conexion.Open();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CARGARRUTADISPONIBLE";
            OracleParameter par1 = new OracleParameter();
            par1.OracleDbType = OracleDbType.RefCursor;
            par1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(par1);
            OracleParameter par2 = new OracleParameter("v_ruta", buscar);
            cmd.Parameters.Add(par2);
            cmd.ExecuteNonQuery();
            OracleRefCursor cursor = (OracleRefCursor)par1.Value;
            OracleDataReader read = cursor.GetDataReader();

            List<E_Ruta> Listar = new List<E_Ruta>();

            while (read.Read())
            {
                Listar.Add(new E_Ruta
                {

                    Id_ruta = read.GetInt32(0),
                    Ruta = read.GetString(1)

                });
            }

            conexion.Close();
            return Listar;
        }

        public void InsertarRuta(E_Ruta Ruta)
        {
            conexion.Open();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CARGARAUTOBUS";
            OracleParameter par1 = new OracleParameter("v_ruta", Ruta.Ruta);
            cmd.Parameters.Add(par1);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
