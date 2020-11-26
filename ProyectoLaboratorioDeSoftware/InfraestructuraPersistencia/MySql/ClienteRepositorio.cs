using Dominio.Entidades;
using Dominio.Repositorio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraestructuraPersistencia.MySQL
{
    public class ClienteRepositorio : IRepository<Cliente>
    {

        public bool Delete(int id)
        {
            string MYSql_Statement = "delete from clients where idclients = " + id;
            using (MySqlConnection conexion = BasedeDatos.getInstancia().getConexion())
            {
                MySqlCommand cmd = new MySqlCommand(MYSql_Statement, conexion);
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    return true;
                }

            }
        }

        public List<Cliente> GetAll()
        {
            const string MYSql_Statement = "select idclients, nombre from clients";
            List<Cliente> resultado = new List<Cliente>();
            using (MySqlConnection conexion = BasedeDatos.getInstancia().getConexion())
            {
                MySqlCommand cmd = new MySqlCommand(MYSql_Statement, conexion);
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Cliente cliente = Mapper(dr);
                        resultado.Add(cliente);
                    }  
                }
            }

            return resultado;

        }


        private Cliente Mapper(MySqlDataReader dr)
        {
            Cliente cliente = new Cliente();
            cliente.id = BasedeDatos.GetDataValue<int>(dr, "idclients");
            cliente.Nombre = BasedeDatos.GetDataValue<string>(dr, "nombre");
            return cliente;
        }


        public Cliente GetById(int id)
        {
            string MYSql_Statement = "select idclients, nombre from clients where idclients = " + id;
            Cliente resultado = new Cliente();
            using (MySqlConnection conexion = BasedeDatos.getInstancia().getConexion())
            {
                MySqlCommand cmd = new MySqlCommand(MYSql_Statement, conexion);
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        resultado = Mapper(dr);
                    }
                }
            }

            return resultado;
        }

        public bool Insert(Cliente cliente)
        {
            string MYSql_Statement = "insert into clients (nombre) value ('" + cliente.Nombre+ "')";
            using (MySqlConnection conexion = BasedeDatos.getInstancia().getConexion())
            {
                MySqlCommand cmd = new MySqlCommand(MYSql_Statement, conexion);
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    return true;
                }
            }
        }

        public bool Update(Cliente cliente)
        {
            //Cliente clientAux = GetById(cliente.id);

            string MYSql_Statement = "update clients set nombre = '" + cliente.Nombre + "' where idclients = " + cliente.id;
            using (MySqlConnection conexion = BasedeDatos.getInstancia().getConexion())
            {
                MySqlCommand cmd = new MySqlCommand(MYSql_Statement, conexion);
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    return true;
                }
            }
        }
    }
}
