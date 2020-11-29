using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.Entidades;
using Dominio.Repositorio;
using InfraestructuraPersistencia;
using InfraestructuraPersistencia.MySQL;

namespace Aplicacion
{
   public class DireccionServicio
    {
        private IRepositoryDireccion<Direccion> _repository;

        public DireccionServicio(IRepositoryDireccion<Direccion> repository)
        {
            this._repository = repository;
        }
        
        public List<Direccion> Listar()
        {
            return this._repository.GetAll();
        }


        public bool Guardar(int fkclients, String calle, int altura)
        {

            Direccion direccion = new Direccion();
            direccion.fkClients = fkclients;
            direccion.Calle = calle;
            direccion.Altura = altura;
            
            if (direccion.Validate() == false)
            {
                return false;
            }
            return this._repository.Insert(direccion);
        }

        public bool Eliminar(int id)
        {
            return this._repository.Delete(id);
        }

        public bool Modificar(int id, String calle, int altura)
        {
            Direccion direccion = new Direccion();
            direccion.id = id;
            direccion.Calle = calle;
            direccion.Altura = altura;
           
            if(direccion.Validate() == false)
            {
                return false;
            }

            return this._repository.Update(direccion);
        }

        public Direccion ObtenerClientePorId(int id)
        {
            return this._repository.GetById(id);
        }


    



    }
}
