using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_Diego_Pincohet
{
     abstract class Empleados:Persona
    {
        public abstract int Sueldo { get; set; }
        public abstract string Horario_de_Trabajo { get; set; }
        public abstract string Puesto_de_Trabajo { get; set; }
        public abstract int Buen_Trabajo { get; set; }

    }
}
