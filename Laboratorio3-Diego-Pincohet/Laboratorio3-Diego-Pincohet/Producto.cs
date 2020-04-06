using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_Diego_Pincohet
{
    class Producto
    {
        private int Precio;
        private string Nombre;
        private string Marca;
        private int Stock_disponible;

        public Producto(int precio, string nombre, string marca, int stock_disponible)
        {
            this.Precio = precio;
            this.Nombre = nombre;
            this.Marca = marca;
            this.Stock_disponible = stock_disponible;
        }
        public string Info_Producto()
        {
            string Info = Nombre + " " + Marca;
            return Info;
        }
        public int Price()
        {
            int info_price = Precio;
            return info_price;
        }
        public int _Stock_disponible()
        {
            int Almacen = Stock_disponible;
            return Almacen;
        }
        public void Nuevo_stock(int Cantidad)
        {
            Stock_disponible = Stock_disponible - Cantidad;
        }
        public string Info_product()
        {
            string info = Nombre + " " + Marca + " " + Precio+ " "+ Stock_disponible + ".";
            return info;
            
        }
    }
}
