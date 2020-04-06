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
            List<Auxiliar> lista_auxiliar = new List<Auxiliar>();

            List<Clientes> list_clientes = new List<Clientes>();
            List<Producto> list_productos = new List<Producto>();
            List<Stock> list_stock = new List<Stock>();
            List<Cajeros> list_cajeros = new List<Cajeros>();
            List<Jefes> list_jefes = new List<Jefes>();
            List<String> registro_compras = new List<string>();
            List<Auxiliar> list_auxiliar = new List<Auxiliar>();


            while (x == true)
            {
                Console.WriteLine("Elige si quieres crear clientes(1), crear productos(2), crear empleados(3), utilizar metodos de cambio de sueldo, horario o puesto (4) empezar la simulación(5), hacer una simulacion aleatoria(6) o cerrar el programa(7).");
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
                    Console.WriteLine("Qué tipo de empleado quieres crear? (Jefes, Cajeros, Stock o Auxiliar)");
                    string empleado = Console.ReadLine();
                    if (empleado == "Jefes")
                    {

                        for (int i = 0; i < 1; i++)
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
                    else if (empleado == "Auxiliar")
                    {

                        Console.WriteLine("Cuantos Axuliares quiere crear?");
                        int cant_auxiliar = int.Parse(Console.ReadLine());

                        for (int i = 0; i < cant_auxiliar; i++)
                        {
                            Console.WriteLine("Crea un auxiliar nuevo (nombre, apellido, rut, fecha de nacimiento, nacionalidad, sueldo, horario)\n"); // creación auxiliar
                            string Name = Console.ReadLine();
                            string LastName = Console.ReadLine();
                            string Rut = Console.ReadLine();
                            string Año_de_Nacimiento = Console.ReadLine();
                            string Nacionalidad = Console.ReadLine();
                            int Sueldo = int.Parse(Console.ReadLine());
                            string Horario = Console.ReadLine();
                            string Puesto = empleado;
                            int Buen_trabajo = 0;

                            Auxiliar auxiliar = new Auxiliar(Name, LastName, Rut, Año_de_Nacimiento, Nacionalidad, Sueldo, Horario, Puesto, Buen_trabajo);
                            lista_auxiliar.Add(auxiliar);
                        }
                    }

                    else if (empleado == "Cajeros")
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
                    else if (empleado == "Stock")
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
                else if(eleccion == "4")
                {
                    Console.WriteLine("A que tipo de empleado quiere hacerle un cambio de atributos? (Cajeros, Stock o Auxiliar)");
                    string empleado = Console.ReadLine();
                    Console.WriteLine("Qué atributo quiere cambiar? (Sueldo, Horario o Puesto)");
                    string atributo = Console.ReadLine();
                    if (empleado == "Cajeros")
                    {
                        if(atributo == "Sueldo")
                        {
                            lista_jefes[0].Cambiar_Sueldo();
                        }
                        else if (atributo == "Horario")
                        {
                            Console.WriteLine("Cual es su propuesta de horario de trabajo?");
                            string posible_horario = Console.ReadLine();
                            Console.WriteLine("Porqué desea cambiar el horario? (Universidad, Medico, etc.)");
                            string problema = Console.ReadLine();
                            lista_jefes[0].Cambiar_horario(posible_horario, problema);
                        }
                        else
                        {
                            Console.WriteLine("A que cajero quiere cambiar de trabajo? (1,2,3,etc.)");
                            int num = int.Parse(Console.ReadLine());
                            lista_cajeros[num - 1].Cambiar_Trabajo();
                            lista_cajeros.RemoveAt(num - 1);
                        }
                    }

                    else if (empleado == "Stock")
                    {
                        if (atributo == "Sueldo")
                        {
                            lista_jefes[0].Cambiar_Sueldo();
                        }
                        else if (atributo == "Horario")
                        {
                            Console.WriteLine("Cual es su propuesta de horario de trabajo?");
                            string posible_horario = Console.ReadLine();
                            Console.WriteLine("Porqué desea cambiar el horario? (Universidad, Medico, etc.)");
                            string problema = Console.ReadLine();
                            lista_jefes[0].Cambiar_horario(posible_horario, problema);
                        }
                        else
                        {
                            Console.WriteLine("A que cajero quiere cambiar de trabajo? (1,2,3,etc.)");
                            int num = int.Parse(Console.ReadLine());
                            lista_stock[num - 1].Cambiar_Trabajo();
                            lista_stock.RemoveAt(num - 1);
                        }
                    }

                    else
                    {
                        if (atributo == "Sueldo")
                        {
                            lista_jefes[0].Cambiar_Sueldo();
                        }
                        else if (atributo == "Horario")
                        {
                            Console.WriteLine("Cual es su propuesta de horario de trabajo?");
                            string posible_horario = Console.ReadLine();
                            Console.WriteLine("Porqué desea cambiar el horario? (Universidad, Medico, etc.)");
                            string problema = Console.ReadLine();
                            lista_jefes[0].Cambiar_horario(posible_horario,problema);
                        }
                        else
                        {
                            Console.WriteLine("A que cajero quiere cambiar de trabajo? (1,2,3,etc.)");
                            int num = int.Parse(Console.ReadLine());
                            lista_auxiliar[num - 1].Cambiar_Trabajo();
                            lista_auxiliar.RemoveAt(num - 1);
                        }
                    }
                }
                else if (eleccion == "5")
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

                        List<Producto> lista_carrito = cliente.Agregar_Producto(producto, lista_stock[0], cant);   

                        if (lista_carrito.Count != 0)
                        {
                            Console.WriteLine("Qué cajero realizará la venta? cajero1(1), cajero2(2), etc.");
                            int caj = int.Parse(Console.ReadLine());
                            Cajeros cajeros = lista_cajeros[caj - 1];

                            int total_a_pagar = cajeros.Cuanto_Saldra(lista_carrito);
                            List<String> Registro_de_compras = cajeros.Pagar(total_a_pagar, cliente, producto, lista_carrito, Registro_compras, cant);

                            cajeros.Ver_Registro_Compras(Registro_de_compras);
                        }
                        else
                        {
                            Console.WriteLine(producto.Info_Producto() + " no esta en stock o queda menos de la cantidad que pidió. No se pudo agregar el producto.\n");
                            Console.WriteLine("No hay productos en el carro. No se pudo realizar la compra de: " + cliente.Mi_nombre());
                        }

                        if(lista_auxiliar.Count != 0)
                        {
                            lista_auxiliar[0].Limpiar();
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
                           Registro_compras.Clear();
                           lista_auxiliar.Clear();
                           lista_cajeros.Clear();
                           lista_clientes.Clear();
                           lista_jefes.Clear();
                           lista_productos.Clear();
                           lista_stock.Clear();
                           break;
                        }
                    }
                }
                else if(eleccion == "6")
                {
                    Random random = new Random();

                    List<string> nombres = new List<string>() {"Diego","Matias","Tomas","Pancho","Juan","Valeria","Valentina","Jacobo","Álvaro","Pablo" };
                    List<string> apellidos = new List<string>() {"Leguer","Giraldo","Ruiz-Tagle","Pinochet","Sinsay","Álvarez","Fuentes","Cabrera","Seguel","Nazal" };
                    List<string> rut = new List<string>() {"201827396","201827340","211837509","041826758","210978650","031763549","210349876","089767870","201837409","239017897","127368960","201827395","234009876","198076542","223009876"};
                    List<string> fecha_nacimiento = new List<string>() {"25-05-99","12-06-00","21-01-02","07-11-03","06-11-78" };
                    List<string> nacionalidad = new List<string>() {"Chilena","Argentina","Peruana","Americana","Colombiano" };
                    List<int> dinero = new List<int>() {5000,10000,15000,8000,2000 };

                    List<Producto> carrito = new List<Producto>(); // no se si hacerla de nuevo o dejarla

                    List<int> sueldos = new List<int>() {200,300,400,500 };
                    List<string> horario = new List<string>() {"11:30-20:30","8:30-15:30","15:30-22:30" };

                    List<Producto> stock_productos = new List<Producto>(); // no se si hacerla de nuevo o dejarla

                    int buen_trabajo = 0;
                    List<string> nombre_product = new List<string>() {"Snicker","Coca-Cola","Sprite","Fanta","MilkyWay","Twix","Chocapic","Fajitas","Zucaritas","Pillows","Powerade","Pan de molde","Marraqueta","Hallulla","Salsa","Coca-Cola light","Coca-cola zero","Coca-cola life","Fanta Zero","Sprite Zero","Aquarius","Vital","Cola-Cao","Nesquik","Milo","Froot Loops","Pan frica","Dobladita","Baguetta","Ciabatta" };
                    List<string> marca_product = new List<string>() {"Coca-Cola Company","Marse","Bimbo","Pancho Villa","Nestlé" }; // 5 marcas distintas
                    List<int> precio_product = new List<int>() {500, 1500, 3000, 3500, 4500,6000}; //6 precios distintos
                    List<int> stock_product = new List<int>() { 1, 2, 3, 4 };

                    Console.WriteLine("Clientes:");
                    for (int i = 0; i < 15; i++) //creación de clientes
                    {
                        Clientes clientes = new Clientes(nombres[random.Next(10)],apellidos[random.Next(10)],rut[random.Next(15)],fecha_nacimiento[random.Next(5)],nacionalidad[random.Next(5)],dinero[random.Next(5)],carrito);
                        list_clientes.Add(clientes);
                        Console.WriteLine(clientes.Info_Clientes());
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Jefes:");
                    for (int i = 0; i < 1; i++) // creación de jefes
                    {
                        Jefes jefes = new Jefes(nombres[random.Next(10)], apellidos[random.Next(10)], rut[random.Next(15)], fecha_nacimiento[random.Next(5)], nacionalidad[random.Next(5)],sueldos[random.Next(4)],horario[random.Next(3)],buen_trabajo);
                        list_jefes.Add(jefes);
                        Console.WriteLine(jefes.Info_Jefe());
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Stock:");
                    for (int i = 0; i < 2; i++) // creación de stock
                    {
                        Stock stock = new Stock(nombres[random.Next(10)], apellidos[random.Next(10)], rut[random.Next(15)], fecha_nacimiento[random.Next(5)], nacionalidad[random.Next(5)], sueldos[random.Next(4)], horario[random.Next(3)],"Stock" ,buen_trabajo, stock_productos);
                        list_stock.Add(stock);
                        Console.WriteLine(stock.Info_Stock());
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Cajeros:");
                    for (int i = 0; i < 3; i++) // creación de cajeros
                    {
                        Cajeros cajeros = new Cajeros(nombres[random.Next(10)], apellidos[random.Next(10)], rut[random.Next(15)], fecha_nacimiento[random.Next(5)], nacionalidad[random.Next(5)], sueldos[random.Next(4)], horario[random.Next(3)], "Cajero" ,buen_trabajo);
                        list_cajeros.Add(cajeros);
                        Console.WriteLine(cajeros.Info_Cajeros());
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Auxiliares:");
                    for (int i = 0; i < 1; i++) // creación de auxiliares
                    {
                        Auxiliar auxiliar = new Auxiliar(nombres[random.Next(10)], apellidos[random.Next(10)], rut[random.Next(15)], fecha_nacimiento[random.Next(5)], nacionalidad[random.Next(5)], sueldos[random.Next(4)], horario[random.Next(3)], "Auxiliar",buen_trabajo);
                        list_auxiliar.Add(auxiliar);
                        Console.WriteLine(auxiliar.Info_Auxiliar());
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Productos:");
                    for (int i = 0; i < 30; i++) // creación de productos
                    {
                        Producto prod = new Producto(precio_product[random.Next(6)],nombre_product[random.Next(30)],marca_product[random.Next(5)],stock_product[random.Next(4)]);
                        list_productos.Add(prod);
                        Console.WriteLine(prod.Info_product());
                    }
                    Console.WriteLine("-----------------------------------------------------------------------------------");
                    for (int i = 0; i < 5; i++)
                    {
                        Producto producto1 = list_productos[random.Next(30)]; // elegir un producto de la lista producto
                        int cantidad = random.Next(4); //elegir la cantidad de producto

                        Clientes cliente = list_clientes[random.Next(15)]; // elegir de manera random que cliente va a comprar
                        List<Producto> cart = cliente.Agregar_Producto(producto1, list_stock[random.Next(2)], cantidad); //elegir stock que se ocupar

                        if (cart.Count() != 0)
                        {
                            Cajeros cajeros = list_cajeros[random.Next(3)]; // que cajero hara la venta

                            int total_a_pagar = cajeros.Cuanto_Saldra(cart);
                            List<String> registro_de_compras = cajeros.Pagar(total_a_pagar, cliente, producto1, cart, registro_compras, cantidad);

                            cajeros.Ver_Registro_Compras(registro_de_compras);

                            cart.Clear();
                            
                        }
                        else
                        {
                            Console.WriteLine(producto1.Info_Producto() + " no esta en stock o queda menos de la cantidad que pidió. No se pudo agregar el producto.\n");
                            Console.WriteLine("No hay productos en el carro. No se pudo realizar la compra de: " + cliente.Mi_nombre());
                        }
                        Console.WriteLine("--------------------------------------------------\n");
                    }

                    //Veremos nuevo stock
                    Console.WriteLine("--------------------------------------------------------------------------\n");
                    Console.WriteLine("Nuevo Stock: ");
                    for(int i = 0; i < list_productos.Count(); i++)
                    {
                        Console.WriteLine(list_productos[i].Info_Producto() + ". Stock: " + list_productos[i]._Stock_disponible());
                    }
                    registro_compras.Clear();
                    list_auxiliar.Clear();
                    list_cajeros.Clear();
                    list_clientes.Clear();
                    list_jefes.Clear();
                    list_productos.Clear();
                    list_stock.Clear();
                }
                else
                {
                    break;
                }
            }
        }
    }
}
