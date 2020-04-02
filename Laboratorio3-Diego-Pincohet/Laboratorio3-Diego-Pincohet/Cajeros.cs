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
        private List<String> Registro_compras;
        public Cajeros(string horario_de_compra, List<String> registro_compras)
        {
            this.Horario_compra = horario_de_compra;
            this.Registro_compras = registro_compras;
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
        public List<String> Pagar(int total_a_pagar, Clientes cliente, Producto producto, List<Producto> Carrito)
        {
            int mi_dinero = cliente.Mi_Efectivo();
            string time = "Fecha: "+ DateTime.Today.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString();

            for (int i = 0; i < Carrito.Count; i++)
            {

                if (total_a_pagar == mi_dinero)
                {

                    Registro_compras.Add(cliente.Mi_nombre());
                    Registro_compras.Add(Carrito[i].Info_Producto());
                    Registro_compras.Add(time);
                }
                else if (total_a_pagar < mi_dinero)
                {
                    Registro_compras.Add(cliente.Mi_nombre());
                    Registro_compras.Add(Carrito[i].Info_Producto());
                    Registro_compras.Add(time);

                    Console.WriteLine("Su vuelto es de: " + (mi_dinero - total_a_pagar));
                }
                else
                {
                    Console.WriteLine("Excede Máximo...");
                }
            }
            return Registro_compras;
        } 
        
        public void Ver_Registro_Compras(List<String> Registro_compras)
        {
            Console.WriteLine("Registro de compras: \n");
            for (int x = 0; x < Registro_compras.Count; x++)
            {
                Console.WriteLine(Registro_compras[x]);
            }

        }
    }
}
