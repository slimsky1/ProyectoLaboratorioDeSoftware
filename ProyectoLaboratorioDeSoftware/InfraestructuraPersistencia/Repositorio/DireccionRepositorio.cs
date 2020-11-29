using Dominio.Entidades;
using Dominio.Repositorio;
using InfraestructuraPersistencia.MySQL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraestructuraPersistencia.MySQL
{

    public class DireccionRepositorio : IRepositoryDireccion<Direccion>

    {

        public bool Delete(int id)
        {
            string MYSql_Statement = "delete from direcciones where iddirecciones = " + id;
            using (MySqlConnection conexion = BasedeDatos.getInstancia().getConexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(MYSql_Statement, conexion);
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    return true;
                }

            }
        }

        public List<Direccion> GetAll()
        {
            const string MYSql_Statement = "select iddirecciones, fkclients, calle, altura from direcciones";
            List<Direccion> resultado = new List<Direccion>();
            using (MySqlConnection conexion = BasedeDatos.getInstancia().getConexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(MYSql_Statement, conexion);
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Direccion direccion = Mapper(dr);
                        resultado.Add(direccion);
                    }
                }
            }

            return resultado;

        }


        private Direccion Mapper(MySqlDataReader dr)
        {
            Direccion direccion = new Direccion();
            direccion.id = BasedeDatos.GetDataValue<int>(dr, "iddirecciones");
            direccion.fkClients = BasedeDatos.GetDataValue<int>(dr, "fkclients");
            direccion.Calle = BasedeDatos.GetDataValue<string>(dr, "calle");
            direccion.Altura = BasedeDatos.GetDataValue<int>(dr, "altura");
            return direccion;
        }


        public Direccion GetById(int id) { 

            string MYSql_Statement = "select iddirecciones, fkclients, calle, altura from direcciones where iddirecciones = " + id;
            Direccion resultado = new Direccion();
            using (MySqlConnection conexion = BasedeDatos.getInstancia().getConexion())
            {

                conexion.Open();
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

        public bool Insert(Direccion direccion)

        {
            string MYSql_Statement = "insert into direcciones (fkclients, calle, altura) value (" + direccion.fkClients + ",'" + direccion.Calle + "', " + direccion.Altura + ")";
            using (MySqlConnection conexion = BasedeDatos.getInstancia().getConexion())
            {
                conexion.Open();
                MySqlCommand cmd = new MySqlCommand(MYSql_Statement, conexion);
                using (MySqlDataReader dr = cmd.ExecuteReader())
                {
                    return true;
                }
            }
        }


        public bool Update(Direccion direccion) { 

            //Cliente clientAux = GetById(cliente.id);

            string MYSql_Statement = "update direcciones set calle = '" + direccion.Calle + "' where iddirecciones = " + direccion.id;
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
