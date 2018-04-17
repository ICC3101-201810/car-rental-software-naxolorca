using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("juan", "19302330-4", 1, new List<String> { "bus", "auto" } , false);
            Sucursal sucursal1 = new Sucursal("ovalle", "centro",new List<Arriendo> { },new List<Vehiculo> { });
            Auto auto1 = new Auto("GXSY81", "auto", 2015, 20000);



            sucursal1.Arrendar(persona1, auto1, DateTime.Now, DateTime.Today.AddDays(-1),new List<Extra>{ });
            Console.WriteLine(sucursal1.arriendos[0].fin);
            Console.ReadKey();


            List<Sucursal> sucursales = new List<Sucursal>();
            while (true)
            {
                
                Console.WriteLine("1. Agregar una sucursal \n2. Ver sucursales");

                string R = Console.ReadLine();

                if (R == "1" )
                {   
                    Console.WriteLine("ingrese nombre de la sucursal");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("ingrese ubicacion de la sucursal");
                    string ubicacion = Console.ReadLine();
                    sucursales.Add(new Sucursal(nombre, ubicacion, new List<Arriendo> { }, new List<Vehiculo> { }));
                    Console.WriteLine(sucursales.Count);
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
                if (R == "2")
                {
                    foreach (Sucursal su in sucursales)
                    {
                        Console.WriteLine(su.nombre);

                    }
                    
                }

           
            }
        }
    }
}
