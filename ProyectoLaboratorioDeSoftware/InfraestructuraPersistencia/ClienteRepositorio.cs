using Dominio.Entidades;
using Dominio.Repositorio;
using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace InfraestructuraPersistencia
{
    public class ClienteRepositorio : IRepository<Cliente>
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
            throw new NotImplementedException();
        }

        public bool Update(Cliente cliente)
        {
            throw new NotImplementedException();
        }
    }
}
