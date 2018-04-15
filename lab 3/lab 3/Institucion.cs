using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    class Institucion:Cliente
    {

        public Institucion(string miNombre, string miRut, int miNumero, List<String> licencias,bool permiso) : base(miNombre, miRut, miNumero, licencias,permiso)
        {


        }
    }
}
    

