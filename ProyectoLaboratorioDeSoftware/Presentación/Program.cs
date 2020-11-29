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


            // Listar Clientes
            List<Cliente> listado = cs.Listar();
            imprimirListadoClientes(listado);

            // Obtener cliente por id
            //Cliente clienteById = cs.ObtenerClientePorId(2);
            //Console.WriteLine(clienteById.id + " " + clienteById.Nombre);

            // Agregar cliente
            //bool agregarCliente = cs.Guardar("Camila");
            //imprimirMensaje(agregarCliente);

            // Modificar cliente
            //bool modificarCliente = cs.Modificar(9, "Norma");
            //imprimirMensaje(modificarCliente);

            // Borrar cliente
            //bool eliminarCliente = cs.Eliminar(8);
            //if(eliminarCliente)
            //{
            //    Console.WriteLine("Exito al eliminar cliente");
            //} else {
            //    Console.WriteLine("Error al eliminar cliente");
            //}






            // Listar Direcciones
            List<Direccion> listdir = ds.Listar();
            imprimirListadoDirecciones(listdir);

            // Agregar direccion
            //bool agregarDireccion = ds.Guardar(9, "Santa Fe", 123);
            //imprimirMensaje(agregarDireccion);

            // Modificar direccion
            //bool modificarDireccion = ds.Modificar(4, "Ecuador", 1258);
            //imprimirMensaje(modificarDireccion);

            // Borrar direccion
            //bool eliminarDireccion = ds.Eliminar(4);
            //imprimirMensaje(eliminarDireccion);

            Console.ReadLine();
        }

        public static void imprimirMensaje(bool resultado)
        {
            if(resultado)
            {
                Console.WriteLine("Operación exitosa!");
            } else {
                Console.WriteLine("Error al realizar la operación");
            }
            Console.WriteLine();
        }

        public static void imprimirListadoClientes(List<Cliente> lista)
        {
            Console.WriteLine("{0,-4}{1,-10}", "id", "Nombre");
            Console.WriteLine("--------------");
            foreach (Cliente cliente in lista)
            {
                Console.WriteLine("{0,-4}{1,-10}",cliente.id, cliente.Nombre);
            }
            Console.WriteLine();
        }

        public static void imprimirListadoDirecciones(List<Direccion> lista)
        {
            Console.WriteLine("{0,-4}{1,-11}{2,-10}{3,-6}", "id", "fkClients", "Calle", "Altura");
            Console.WriteLine("----------------------------------");
            foreach (Direccion direccion in lista)
            {
                Console.WriteLine("{0,-4}{1,-11}{2,-10}{3,-6}", direccion.id, direccion.fkClients, direccion.Calle, direccion.Altura);
            }
            Console.WriteLine();
        }
    }
}
