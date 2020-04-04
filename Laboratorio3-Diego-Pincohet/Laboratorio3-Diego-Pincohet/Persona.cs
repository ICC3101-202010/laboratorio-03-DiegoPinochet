using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_Diego_Pincohet
{
    public class Persona
    {
        protected string Rut;
        protected string Nombre;
        protected string Apellido;
        protected string Fecha_de_Nacimiento;
        protected string Nacionalidad;

        public void Show(List<String> lista)
        {
            for(int i = 0; i < lista.Count(); i++)
            {
                Console.WriteLine(lista[i]);
            }
        }
    }
}
