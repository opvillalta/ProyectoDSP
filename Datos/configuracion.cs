using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Datos
{
    public class configuracion
    {
        static string conexionBase = @"Data Source=vaio;Initial Catalog=Reserva;Integrated Security=True";
        public static string conexion
        {
            get { 
                return conexionBase;
            }
        }
    }
}