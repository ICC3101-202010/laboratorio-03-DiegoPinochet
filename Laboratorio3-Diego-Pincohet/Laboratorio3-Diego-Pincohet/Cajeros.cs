using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_Diego_Pincohet
{
    class Cajeros: Empleados
    {
        private string Horario_compra;

        public string _Horario_compra { get => Horario_compra; set => Horario_compra = value; }

        public int Cuanto_Saldra(List<Producto> Carrito)
        {
            int dinero = 0;
            for (int i = 0; i < Carrito.Count; i++)
            {
                dinero = dinero + Carrito[i]._Precio;
            }
            _Buen_Trabajo = _Buen_Trabajo + 1;
            return dinero;
            
        }
        public bool Pagar(int total_a_pagar, Clientes cliente)
        {
            int mi_dinero = cliente._Mi_Dinero;

            if (total_a_pagar == mi_dinero)
            {
                //Poner el horario de compra
                return true;
            }
            else if (total_a_pagar < mi_dinero)
            {
                //Horario de compra
                Console.WriteLine("Su vuelto es de: " + (mi_dinero - total_a_pagar));
                return true;
            }
            else
            {
                Console.WriteLine("Excede Máximo...");
                return false;
            }
            
        } //No se si hacer una classe "Computador" que lleve el registro de compras(lista de productos, hora, nombre cliente)
          // o ponerlo en Cajero.

    }
}
