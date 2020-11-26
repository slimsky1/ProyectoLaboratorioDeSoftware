
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Repositorio
{
   public interface IRepositoryDireccion<T> where T : Direccion
    {
        List<T> GetAll();
        T GetById(int id);
        bool Insert(T direccion);
        bool Update(T direccion);
        bool Delete(int id);
    }
}
