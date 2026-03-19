using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CNProducto
    {
        public static DataTable Listar()
        {
            CDProducto Datos = new CDProducto();
            return Datos.Listar();
        }

        //Método Guardar que llama al método Guardar de la clase CDProducto de la CapaDatos
        public static string Guardar(string codigo, string nombre, string descripcion,
            DateTime fingreso, DateTime fvencimiento, double pcompra,
            double pventa, int stock, string estado, int idcategoria)
        {
            CDProducto Datos = new CDProducto();
            Datos.Codigo = codigo;
            Datos.Nombre = nombre;
            Datos.Descripcion = descripcion;
            Datos.Fingreso = fingreso;
            Datos.Fvencimiento = fvencimiento;
            Datos.Pcompra = pcompra;
            Datos.Pventa = pventa;
            Datos.Stock = stock;
            Datos.Estado = estado;
            Datos.Idcategoria = idcategoria;

            return Datos.Guardar(Datos);
        }

        //Método Editar que llama al método Editar de la clase CDProducto de la CapaDatos
        public static string Editar(int idproducto,
            string codigo, string nombre, string descripcion,
            DateTime fingreso, DateTime fvencimiento, double pcompra,
            double pventa, int stock, string estado, int idcategoria)
        {
            CDProducto Datos = new CDProducto();
            Datos.Idproducto = idproducto;
            Datos.Codigo = codigo;
            Datos.Nombre = nombre;
            Datos.Descripcion = descripcion;
            Datos.Fingreso = fingreso;
            Datos.Fvencimiento = fvencimiento;
            Datos.Pcompra = pcompra;
            Datos.Pventa = pventa;
            Datos.Stock = stock;
            Datos.Estado = estado;
            Datos.Idcategoria = idcategoria;

            return Datos.Editar(Datos);
        }

        //Método Eliminar que llama al método Eliminar de la clase CDProducto de la CapaDatos
        public static string Eliminar(int idproducto)
        {
            CDProducto Datos = new CDProducto();
            Datos.Idproducto = idproducto;
            return Datos.Eliminar(Datos);
        }

        //Método BuscarNombre que llama al método Buscar de la clase CDProducto de la CapaDatos
        public static DataTable BuscarNombre(string textobuscar)
        {
            CDProducto Datos = new CDProducto();
            Datos.Buscar = textobuscar;
            return Datos.BuscarNombre(Datos);
        }
        //Método BuscarCodigo que llama al método Buscar de la clase CDProducto de la CapaDatos
        public static DataTable BuscarCodigo(string textobuscar)
        {
            CDProducto Datos = new CDProducto();
            Datos.Buscar = textobuscar;
            return Datos.BuscarCodigo(Datos);
        }
    }
}