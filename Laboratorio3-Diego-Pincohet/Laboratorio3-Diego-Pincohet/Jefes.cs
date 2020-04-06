using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_Diego_Pincohet
{
    class Jefes: Empleados
    {
        public override int Sueldo { get; set; }
        public override string Horario_de_Trabajo { get; set; }
        public override string Puesto_de_Trabajo { get; set; }
        public override int Buen_Trabajo { get; set; }

        public Jefes(string name,string lastname,string rut, string date_of_birth, string nacionality, int sueldo, string horario, int buen_trabajo)
        {
            this.Nombre = name;
            this.Apellido = lastname;
            this.Rut = rut;
            this.Fecha_de_Nacimiento = date_of_birth;
            this.Nacionalidad = nacionality;
            this.Sueldo = sueldo;
            this.Horario_de_Trabajo = horario;
            this.Buen_Trabajo = buen_trabajo;
        }

        public int Cambiar_Sueldo()
        {
            if (Buen_Trabajo > 10)
            {
                int nuevo_sueldo = Sueldo + 1000;
                Buen_Trabajo = 0;
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

        public string Cambiar_horario(string posible_horario, string problema)
        {
            if (Buen_Trabajo > 10 || problema == "Universidad" || problema == "Medico")
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
        public string Info_Jefe()
        {
            string info = Nombre + " " + Apellido + " " + Rut + " " + Fecha_de_Nacimiento + " " + Nacionalidad + " " + Sueldo + " " + Horario_de_Trabajo + " " + Puesto_de_Trabajo + ".";
            return info;
        }
    }
}
