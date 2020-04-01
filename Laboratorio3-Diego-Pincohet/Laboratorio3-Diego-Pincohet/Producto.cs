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
        public int _Precio { get => Precio; set => Precio = value; }

        private string Nombre;
        public string _Nombre { get => Nombre; set => Nombre = value; }

        private string Marca;
        public string _Marca { get => Marca; set => Marca = value; }

        private int Stock_disponible;
        public int _Stock_disponible { get => Stock_disponible; set => Stock_disponible = value; }

        private string Fecha_compra;
        public string _Fecha_compra { get => Fecha_compra; set => Fecha_compra = value; }

        public string Info_Producto()
        {
            string Info = _Nombre + " " + _Marca;
            return Info;
        }





    }
}
