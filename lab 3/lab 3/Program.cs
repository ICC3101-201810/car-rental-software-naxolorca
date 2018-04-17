using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class Program
    {
        
        static void Main(string[] args)
        {
  /*        Persona persona1 = new Persona("juan", "19302330-4", 1, new List<String> { "bus", "auto" } , false);
            Sucursal sucursal1 = new Sucursal("ovalle", "centro",new List<Arriendo> { },new List<Vehiculo> { });
            Auto auto1 = new Auto("GXSY81", "auto", 2015, 20000);

 

            sucursal1.Arrendar(persona1, auto1, DateTime.Now, DateTime.Today.AddDays(-1),new List<Extra>{ });
            Console.WriteLine(sucursal1.arriendos[0].fin);
            Console.ReadKey();

*/
            List<Sucursal> sucursales = new List<Sucursal>();
            while (true)
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("1. Agregar una sucursal \n2. Ver sucursales");

                string R = Console.ReadLine();

                if (R == "1" )
                {   
                    Console.WriteLine("ingrese nombre de la sucursal");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("ingrese ubicacion de la sucursal");
                    string ubicacion = Console.ReadLine();
                    sucursales.Add(new Sucursal(nombre, ubicacion, new List<Arriendo> { }, new List<Vehiculo> { }));
                    while (true)
                    {
                        Console.WriteLine("ingrese patente del vehiculo");
                        string patente = Console.ReadLine();
                        Console.WriteLine("ingrese licencia del vehiculo");
                        string licencia = Console.ReadLine();
                        Console.WriteLine("ingrese año del vehiculo");
                        int ano = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("ingrese valor del vehiculo");
                        int valor = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Indique el tipo de Vehiculo\n1. Auto\n2. Bus\n3. Camion\n4. Bus liviano\n5. Bus de lujo\n6. Maquinaria Pesada\n7. Moto");
                        int tipo = Convert.ToInt32(Console.ReadLine());
                        Sucursal s = sucursales[sucursales.Count - 1];
                        s.CrearVehiculo(tipo, patente, licencia, ano, valor, s);

                        Console.WriteLine("Desea Agregar otro vehiculo\n1. Si\n2. No");
                        int seguir = Convert.ToInt32(Console.ReadLine());
                        if (seguir == 2)
                            break;

                    }
                                      
                }
                if (R == "2"&& sucursales.Count>0)
                {
                    int n = 1;
                    foreach (Sucursal su in sucursales)
                    {
                        Console.WriteLine(n + ". " + su.nombre);
                        n = n + 1;
                    }
                    Console.WriteLine("Ingrese la sucursal");
                    int respSu = Convert.ToInt32(Console.ReadLine());
                    Sucursal SuElegida = sucursales[respSu - 1];

                    while (true)
                    {
                        Console.WriteLine("Elija una opcion \n1.Arrendar Vehiculo  \n2.Recibir Vehiculo \n3.salir ");
                        int R2 = Convert.ToInt32(Console.ReadLine());
                        if (R2 == 1)
                        {
                            Console.WriteLine("ingrese el nombre del cliente");
                            string nombre = Console.ReadLine();
                            Console.WriteLine("ingrese el rut del cliente");
                            string rut = Console.ReadLine();
                            Console.WriteLine("ingrese la licencia del cliente");
                            string licencia = Console.ReadLine();
                            Cliente cliente = new Cliente(nombre, rut, SuElegida.arriendos.Count, new List<string> { licencia }, false);
                            Console.WriteLine(cliente.numero);
                            n = 1;
                            foreach (Vehiculo vehiculo in SuElegida.disponibles)
                            {
                                Console.WriteLine(n + ". " + vehiculo.GetType());
                                n = n + 1;
                            }
                            int vehiElegido = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Ingrese dias de arriendo");
                            int fin = Convert.ToInt32(Console.ReadLine());
                            SuElegida.Arrendar(cliente, SuElegida.disponibles[vehiElegido - 1], DateTime.Now, DateTime.Today.AddDays(fin), new List<Extra> { });
                            SystemSounds.Asterisk.Play();
                            Console.Beep();
                            SuElegida.disponibles.Remove(SuElegida.disponibles[vehiElegido - 1]);

                        }
                        if (R2 == 2)
                        {
                            Console.WriteLine("Ingrese numero de Cliente");
                            int numCliente = Convert.ToInt32(Console.ReadLine());
                            var VeRecibido = from arriendo in SuElegida.arriendos where arriendo.cliente.numero == numCliente select arriendo.vehiculo;

                            foreach (var ve in VeRecibido)
                            {
                                Console.WriteLine(ve.patente);
                                SuElegida.disponibles.Add(ve);
                                SystemSounds.Asterisk.Play();
                                Console.Beep();

                            }
       
                            
                            
                        }
                        if (R2 == 3)
                            break;



                    }
                    
                }

           
            }
        }
    }
}
