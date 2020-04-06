using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_Diego_Pincohet
{
     abstract class Empleados:Persona
    {
        public abstract int Sueldo { get; set; }
        public abstract string Horario_de_Trabajo { get; set; }
        public abstract string Puesto_de_Trabajo { get; set; }
        public abstract int Buen_Trabajo { get; set; }

        public void Cambiar_Trabajo(string name, string lastname, string rut, string date_of_birth, string nacionality, int sueldo, string horario, string puesto, int buen_trabajo,List<Producto>lista_productos,List<Cajeros>lista_cajeros,List<Stock>lista_stock, List<Auxiliar>lista_auxiliar)
        {
            Console.WriteLine("A que trabajo quieres cambiar? (Stock, Cajero, Auxiliar)");
            string trabajo = Console.ReadLine();
            if (trabajo == "Stock")
            {
                Stock stock = new Stock(name, lastname, rut, date_of_birth, nacionality, sueldo, horario, puesto, buen_trabajo, lista_productos);
                lista_stock.Add(stock);
                
            }
            else if (trabajo == "Cajero")
            {
                Cajeros cajero = new Cajeros(name, lastname, rut, date_of_birth, nacionality, sueldo, horario, puesto, buen_trabajo);
                lista_cajeros.Add(cajero);
            }
            else
            {
                Auxiliar auxiliar = new Auxiliar(name, lastname, rut, date_of_birth, nacionality, sueldo, horario, puesto, buen_trabajo);
                lista_auxiliar.Add(auxiliar);
            }
        }

    }
}
