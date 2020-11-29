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

        private IRepository<Cliente> _repository;

        public ClienteServicio(IRepository<Cliente> repository)
        {
            this._repository = repository;
        }


        public List<Cliente> Listar()
        {
            return this._repository.GetAll();
        }

        public bool Guardar(string nombre)
        {
         
            Cliente cliente = new Cliente();
            cliente.Nombre = nombre;

            if (cliente.Validate()==false)
            {
                return false;
            }
            return this._repository.Insert(cliente);
        }


        public bool Eliminar(int id)
        {
            return this._repository.Delete(id);
        }

        public bool Modificar(int id, String nombre)
        {
            Cliente cliente = new Cliente();
            cliente.id = id;
            cliente.Nombre = nombre;
            
            if(cliente.Validate() == false)
            {
                return false;
            }

            return this._repository.Update(cliente);
        }

        public Cliente ObtenerClientePorId(int id)
        {
            return this._repository.GetById(id);
        }
    }
}
