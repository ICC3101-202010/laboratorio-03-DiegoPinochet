using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_Diego_Pincohet
{
    class Auxiliar: Empleados
    {
        public override int Sueldo { get; set; }
        public override string Horario_de_Trabajo { get; set; }
        public override string Puesto_de_Trabajo { get; set; }
        public override int Buen_Trabajo { get; set; }

        public Auxiliar(string name, string lastname, string rut, string date_of_birth, string nacionality, int sueldo, string horario, string puesto, int buen_trabajo)
        {
            this.Nombre = name;
            this.Apellido = lastname;
            this.Rut = rut;
            this.Fecha_de_Nacimiento = date_of_birth;
            this.Nacionalidad = nacionality;
            this.Sueldo = sueldo;
            this.Horario_de_Trabajo = horario;
            this.Puesto_de_Trabajo = puesto;
            this.Buen_Trabajo = buen_trabajo;

        }

        public void Limpiar()
        {
            Console.WriteLine("Ire a limpiar el supermercado.");
            Buen_Trabajo += 1;
        }
    }
}
