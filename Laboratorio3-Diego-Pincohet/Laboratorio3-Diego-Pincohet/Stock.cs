using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_Diego_Pincohet
{
    class Stock: Empleados
    {
        private List<Producto> Lista_productos = new List<Producto>();
        public override int Sueldo { get; set; }
        public override string Horario_de_Trabajo { get; set; }
        public override string Puesto_de_Trabajo { get; set; }
        public override int Buen_Trabajo { get; set; }

        public Stock(string name, string lastname, string rut, string date_of_birth, string nacionality, int sueldo, string horario, string puesto, int buen_trabajo, List<Producto> lista_productos)
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
            this.Lista_productos = lista_productos;    //Agregar todos los productos a esta lista.
        }

        public bool Esta_en_Stock(Producto producto, int Cantidad)
        {

            if((producto._Stock_disponible() != 0) && (producto._Stock_disponible() >= Cantidad))
            {
                Buen_Trabajo = Buen_Trabajo + 1;
                return true;
            }
            else
            {
                
                return false;
            }
            
        }
        public void Nuevo_stock(int Cantidad)
        {
            for(int x = 0; x < Lista_productos.Count; x++)
            {
                Console.WriteLine(Lista_productos[x].Info_Producto() + ". Su nuevo stock es de: " + Lista_productos[x]._Stock_disponible());
            } 
        }
    }
}
