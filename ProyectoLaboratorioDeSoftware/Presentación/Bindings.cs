using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentación
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<Dominio.Repositorio.IRepository<Dominio.Entidades.Cliente>>().To<InfraestructuraPersistencia.MySQL.ClienteRepositorio>();
        }
    }
}
