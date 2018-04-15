using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class Arriendo
    {
 
        public DateTime dia,fin;
        public Cliente cliente;
        public Vehiculo vehiculo;
        public List<Extra> extras;
 
        public Arriendo(DateTime miDia,DateTime miFin, Cliente miCliente, Vehiculo miVehiculo,List<Extra> miExtras)
        {
            dia = miDia;
            fin = miFin;
            cliente = miCliente;
            vehiculo = miVehiculo;
            extras = miExtras;

        }


        
        
    }
}
