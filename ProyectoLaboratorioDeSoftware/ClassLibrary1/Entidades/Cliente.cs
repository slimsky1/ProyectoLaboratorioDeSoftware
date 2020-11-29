using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{

   public class Cliente : IEntity
    {
        public int id  {get; set;}
        public string Nombre { get; set; }



        public bool Validate()
        {
            if(this.Nombre == String.Empty)
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
