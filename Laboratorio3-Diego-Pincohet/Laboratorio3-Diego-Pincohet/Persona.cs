using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_Diego_Pincohet
{
    public class Persona
    {
        private string Rut;
        public string _Rut { get => Rut; set => Rut = value; }

        private string Nombre;
        public string _Nombre { get => Nombre; set => Nombre = value; }

        private string Apellido;
        public string _Apellido { get => Apellido; set => Apellido = value; }

        private string Fecha_de_nacimiento;
        public string _Fecha_de_nacimiento { get => Fecha_de_nacimiento; set => Fecha_de_nacimiento = value; }

        private string Nacionalidad;
        public string _Nacionalidad { get => Nacionalidad; set => Nacionalidad = value; }
    }
}
