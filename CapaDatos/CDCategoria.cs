using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CDCategoria
    {
        public int IdCategoria { get; set; }
        public string Descripcion { get; set; }
        public string Buscar { get; set; }

        public DataTable Listar()
        {
            DataTable resul = new DataTable("categoria");

            using (SqlConnection conexion = new SqlConnection(Conexion.Conn))
            {
                try
                {
                    SqlCommand Cmd = new SqlCommand("SPListar_Categoria", conexion);
                    Cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                    SqlDat.Fill(resul);
                }
                catch (Exception ex)
                {
                    resul = null;
                    throw ex;
                }
            }

            return resul;
        }

        public string Guardar(CDCategoria cat)
        {
            string resul = "";

            using (SqlConnection conexion = new SqlConnection(Conexion.Conn))
            {
                try
                {
                    conexion.Open();

                    SqlCommand Cmd = new SqlCommand("SPGuardar_Categoria", conexion);
                    Cmd.CommandType = CommandType.StoredProcedure;

                    // ✅ PARÁMETRO OUTPUT CORRECTO
                    SqlParameter paramId = new SqlParameter("@id_categoria", SqlDbType.Int);
                    paramId.Direction = ParameterDirection.Output;
                    Cmd.Parameters.Add(paramId);

                    // ✅ PARÁMETRO NORMAL
                    Cmd.Parameters.AddWithValue("@Descripcion", cat.Descripcion);

                    resul = Cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo insertar el registro";
                }
                catch (Exception ex)
                {
                    resul = ex.Message;
                }
            }

            return resul;
        }

        public string Editar(CDCategoria cat)
        {
            string resul = "";

            using (SqlConnection conexion = new SqlConnection(Conexion.Conn))
            {
                try
                {
                    conexion.Open();

                    SqlCommand Cmd = new SqlCommand("SPEditar_Categoria", conexion);
                    Cmd.CommandType = CommandType.StoredProcedure;

                    Cmd.Parameters.AddWithValue("@id_categoria", cat.IdCategoria);
                    Cmd.Parameters.AddWithValue("@Descripcion", cat.Descripcion);

                    resul = Cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo actualizar el registro";
                }
                catch (Exception ex)
                {
                    resul = ex.Message;
                }
            }

            return resul;
        }

        public string Eliminar(CDCategoria cat)
        {
            string resul = "";

            using (SqlConnection conexion = new SqlConnection(Conexion.Conn))
            {
                try
                {
                    conexion.Open();

                    SqlCommand Cmd = new SqlCommand("SPEliminar_Categoria", conexion);
                    Cmd.CommandType = CommandType.StoredProcedure;

                    Cmd.Parameters.AddWithValue("@id_categoria", cat.IdCategoria);

                    resul = Cmd.ExecuteNonQuery() == 1 ? "Ok" : "No se pudo eliminar el registro";
                }
                catch (Exception ex)
                {
                    resul = ex.Message;
                }
            }

            return resul;
        }

        public DataTable BuscarNombre(CDCategoria cat)
        {
            DataTable resul = new DataTable("categoria");

            using (SqlConnection conexion = new SqlConnection(Conexion.Conn))
            {
                try
                {
                    SqlCommand Cmd = new SqlCommand("SPBuscar_Categoria", conexion);
                    Cmd.CommandType = CommandType.StoredProcedure;

                    Cmd.Parameters.AddWithValue("@Desc", cat.Buscar);

                    SqlDataAdapter SqlDat = new SqlDataAdapter(Cmd);
                    SqlDat.Fill(resul);
                }
                catch (Exception ex)
                {
                    resul = null;
                    throw ex;
                }
            }

            return resul;
        }
    }
}