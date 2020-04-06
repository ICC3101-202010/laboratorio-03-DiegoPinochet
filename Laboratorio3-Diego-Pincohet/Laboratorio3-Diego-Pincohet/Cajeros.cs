using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_Diego_Pincohet
{
    class Cajeros: Empleados
    {
        public override int Sueldo { get; set; }
        public override string Horario_de_Trabajo { get; set; }
        public override string Puesto_de_Trabajo { get; set; }
        public override int Buen_Trabajo { get; set; }

        public Cajeros(string name, string lastname, string rut, string date_of_birth,string nacionality, int sueldo, string horario, string puesto, int buen_trabajo)
        {
            this.Nombre = name;
            this.Apellido = lastname;
            this.Rut = rut;
            this.Fecha_de_Nacimiento = date_of_birth;
            this.Nacionalidad = nacionality;
            this.Sueldo = sueldo;
            this.Horario_de_Trabajo = horario;
            this.Puesto_de_Trabajo = puesto;
            this.Buen_Trabajo = buen_trabajo;

        }

        public int Cuanto_Saldra(List<Producto> Carrito) // El carrito que sale del metodo cliente.Agregar()
        {
            int dinero = 0;
            for (int i = 0; i < Carrito.Count; i++)
            {
                int val = Carrito[i].Price();
                dinero += val;
            }
            Buen_Trabajo = Buen_Trabajo + 1;
            return dinero;
            
            
            
            
        }
        public List<String> Pagar(int total_a_pagar, Clientes cliente, Producto producto, List<Producto> Carrito, List<String> Registro_compras,int Cantidad) //total_a_pagar viene de Cuanto_saldra()
        {
            int mi_dinero = cliente.Mi_Efectivo();
            string time = "Fecha: "+ DateTime.Today.ToShortDateString() + " Hora:" + DateTime.Now.ToShortTimeString();

            if (total_a_pagar == mi_dinero)
            {
                Registro_compras.Add("Nombre Cliente: " + cliente.Mi_nombre());
                Registro_compras.Add("Productos: ");
                for (int i = 0; i < Carrito.Count; i++)
                {
                    Registro_compras.Add(Carrito[i].Info_Producto());
                }
                Registro_compras.Add("Fecha y hora: " + time);
                string Name = Nombre + " " + Apellido;
                Registro_compras.Add("Atendido por: " + Name);
                producto.Nuevo_stock(Cantidad);
                cliente.New_Dinero(Carrito[0], Cantidad);


                return Registro_compras;
            }
            else if (total_a_pagar < mi_dinero)
            {
                Registro_compras.Add("Nombre Cliente: " + cliente.Mi_nombre());
                Registro_compras.Add("Productos: ");
                for (int i = 0; i < Carrito.Count; i++)
                {
                    Registro_compras.Add(Carrito[i].Info_Producto());
                    cliente.New_Dinero(Carrito[i],Cantidad);

                }
                Registro_compras.Add("Fecha y hora: " + time);
                string Name = Nombre + " " + Apellido;
                Registro_compras.Add("Atendido por: " + Name);
                producto.Nuevo_stock(Cantidad);
                cliente.New_Dinero(Carrito[0], Cantidad);

                Console.WriteLine("Su vuelto es de: " + (mi_dinero - total_a_pagar));

                return Registro_compras;
            }
            else
            {
                Console.WriteLine("Excede Máximo... No se pudo realizar la compra de: " + cliente.Mi_nombre());
                return Registro_compras;
            }

        } 
        
        public void Ver_Registro_Compras(List<String> Registro_compras)
        {
            Console.WriteLine("\nRegistro de compras: ");
            if (Registro_compras.Count() != 0)
            {
                for (int x = 0; x < Registro_compras.Count; x++)
                {
                    Console.WriteLine(Registro_compras[x]);

                }
            }
            else
            {
                Console.WriteLine("");
            }
        }
    }
}
