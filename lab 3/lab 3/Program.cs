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



            public void CrearVehiculo(string patente,string licencia,int ano,int precio)
            {
                Vehiculo a = new Vehiculo(patente, licencia, ano, precio);

                return a;
            }
        
            while (true)
            {
                List<Sucursal> sucursales = new List<Sucursal>();
                Console.WriteLine("1. Agregar una sucursal \n2. Ver sucursales");

                string R = Console.ReadLine();

                if (R == "1" )
                {   
                    Console.WriteLine("ingrese nombre de la sucursal");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("ingrese ubicacion de la sucursal");
                    string ubicacion = Console.ReadLine();
                    Console.WriteLine("ingrese ubicacion de la sucursal");
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

                        sucursales.Add(new Sucursal(nombre, ubicacion, new List<Arriendo> { }, new List<Vehiculo> { }));
                    }

                }



                if (R == "si" && R == "Si" && R == "SI")
                {


                }
            }
        }
    }
}
