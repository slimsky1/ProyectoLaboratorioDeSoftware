using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraestructuraPersistencia
{
    public class BasedeDatos
    {

        private static BasedeDatos _instancia = null;
        private string stringConection = "datasource=127.0.0.1;port=3306;username=root;password=40252507;database=labdesoft1;";
        private MySqlConnection conexion = null;

        private BasedeDatos()
        {
            try
            {
                this.conexion = new MySqlConnection(stringConection);
                this.conexion.Open();
            } catch (Exception ex)
            {
                throw new Exception("Error!!"+ ex);
            }
        } 

        public static BasedeDatos getInstancia()
        {
            if(_instancia == null)
            {
                _instancia = new BasedeDatos();
            }
            return _instancia;
        }


        public MySqlConnection getConexion()
        {
            return _instancia.conexion;
        }

        public static T GetDataValue<T>(MySqlDataReader dr, string columna)
        {
            int i = dr.GetOrdinal(columna);
            if (!dr.IsDBNull(i))
            {
                return (T)dr.GetValue(i);
            }
            else
            {
                return default(T);
            }
        }
    }
}
