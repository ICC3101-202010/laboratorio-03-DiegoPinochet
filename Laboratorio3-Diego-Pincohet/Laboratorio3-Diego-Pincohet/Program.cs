using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio3_Diego_Pincohet
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona person = new Persona();
            bool x = true;

            List<Clientes> lista_clientes = new List<Clientes>();
            List<Producto> lista_productos = new List<Producto>();
            List<Stock> lista_stock = new List<Stock>();
            List<Cajeros> lista_cajeros = new List<Cajeros>();
            List<Jefes> lista_jefes = new List<Jefes>();
            List<String> Registro_compras = new List<string>();


            while (x == true)
            {
                Console.WriteLine("Elige si quieres crear clientes(1), crear productos(2), crear empleados(3), empezar la simulación(4) o hacer una simulacion aleatoria(5).");
                string eleccion = Console.ReadLine();
                if (eleccion == "1")
                {
                    Console.WriteLine("Cuantos clientes quiere crear?");
                    int cant_clientes = int.Parse(Console.ReadLine());

                    for (int i = 0; i < cant_clientes; i++)        //creación clientes.
                    {
                        Console.WriteLine("Crea un cliente nuevo (nombre, apellido, rut, fecha de nacimiento, nacionalidad, dinero)\n");
                        string Name = Console.ReadLine();
                        string LastName = Console.ReadLine();
                        string Rut = Console.ReadLine();
                        string Año_de_Nacimiento = Console.ReadLine();
                        string Nacionalidad = Console.ReadLine();
                        int Dinero = int.Parse(Console.ReadLine());
                        List<Producto> Carrito_de_Compras = new List<Producto>();

                        Clientes clientes = new Clientes(Name, LastName, Rut, Año_de_Nacimiento, Nacionalidad, Dinero, Carrito_de_Compras);
                        lista_clientes.Add(clientes);
                    }
                }
                else if(eleccion == "2")
                {
                    Console.WriteLine("Cuantos productos quiere crear?");
                    int cant_productos = int.Parse(Console.ReadLine());

                    for (int i = 0; i < cant_productos; i++)        //creación productos.
                    {
                        Console.WriteLine("Crea un producto nuevo (nombre, marca, precio, stock disponible)\n");
                        string Name = Console.ReadLine();
                        string Marca = Console.ReadLine();
                        int Price = int.Parse(Console.ReadLine());
                        int Stock = int.Parse(Console.ReadLine());

                        Producto producto = new Producto(Price, Name, Marca, Stock);
                        lista_productos.Add(producto);
                    }
                }
                else if (eleccion == "3")
                {
                    Console.WriteLine("Qué tipo de empleado quieres crear? (Jefes, Cajeros, Stock)");
                    string empleado = Console.ReadLine();
                    if(empleado == "Jefes")
                    {
                        
                        for(int i = 0; i < 1; i++)
                        {
                            Console.WriteLine("Crea un jefe nuevo (nombre, apellido, rut, fecha de nacimiento, nacionalidad, sueldo, horario)\n"); //creación jefes
                            string Name = Console.ReadLine();
                            string LastName = Console.ReadLine();
                            string Rut = Console.ReadLine();
                            string Año_de_Nacimiento = Console.ReadLine();
                            string Nacionalidad = Console.ReadLine();
                            int Sueldo = int.Parse(Console.ReadLine());
                            string Horario = Console.ReadLine();
                            int Buen_trabajo = 0;

                            Jefes jefes = new Jefes(Name, LastName, Rut, Año_de_Nacimiento, Nacionalidad, Sueldo, Horario, Buen_trabajo);
                            lista_jefes.Add(jefes);
                            
                        }

                    }
                    else if(empleado == "Cajeros")
                    {
                        
                        Console.WriteLine("Cuantos Cajeros quiere crear?");
                        int cant_cajeros = int.Parse(Console.ReadLine());

                        for (int i = 0; i < cant_cajeros; i++)
                        {
                            Console.WriteLine("Crea un cajero nuevo (nombre, apellido, rut, fecha de nacimiento, nacionalidad, sueldo, horario)\n"); // creación cajeros
                            string Name = Console.ReadLine();
                            string LastName = Console.ReadLine();
                            string Rut = Console.ReadLine();
                            string Año_de_Nacimiento = Console.ReadLine();
                            string Nacionalidad = Console.ReadLine();
                            int Sueldo = int.Parse(Console.ReadLine());
                            string Horario = Console.ReadLine();
                            string Puesto = empleado;
                            int Buen_trabajo = 0;

                            Cajeros cajeros = new Cajeros(Name, LastName, Rut, Año_de_Nacimiento, Nacionalidad, Sueldo, Horario, Puesto, Buen_trabajo);
                            lista_cajeros.Add(cajeros);
                        }
                    }
                    else if(empleado == "Stock")
                    {
                        for (int i = 0; i < 1; i++)
                        {
                            Console.WriteLine("Crea un stock nuevo (nombre, apellido, rut, fecha de nacimiento, nacionalidad, sueldo, horario)\n"); // creación stock
                            string Name = Console.ReadLine();
                            string LastName = Console.ReadLine();
                            string Rut = Console.ReadLine();
                            string Año_de_Nacimiento = Console.ReadLine();
                            string Nacionalidad = Console.ReadLine();
                            int Sueldo = int.Parse(Console.ReadLine());
                            string Horario = Console.ReadLine();
                            string Puesto = empleado;
                            int Buen_trabajo = 0;
                            List<Producto> Carrito_de_Compras = new List<Producto>();

                            Stock stock = new Stock(Name, LastName, Rut, Año_de_Nacimiento, Nacionalidad, Sueldo, Horario, Puesto, Buen_trabajo, Carrito_de_Compras);
                            lista_stock.Add(stock);
                        }
                    }
                }
                else if (eleccion == "4")
                {
                    bool i = true;
                    
                    while(i == true)
                    {
                        Console.WriteLine("Qué cliente realizará la compra? cliente1(1), cliente2(2), etc.");
                        int client = int.Parse(Console.ReadLine());
                        Clientes cliente = lista_clientes[client-1];

                        Console.WriteLine("Aquí esta la lista de productos: ");

                        for(int u = 0; u < lista_productos.Count; u++)
                        {
                            Console.WriteLine(lista_productos[u].Info_Producto() + ". Su stock disponible es de: " + lista_productos[u]._Stock_disponible() + "\n");
                            continue;
                        }
                        Console.WriteLine("Qué producto desea comprar? producto1(1), producto2(2), etc.");
                        int product = int.Parse(Console.ReadLine());
                        Producto producto = lista_productos[product - 1];

                        Console.WriteLine("Cuantos productos de este tipo desea comprar? 1, 2, etc.");
                        int cant = int.Parse(Console.ReadLine());

                        List<Producto> lista_carrito = cliente.Agregar_Producto(producto, lista_stock[0] ,cant);

                        Console.WriteLine("Qué cajero realizará la venta? cajero1(1), cajero2(2), etc.");
                        int caj = int.Parse(Console.ReadLine());
                        Cajeros cajeros = lista_cajeros[caj - 1];

                        if (lista_carrito.Count != 0)
                        {
                            int total_a_pagar = cajeros.Cuanto_Saldra(lista_carrito);
                            List<String> Registro_de_compras = cajeros.Pagar(total_a_pagar, cliente, producto, lista_carrito, Registro_compras, cant);

                            cajeros.Ver_Registro_Compras(Registro_de_compras);
                        }
                        else
                        {
                            Console.WriteLine("Agregue elementos al carrito.");
                        }

                        Console.WriteLine("Quiere que otro cliente realice una compra? Si o No");
                        string dec = Console.ReadLine();
                        if(dec == "Si")
                        {
                            Console.WriteLine("-----------------------------------------------------------------------------\n");
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                else if(eleccion == "5")
                {
                    
                }
                else
                {
                    break;
                }
            }
        }
    }
}
