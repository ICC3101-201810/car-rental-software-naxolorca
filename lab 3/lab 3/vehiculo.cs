using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{

    public class Vehiculo
    {
        public string patente,licencia;
        public int ano,costo;

       
        
        public Vehiculo(string miPatente,string miLicencia,int miAno,int miCosto)
        {
            patente = miPatente;
            licencia = miLicencia;
            ano = miAno;
            costo = miCosto;
        }

    }
}
