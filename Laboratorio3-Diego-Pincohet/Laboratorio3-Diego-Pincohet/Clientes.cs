using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_Diego_Pincohet
{
    class Clientes: Persona
    {
        private List<Producto> Carrito_de_Compras;
        private int Mi_Dinero;

        public Clientes(string name, string lastname, string rut, string date_of_birth, string nacionality, int mi_dinero, List<Producto> carrito_de_compras)
        {
            this.Nombre = name;
            this.Apellido = lastname;
            this.Rut = rut;
            this.Fecha_de_Nacimiento = date_of_birth;
            this.Nacionalidad = nacionality;
            this.Mi_Dinero = mi_dinero;
            this.Carrito_de_Compras = carrito_de_compras;

        }

        public List<Producto> Agregar_Producto(Producto producto, Stock stock, int Cantidad_de_Productos)
        {  
            if (stock.Esta_en_Stock(producto, Cantidad_de_Productos) == true)
            {
                for(int x = 0; x < Cantidad_de_Productos; x++)
                {
                    Carrito_de_Compras.Add(producto);
                }
                return Carrito_de_Compras;
            }
            else
            {
                List<Producto> Carrito_de_Compras = new List<Producto>();
                return Carrito_de_Compras;
            }
;
        }

        public int Mi_Efectivo()
        {
            int dinero = Mi_Dinero;
            return dinero;
        }
        public void New_Dinero(Producto producto, int Cant)
        {
            Mi_Dinero = Mi_Dinero - (producto.Price() * Cant);
        }
        public string Mi_nombre()
        {
            string name = Nombre + " " + Apellido;
            return name;
        }
        public string Info_Clientes()
        {
            string info = Nombre + " " + Apellido + " " + Rut + " " + Fecha_de_Nacimiento + " " + Nacionalidad + " " + Mi_Dinero;
            return info;
        }
        
    }
}
