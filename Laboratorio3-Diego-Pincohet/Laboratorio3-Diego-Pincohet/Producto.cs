using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_Diego_Pincohet
{
    class Producto
    {
        private string Precio;
        private string Nombre;
        private string Marca;
        private string Stock_disponible;
        private string Fecha_compra;

        public Producto(string nombre, string precio, string marca, string stock_disponible, string fecha_compra)
        {
            this.Nombre = nombre;
            this.Precio = precio;
            this.Marca = marca;
            this.Stock_disponible = stock_disponible;
            this.Fecha_compra = fecha_compra;
        }

        
    }
}
