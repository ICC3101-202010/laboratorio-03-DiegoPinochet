using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_Diego_Pincohet
{
    class Jefes: Empleados
    {
        public int Cambiar_Sueldo()
        {
            if (_Buen_Trabajo > 10)
            {
                int nuevo_sueldo = _Sueldo + 1000;
                return nuevo_sueldo;
            }
            else if (_Buen_Trabajo == 10)
            {
                int nuevo_sueldo = _Sueldo;
                return nuevo_sueldo;
            }
            else
            {
                int nuevo_sueldo = _Sueldo - 1000;
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
                string nuevo_horario = _Horario_de_Trabajo;
                return nuevo_horario;
            }
        }
    }
}
