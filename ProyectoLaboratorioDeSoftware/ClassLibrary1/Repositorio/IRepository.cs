
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repositorio
{
   public interface IRepository
    {
        List<Cliente> GetAll();
         Cliente GetById();
        bool Insert(Cliente cliente);
        bool Update(Cliente cliente);
        bool Delete(int id);
    }
}
