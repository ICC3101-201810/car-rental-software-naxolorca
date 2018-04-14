using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class Sucursal
    {
        string nombre, ubicacion;
        List<Vehiculo> vehiculos ;
        List<Arriendo> arriendos ;
        public Sucursal(string miNombre, string miUbicacion)
        {
            nombre = miNombre;
            ubicacion = miUbicacion;
            vehiculos = new List<Vehiculo>();
            arriendos = new List<Arriendo>();

        }

        public void Arrendar(Cliente cliente, Vehiculo vehiculo, DateTime dia, DateTime fin,List<Extra> extras)
        {
            Type t = cliente.GetType();
            t.licencia == 
            if (cliente is Persona && vehiculo.licencia == .licencia )
            {
                typeof
                Arriendo arriendo = new Arriendo(dia, fin, cliente, vehiculo);
                arriendos.Add(arriendo);
            }

                


        }

    }
}
