using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_Diego_Pincohet
{
    interface IEmpleados
    {

        int Sueldo { get; set; }
        string Puesto_de_Trabajo { get; set; }
        string Horario_de_Trabajo { get; set; }
        int Buen_Trabajo { get; set; } //Todos parten con _Buen_Trabajao = 0 en el main.


        //no se si ponerle los métodos del jefe aca, ya que este podria ser una interfaz.
    }
}
