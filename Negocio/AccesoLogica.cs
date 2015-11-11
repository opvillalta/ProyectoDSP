using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Datos;

namespace Negocio
{
    public class AccesoLogica
    {
        public static bool insertarCliente(char id, string nombre, int edad, string tel, string email) {
            try
            {
                if (AccesoDatos.insertarCliente(id, nombre, edad, tel, email) != 0)
                {
                    return true;
                }
                else {
                    return false;
                }
            }
            catch {
                return false;
            }
        }

        public static DataTable seleccionarcliente(string origen, string destino)
        {
            return AccesoDatos.seleccionar(origen, destino);
        }
    }
}