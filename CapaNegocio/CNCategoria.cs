using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CNCategoria
    {
        public static DataTable Listar()
        {
            CDCategoria Datos = new CDCategoria();
            return Datos.Listar();
        }

        public static string Guardar(string descripcion)
        {
            CDCategoria Datos = new CDCategoria();
            Datos.Descripcion = descripcion;

            return Datos.Guardar(Datos);
        }

        public static string Editar(int id_categoria, string descripcion)
        {
            CDCategoria Datos = new CDCategoria();
            Datos.IdCategoria = id_categoria;
            Datos.Descripcion = descripcion;
            return Datos.Editar(Datos);
        }

        public static string Eliminar(int id_categoria)
        {
            CDCategoria Datos = new CDCategoria();
            Datos.IdCategoria = id_categoria;
            return Datos.Eliminar(Datos);
        }

        public static DataTable BuscarNombre(string textobuscar)
        {
            CDCategoria Datos = new CDCategoria();
            Datos.Buscar = textobuscar;
            return Datos.BuscarNombre(Datos);
        }
    }
}
