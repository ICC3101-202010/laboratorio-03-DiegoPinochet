using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_Diego_Pincohet
{
    class Stock:Empleados
    {
        public bool Esta_en_Stock(Producto producto, int Cantidad)
        {
            if(producto._Stock_disponible != 0 && producto._Stock_disponible > Cantidad)
            {
                producto._Stock_disponible = producto._Stock_disponible - Cantidad;
                _Buen_Trabajo = _Buen_Trabajo + 1;
                return true;
            }
            else
            {
                Console.WriteLine(producto._Nombre + " no esta en stock o queda menos de la cantidad que pidió.");
                Console.WriteLine("Iremos a buscar más");
                producto._Stock_disponible = producto._Stock_disponible + Cantidad;
                Console.WriteLine("Intentelo de nuevo.");
                return false;
            }
            
        }
    }
}
