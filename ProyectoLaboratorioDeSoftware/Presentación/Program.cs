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

           

            //Boolean deleteClient = cs.Eliminar(3);


            List <Cliente> listado = cs.Listar();

            foreach (Cliente item in listado)
            {
                Console.WriteLine(item.id + " " + item.Nombre);
            }

            Console.WriteLine();
            // Obtener cliente por id
            Cliente clienteById = cs.ObtenerClientePorId(2);
            Cliente clienteById2 = cs.ObtenerClientePorId(6);
            Console.WriteLine(clienteById.id + " " + clienteById.Nombre);
            Console.WriteLine(clienteById2.id + " " + clienteById2.Nombre);

            Console.WriteLine();
            // Agregar cliente
           //  cs.Guardar("Camila");
            
            Console.WriteLine();
            // Modificar cliente
            // cs.Modificar(6, "Norma");
            

            Console.WriteLine();
            // Borrar cliente
             // cs.Eliminar(8);
            



            Console.WriteLine();

            List<Direccion> listDir = ds.Listar();

            foreach (Direccion dir in listDir)
            {
                Console.WriteLine(dir.id + " " + dir.fkClients + " " + dir.Calle + " " + dir.Altura);
            }


            // Agregar direccion
           // ds.Guardar(9, "Santa Fe", 123);
            

            // Modificar direccion
          //ds.Modificar(4, "Ecuador", 1258);
          

            // Borrar direccion
            // ds.Eliminar(4);
            


            Console.ReadLine();
        }
    }
}
