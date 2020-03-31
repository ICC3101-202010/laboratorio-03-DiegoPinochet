using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_Diego_Pincohet
{
    public class Empleados : Persona
    {
        private int Sueldo;
        public int _Sueldo { get => Sueldo; set => Sueldo = value; }

        private string Puesto_de_Trabajo;
        public string _Puesto_de_Trabajo { get => Puesto_de_Trabajo; set => Puesto_de_Trabajo = value; }

        private string Horario_de_Trabajo;
        public string _Horario_de_Trabajo { get => Horario_de_Trabajo; set => Horario_de_Trabajo = value; }

        public int Cambiar_Sueldo(int ventas)
        {
            if (ventas > 10)
            {
                int nuevo_sueldo = _Sueldo + 1000;
                return nuevo_sueldo;
            }
            else if (ventas == 10)
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

        }

        public string Cambiar_horario(string posible_horario, int ventas, string problema)
        {
            if(ventas > 10 || problema == "Universidad" || problema == "Medico")
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
