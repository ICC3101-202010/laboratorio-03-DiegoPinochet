using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_Diego_Pincohet
{
    class Persona
    {
        private string Rut;
        private string Nombre;
        private string Apellido;
        private string Fecha_de_nacimiento;
        private string Nacionalidad;
        private string Puesto_de_trabajo;

        public Persona(string nombre,string apellido, string rut, string fecha_de_nacimiento, string nacionalidad, string puesto_de_trabajo) 
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Rut = rut;
            this.Fecha_de_nacimiento = fecha_de_nacimiento;
            this.Nacionalidad = nacionalidad;
            this.Puesto_de_trabajo = puesto_de_trabajo;
        }

        public string Cambiar_Trabajo()
        {

        }
        public string Cambiar_Sueldo()
        {

        }
        public string Cambiar_horario()
        {

        }
    }
}
