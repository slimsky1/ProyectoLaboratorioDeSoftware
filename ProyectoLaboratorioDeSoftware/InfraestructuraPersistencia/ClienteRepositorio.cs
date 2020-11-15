using Dominio.Entidades;
using Dominio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfraestructuraPersistencia
{
    public class ClienteRepositorio : IRepository
    {
        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Cliente> GetAll()
        {
            throw new NotImplementedException();
        }

        public Cliente GetById()
        {
            throw new NotImplementedException();
        }

        public bool Insert(Cliente cliente)
        {
            return true;
        }

        public bool Update(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
