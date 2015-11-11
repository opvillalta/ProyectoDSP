using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Datos.Views
{
    public class misDatos
    {
        public static int eliminarPost(int post)
        {
            SqlCommand _comando = MetodosInfo.CrearComandoProc("EliminarCompañia");
            _comando.Parameters.AddWithValue("@idCompañia", post);
            return MetodosInfo.EjecutarComando(_comando);
        }
        public static int insertarPost(string cliente)
        {
            SqlCommand _comando = MetodosInfo.CrearComandoProc("EliminarCompañia");
            _comando.Parameters.AddWithValue("@cliente", cliente);

            return MetodosInfo.EjecutarComando(_comando);
        }
        public static int actualizarPost(string cliente)
        {
            SqlCommand _comando = MetodosInfo.CrearComandoProc("EliminarCompañia");
            _comando.Parameters.AddWithValue("@cliente", cliente);

            return MetodosInfo.EjecutarComando(_comando);
        }
    }
}