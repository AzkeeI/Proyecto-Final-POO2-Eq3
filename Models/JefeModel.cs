using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalPOO2.Models
{
    public class JefeModel
    {
        public Guid Id { get; set; }
        public string NombreJefe { get; set; }
        public string Departamento  { get; set; }
         [DisplayFormat(DataFormatString = "{0:C}")]

        public int  Sueldo { get; set; }

       

    }
}