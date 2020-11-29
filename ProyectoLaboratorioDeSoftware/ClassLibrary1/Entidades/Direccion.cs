using Dominio.Entidades;
using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Direccion : IEntity
    {

        public int id { get; set; }
        public int fkClients { get; set; }
        public string Calle { get; set; }
        public int Altura { get; set; }


        public bool Validate()
        {
            bool isValidStreet = Regex.IsMatch(
                this.Calle,
                @"^(?![\s.]+$)[a-zA-Z\s.]*$",
                RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.CultureInvariant
            );

            if (this.Calle == String.Empty || isValidStreet == false)
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
