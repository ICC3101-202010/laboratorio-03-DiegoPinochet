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
        private string Fechas_compra;

        public Producto(int precio, string nombre, string marca, int stock_disponible, string fecha_compra)
        {
            this.Precio = precio;
            this.Nombre = nombre;
            this.Marca = marca;
            this.Stock_disponible = stock_disponible;
            this.Fecha_compra = fecha_compra;
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





    }
}
