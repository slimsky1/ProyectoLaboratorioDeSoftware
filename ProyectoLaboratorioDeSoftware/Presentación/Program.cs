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
            List<Cliente> listado = cs.Listar();


            Cliente idGet = cs.ObtenerClientePorId(2);
            Cliente id2Get = cs.ObtenerClientePorId(3);

            Console.WriteLine("Valor Cliente: " + idGet.Nombre);
            Console.WriteLine("Valor Cliente 2: " + id2Get.Nombre);

            //cs.Guardar("Carlos");



            //cs.Eliminar(4);


            foreach (Cliente item in listado)
                {
                    Console.WriteLine(item.id + " " + item.Nombre);
                }

                Console.ReadLine();
        }
    }
}
