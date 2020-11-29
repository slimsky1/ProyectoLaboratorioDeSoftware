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
            //IRepositoryDireccion<Direccion> repositorio = new InfraestructuraPersistencia.MySQL.DireccionRepositorio();
            return this._repository.GetAll();
        }


        public bool Guardar(int fkclients, String calle, int altura)
        {

            Direccion direccion = new Direccion();
            direccion.fkClients = fkclients;
            direccion.Calle = calle;
            direccion.Altura = altura;
            IRepositoryDireccion<Direccion> repositorio = new InfraestructuraPersistencia.MySQL.DireccionRepositorio();
            //if (cliente.validate() == false)
            //{
            //    return false;
            //}
            return repositorio.Insert(direccion);
        }

        public bool Eliminar(int id)
        {
            Direccion direccion = new Direccion();
            direccion.id = id;
            IRepositoryDireccion<Direccion> repositorio = new InfraestructuraPersistencia.MySQL.DireccionRepositorio();
            return repositorio.Delete(direccion.id);
        }

        public bool Modificar(Direccion direccion)
        {
            IRepositoryDireccion<Direccion> repositorio = new InfraestructuraPersistencia.MySQL.DireccionRepositorio();
            return repositorio.Update(direccion);
        }

        public Direccion ObtenerClientePorId(int id)
        {
            IRepositoryDireccion<Direccion> repositorio = new InfraestructuraPersistencia.MySQL.DireccionRepositorio();
            return repositorio.GetById(id);
        }


    



    }
}
