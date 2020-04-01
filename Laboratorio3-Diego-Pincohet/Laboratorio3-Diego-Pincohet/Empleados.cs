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

        private int Buen_Trabajo;
        public int _Buen_Trabajo { get => Buen_Trabajo; set => Buen_Trabajo = value; } //Todos parten con _Buen_Trabajao = 0 en el main.

       
    }
}
