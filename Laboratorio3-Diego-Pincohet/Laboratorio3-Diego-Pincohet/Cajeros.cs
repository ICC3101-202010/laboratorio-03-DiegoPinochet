using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_Diego_Pincohet
{
    class Cajeros: IEmpleados
    {
        private string Horario_compra;

        public Cajeros(string horario_de_compra)
        {
            this.Horario_compra = horario_de_compra;
        }

        public int Sueldo { get => Sueldo; set => Sueldo = value; }
        public string Puesto_de_Trabajo { get => Puesto_de_Trabajo; set => Puesto_de_Trabajo = value; }
        public string Horario_de_Trabajo { get => Horario_de_Trabajo; set => Horario_de_Trabajo = value; }
        public int Buen_Trabajo { get => Buen_Trabajo; set => Buen_Trabajo = value; }

        public int Cuanto_Saldra(List<Producto> Carrito) // El carrito que sale del metodo cliente.Agregar()
        {
            int dinero = 0;
            for (int i = 0; i < Carrito.Count; i++)
            {
                dinero = dinero + Carrito[i].Price();
            }
            Buen_Trabajo = Buen_Trabajo + 1;
            return dinero;
            
        }
        public List<String> Pagar(int total_a_pagar, Clientes cliente, Producto producto, List<Producto> Carrito,List<String> Registro_compras)
        {
            int mi_dinero = cliente.Mi_Efectivo();

            for (int i = 0; i < Carrito.Count; i++)
            {

                if (total_a_pagar == mi_dinero)
                {

                    Registro_compras.Add(cliente.Mi_nombre());
                    Registro_compras.Add(Carrito[i].Info_Producto());
                    //Poner el horario de compra
                }
                else if (total_a_pagar < mi_dinero)
                {
                    Registro_compras.Add(cliente.Mi_nombre());
                    Registro_compras.Add(Carrito[i].Info_Producto());
                    //Poner el horario de compra

                    Console.WriteLine("Su vuelto es de: " + (mi_dinero - total_a_pagar));
                }
                else
                {
                    Console.WriteLine("Excede Máximo...");
                }
            }
            return Registro_compras;
        } 
        
        public List<String> Ver_Registro_Compras(List<String> Registro_compras) //L
        {
            List<String> ver_compras;
            for(int x = 0; x < Registro_compras.Count; x++)
            {
                ver_compras.Add(Registro_compras[x]);
                return ver_compras;
            }



        }
        
        //No se si hacer una classe "Computador" que lleve el registro de compras(lista de productos, hora, nombre cliente)
          // o ponerlo en Cajero.

    }
}
