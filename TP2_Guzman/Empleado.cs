﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2_Guzman
{
    public class Empleado:Persona
    {
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public List<TipoUsuario> TipoUsuarios { get; set; }
    }
}
