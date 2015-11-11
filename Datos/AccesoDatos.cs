using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Datos
{
    public class AccesoDatos
    {
        public static int insertarCliente(char id, string nombre, int edad, string tel, string email) {
            SqlCommand _comando = MetodosInfo.CrearComandoProc("RegistrarCliente");
            _comando.Parameters.AddWithValue("@idCliente", id);
            _comando.Parameters.AddWithValue("@nombre", nombre);
            _comando.Parameters.AddWithValue("@edad", edad);
            _comando.Parameters.AddWithValue("@telefono", tel);
            _comando.Parameters.AddWithValue("@email", email);

            return MetodosInfo.EjecutarComando(_comando);
        }
        public static DataTable seleccionar(string origen, string destino)
        {

            SqlCommand _comando = MetodosInfo.CrearComando();
            _comando.CommandText = "select c.nombre as Compañia,v.capacidad,v.modelo_Avion,v.ciudadorigen,v.ciudaddestino  from Compañia as c inner join Vuelo as v on c.id_compañia=v.codCompañia where v.ciudadorigen like  '" + origen + "' and v.ciudaddestino like '" + destino + "'";
            return MetodosInfo.EjecutarComandoSelect(_comando);

        }
    }
}