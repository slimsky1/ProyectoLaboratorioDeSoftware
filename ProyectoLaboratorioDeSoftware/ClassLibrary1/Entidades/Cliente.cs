using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dominio.Entidades
{

   public class Cliente : IEntity
    {
        public int id  {get; set;}
        public string Nombre { get; set; }



        public bool Validate()
        {
            bool isValidName = Regex.IsMatch(
                this.Nombre,
                "^[a-zA-Z]+$",
                RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.CultureInvariant
            );

            if (this.Nombre == String.Empty || isValidName == false)
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
