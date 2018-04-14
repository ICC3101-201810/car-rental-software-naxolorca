using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class Persona : Cliente
    {
        public string licencia;
        
        public Persona(string miNombre, string miRut, int miNumero,string miLicencia) :base(miNombre,miRut,miNumero)
        {
            licencia = miLicencia;
 

        }



    }
}
