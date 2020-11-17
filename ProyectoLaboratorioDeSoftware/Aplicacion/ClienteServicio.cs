using Dominio.Entidades;
using Dominio.Repositorio;
using InfraestructuraPersistencia;
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
            ClienteRepositorio repositorio = new ClienteRepositorio();
            if (cliente.Validate()==false)
            {
                return false;
            }
            return repositorio.Insert(cliente);
        }
    }
}
