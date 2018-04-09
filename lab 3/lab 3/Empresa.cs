using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class Empresa:Cliente
    {
        public Empresa(string miNombre, string miRut, string miLicencia, int miNumero) : base(miNombre, miLicencia, miNumero, miRut)
        {


        }
    }
}
