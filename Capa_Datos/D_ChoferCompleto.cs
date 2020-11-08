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
    public class D_ChoferCompleto
    {
        OracleConnection conexion = new OracleConnection(ConfigurationManager.ConnectionStrings["conectar"].ConnectionString);

        public List<E_ChoferCompleto> ListChoferCompleto(string buscar)
        {
            conexion.Open();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CARGARCHOFERCOMPLETO";
            OracleParameter par1 = new OracleParameter();
            par1.OracleDbType = OracleDbType.RefCursor;
            par1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(par1);
            OracleParameter par2 = new OracleParameter("v_nombre", buscar);
            cmd.Parameters.Add(par2);
            cmd.ExecuteNonQuery();
            OracleRefCursor cursor = (OracleRefCursor)par1.Value;
            OracleDataReader read = cursor.GetDataReader();

            List<E_ChoferCompleto> Listar = new List<E_ChoferCompleto>();

            while(read.Read())
            {
                Listar.Add(new E_ChoferCompleto
                {
                    Nombre = read.GetString(0),
                    Apellido = read.GetString(1),
                    Cedula = read.GetString(2),
                    Fecha_nacimiento = read.GetDateTime(3),
                    Marca = read.GetString(4),
                    Modelo = read.GetString(5),
                    Ruta = read.GetString(6)
                });
            }

            conexion.Close();
            return Listar;
        }

        public List<E_ChoferCompleto> CargarChofer (string buscar)
        {
            conexion.Open();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CARGARCHOFER";
            OracleParameter par1 = new OracleParameter();
            par1.OracleDbType = OracleDbType.RefCursor;
            par1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(par1);
            OracleParameter par2 = new OracleParameter("v_nombre", buscar);
            cmd.Parameters.Add(par2);
            cmd.ExecuteNonQuery();
            OracleRefCursor cursor = (OracleRefCursor)par1.Value;
            OracleDataReader read = cursor.GetDataReader();

            List<E_ChoferCompleto> Listar = new List<E_ChoferCompleto>();

            while (read.Read())
            {
                Listar.Add(new E_ChoferCompleto
                {
                    Cedula = read.GetString(0),
                    Nombre = read.GetString(1),
                    Apellido = read.GetString(2),
                    Fecha_nacimiento = read.GetDateTime(3)
                });
            }

            conexion.Close();
            return Listar;
        }

        public List<E_ChoferCompleto> CargarChoferDisponible(string buscar)
        {
            conexion.Open();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_CARGARCHOFERDISPONIBLE";
            OracleParameter par1 = new OracleParameter();
            par1.OracleDbType = OracleDbType.RefCursor;
            par1.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(par1);
            OracleParameter par2 = new OracleParameter("v_nombre", buscar);
            cmd.Parameters.Add(par2);
            cmd.ExecuteNonQuery();
            OracleRefCursor cursor = (OracleRefCursor)par1.Value;
            OracleDataReader read = cursor.GetDataReader();

            List<E_ChoferCompleto> Listar = new List<E_ChoferCompleto>();

            while (read.Read())
            {
                Listar.Add(new E_ChoferCompleto
                {
                    Cedula = read.GetString(0),
                    Nombre = read.GetString(1),
                    Apellido = read.GetString(2),
                    Fecha_nacimiento = read.GetDateTime(3)
                });
            }

            conexion.Close();
            return Listar;
        }

        public void InsertarChofer (E_ChoferCompleto ChoferCompleto)
        {
            try
            {
                conexion.Open();
                OracleCommand cmd = conexion.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SP_INSERTARCHOFER";
                OracleParameter par1 = new OracleParameter("v_cedula", ChoferCompleto.Cedula);
                cmd.Parameters.Add(par1);
                OracleParameter par2 = new OracleParameter("v_nombre", ChoferCompleto.Nombre);
                cmd.Parameters.Add(par2);
                OracleParameter par3 = new OracleParameter("v_apellido", ChoferCompleto.Apellido);
                cmd.Parameters.Add(par3);
                OracleParameter par4 = new OracleParameter("v_fecha_nacimiento", ChoferCompleto.Fecha_nacimiento);
                cmd.Parameters.Add(par4);
                cmd.ExecuteNonQuery();
            } catch (OracleException e)
            {
                string errorMessage = "Code "+e.ErrorCode+", Message "+e.Message;

                System.Diagnostics.EventLog log = new System.Diagnostics.EventLog();
                log.Source = "My application";
                log.WriteEntry(errorMessage);
            }
            conexion.Close();
        }

        public void InsertarChoferAutoBus (E_ChoferCompleto ChoferCompleto)
        {
            conexion.Open();
            OracleCommand cmd = conexion.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "SP_INSERTARCHOFER_AUTOBUS";
            OracleParameter par1 = new OracleParameter("v_cedula", ChoferCompleto.Cedula);
            cmd.Parameters.Add(par1);
            OracleParameter par2 = new OracleParameter("v_id_autobus", ChoferCompleto.Id_Autobus);
            cmd.Parameters.Add(par2);
            cmd.ExecuteNonQuery();
            conexion.Close();
        }
     
    }

}
