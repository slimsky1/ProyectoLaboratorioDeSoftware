﻿using Aplicacion;
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

            ClienteServicio cs = new ClienteServicio();
            cs.Guardar("Josue");
        }
    }
}
