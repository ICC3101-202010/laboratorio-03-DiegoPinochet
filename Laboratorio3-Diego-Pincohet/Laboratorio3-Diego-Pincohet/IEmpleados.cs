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

        public string Cambiar_Trabajo()
        {
            Console.WriteLine("A que trabajo quieres cambiar? (Stock, Cajero, Auxiliar)");
            string trabajo = Console.ReadLine();
            if (trabajo == "Stock")
            {
                Puesto_de_Trabajo = trabajo;
                return Puesto_de_Trabajo;
            }
            else if (trabajo == "Cajero")
            {
                Puesto_de_Trabajo = trabajo;
                return Puesto_de_Trabajo;
            }
            else
            {
                Puesto_de_Trabajo = trabajo;
                return Puesto_de_Trabajo;
            }
        }

    }
}
