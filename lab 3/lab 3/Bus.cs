using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class Bus :Vehiculo

    {
        string tipo;

        public Bus(string miPatente, string miLicencia, int miAno, int miCosto,string miTipo) : base(miPatente, miLicencia, miAno, miCosto)
        {
            tipo = miTipo;
            
        }
    }
}
