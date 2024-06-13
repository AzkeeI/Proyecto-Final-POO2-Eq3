using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalPOO2.Models
{
    public class datosEmpleadoModel
    {
       
        public Guid Id { get; set; }

        public string Nombre { get; set; }

        public string Departamento { get; set; }

        public string Turno { get; set; }

        public DateTime FechaEntrada { get; set; }

        public DateTime FechaBaja { get; set; }

        public string TiempoActivo { get; set; }
    }
}