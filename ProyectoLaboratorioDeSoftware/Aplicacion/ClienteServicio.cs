using Dominio.Entidades;
using Dominio.Repositorio;
using InfraestructuraPersistencia;
using InfraestructuraPersistencia.MySQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion
{
    public class ClienteServicio
    {

        public List<Cliente> Listar()
        {
            IRepository<Cliente> repositorio = new InfraestructuraPersistencia.MySQL.ClienteRepositorio();
            return repositorio.GetAll();
        }


        public bool Guardar(String nombre)
        {
         
            Cliente cliente = new Cliente();
            cliente.Nombre = nombre;
            IRepository<Cliente> repositorio = new InfraestructuraPersistencia.MySQL.ClienteRepositorio();
            //if (cliente.validate() == false)
            //{
            //    return false;
            //}
            return repositorio.Insert(cliente);
        }

        public bool Eliminar(int id)
        {
            Cliente cliente = new Cliente();
            cliente.id = id;
            IRepository<Cliente> repositorio = new InfraestructuraPersistencia.MySQL.ClienteRepositorio();
            return repositorio.Delete(cliente.id);
        }

        public bool Modificar(Cliente cliente)
        {
            IRepository<Cliente> repositorio = new InfraestructuraPersistencia.MySQL.ClienteRepositorio();
            return repositorio.Update(cliente);
        }

        public Cliente ObtenerClientePorId(int id)
        {
            IRepository<Cliente> repositorio = new InfraestructuraPersistencia.MySQL.ClienteRepositorio();
            return repositorio.GetById(id);
        }
    }
}
