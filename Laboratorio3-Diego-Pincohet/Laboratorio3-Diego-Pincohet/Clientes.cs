using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_Diego_Pincohet
{
    class Clientes:Persona
    {
        private string Carrito_de_Compras;
        public string _Carrito_de_Compras { get => Carrito_de_Compras; set => Carrito_de_Compras = value; }
       
        private int Mi_Dinero;
        public int _Mi_Dinero { get => Mi_Dinero; set => Mi_Dinero = value; }



        public List<Producto> Agregar_Producto(Producto producto, List<Producto> Carrito, Stock stock, int Cantidad_de_Productos)
        {
            if(stock.Esta_en_Stock(producto, Cantidad_de_Productos) == true)
            {
                Carrito.Add(producto);
                return Carrito;
            }
            else
            {
                return Carrito;
            }
;
        }
        
    }
}
