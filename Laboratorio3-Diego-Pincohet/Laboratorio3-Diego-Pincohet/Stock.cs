using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_Diego_Pincohet
{
    class Stock:IEmpleados
    {
        public int Sueldo { get => Sueldo; set =>  Sueldo = value; }
        public string Puesto_de_Trabajo { get => Puesto_de_Trabajo ; set => Puesto_de_Trabajo = value  ; }
        public string Horario_de_Trabajo { get => Horario_de_Trabajo; set => Horario_de_Trabajo = value; }
        public int Buen_Trabajo { get => Buen_Trabajo; set => Buen_Trabajo = value; }

        public bool Esta_en_Stock(Producto producto, int Cantidad)
        {
            int almacen = 0;

            if(producto._Stock_disponible() != 0 && producto._Stock_disponible() > Cantidad)
            {
                almacen = producto._Stock_disponible() - Cantidad;
                Buen_Trabajo = Buen_Trabajo + 1;
                return true;
            }
            else
            {
                Console.WriteLine(producto.Info_Producto() + " no esta en stock o queda menos de la cantidad que pidió.");
                Console.WriteLine("Iremos a buscar más");
                almacen = producto._Stock_disponible() + Cantidad;
                Console.WriteLine("Intentelo de nuevo.");
                return false;
            }
            
        }
    }
}
