using Aplicacion;
using Dominio.Entidades;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Presentación
{
    class Program
    {
        static void Main(string[] args)
        {

            var kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            var cs = kernel.Get<ClienteServicio>();
            var ds = kernel.Get<DireccionServicio>();

            Boolean deleteClient = cs.Eliminar(3);


            List <Cliente> listado = cs.Listar();

            foreach (Cliente item in listado)
            {
                Console.WriteLine(item.id + " " + item.Nombre);
            }

            Console.WriteLine();

            List<Direccion> listDir = ds.Listar();

            foreach (Direccion dir in listDir)
            {
                Console.WriteLine(dir.id + " " + dir.fkClients + " " + dir.Calle + " " + dir.Altura);
            }



            Console.ReadLine();
        }
    }
}
