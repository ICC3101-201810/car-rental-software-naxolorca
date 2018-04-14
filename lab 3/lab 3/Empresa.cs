using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class Empresa:Cliente
    {
        public string permiso;
        public Empresa(string miNombre, string miRut, int miNumero,string miPermiso) : base(miNombre, miRut, miNumero)
        {
            miPermiso = permiso;

        }
    }
}
