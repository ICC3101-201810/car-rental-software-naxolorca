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
        List<Vehiculo> vehiculos = new List<Vehiculo>();
        public Sucursal(string miNombre, string miUbicacion, List<Vehiculo> miVehiculos)
        {
            nombre = miNombre;
            ubicacion = miUbicacion;
            vehiculos = miVehiculos;

        }

        public void Arrendar(Vehiculo vehiculo,Persona cliente)
        {

        }



    }
}
