using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalPOO2.Entities
{
    public class Jefe
    {
         public Guid Id { get; set; }
        public string NombreJefe { get; set; }
        public string Departamento  { get; set; }

        public int  Sueldo { get; set; }
    }
}