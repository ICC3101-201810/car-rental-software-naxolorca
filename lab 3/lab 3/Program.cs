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
            Sucursal sucursal1 = new Sucursal("ovalle", "centro",new List<Arriendo> { });
            Auto auto1 = new Auto("GXSY81", "auto", 2015, 20000);



            sucursal1.Arrendar(persona1, auto1, DateTime.Now, DateTime.Today.AddDays(-1),new List<Extra>{ });
            Console.WriteLine(sucursal1.arriendos[0].fin);
            Console.ReadKey();

        
        }
    }
}
