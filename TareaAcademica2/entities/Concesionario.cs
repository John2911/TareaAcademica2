using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TareaAcademica2.entities
{
    class Concesionario
    {
        public Concesionario() { }
        public String Codigo { get; set; }
        public String Persona { get; set; }
        public String Direccion { get; set; }
        public String Marca { get; set; }
        public double Precio { get; set; }
        public int Duracion { get; set; } 
    }
}
