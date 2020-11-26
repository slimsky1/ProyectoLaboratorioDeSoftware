using Aplicacion;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentación
{
    class Program
    {
        static void Main(string[] args)
        {

            /*ClienteServicio cs = new ClienteServicio();
            cs.Guardar("Josue");*/

            ClienteServicio cs = new ClienteServicio();
            DireccionServicio ds = new DireccionServicio();

            //Boolean eliminado = cs.Eliminar(1);
            //Boolean insertado = cs.Guardar("Gabriela");

            //List<Cliente> listado = cs.Listar();

            //Console.WriteLine(listado[0].Nombre);

            //Console.WriteLine(insertado);

            //List<Cliente> listado = cs.Listar();
            //foreach (Cliente c in listado)
            //{
            //    Console.WriteLine(c.id + " " + c.Nombre);
            //}

            //Console.WriteLine();

            //List<Cliente> listadoaux = cs.Listar();
            //foreach (Cliente c in listadoaux)
            //{
            //    Console.WriteLine(c.id + " " + c.Nombre);
            //}
            //Console.ReadLine();

            //Cliente cliente = cs.ObtenerClientePorId(2);
            //Console.WriteLine(cliente.id + " " + cliente.Nombre);
            //Console.ReadLine();

            //Cliente cliente = new Cliente();
            //cliente.id = 6;
            //cliente.Nombre = "Florencia";
            //Boolean modificado = cs.Modificar(cliente);

            //Console.WriteLine(modificado);
            //Console.ReadLine();

            //Boolean insertDireccion = ds.Guardar(2, "Ecuador", 123);
            //Console.WriteLine(insertDireccion);

            Boolean deleteDireccion = ds.Eliminar(1);
            Console.WriteLine(deleteDireccion);
            Console.ReadLine();

        }
    }
}
