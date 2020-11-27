using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Entidades
{
    class Direccion : IEntity
    {

        public int id { get; set; }
        public int fkClients { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }


        public bool Validate()
        {
            if (Calle != String.Empty)
            {

                return false;
            }
            return true;
        }

        public bool Guardar()
        {
            //insert into;
            return true;
        }





    }
}
