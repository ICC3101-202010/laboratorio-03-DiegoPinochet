using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_Diego_Pincohet
{
    class Jefes: Persona, IEmpleados
    {
        public int Sueldo { get => Sueldo; set => Sueldo = value; }
        public string Puesto_de_Trabajo { get => Puesto_de_Trabajo; set => Puesto_de_Trabajo = value; }
        public string Horario_de_Trabajo { get => Horario_de_Trabajo; set => Horario_de_Trabajo = value; }
        public int Buen_Trabajo { get => Buen_Trabajo; set => Buen_Trabajo = value; }

        public int Cambiar_Sueldo()
        {
            if (Buen_Trabajo > 10)
            {
                int nuevo_sueldo = Sueldo + 1000;
                return nuevo_sueldo;
            }
            else if (Buen_Trabajo == 10)
            {
                int nuevo_sueldo = Sueldo;
                return nuevo_sueldo;
            }
            else
            {
                int nuevo_sueldo = Sueldo - 1000;
                return nuevo_sueldo;
            }

        }
        public string Cambiar_Trabajo()
        {
            //No se si ponerlos en jefe o no
        }

        public string Cambiar_horario(string posible_horario, int ventas, string problema)
        {
            if (ventas > 10 || problema == "Universidad" || problema == "Medico")
            {
                string nuevo_horario = posible_horario;
                return nuevo_horario;
            }
            else
            {
                Console.WriteLine("No podemos cambiar tu horario");
                string nuevo_horario = Horario_de_Trabajo;
                return nuevo_horario;
            }
        }
    }
}
