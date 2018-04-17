using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class Cliente
    {
        public string nombre, rut;
        public int numero;
        public List<string> licencias;
        public bool permiso;

        public Cliente(string miNombre,string miRut,int miNumero,List<String>miLicencias,bool miPermiso)
        {
            nombre = miNombre;
            rut = miRut;
            numero = miNumero;
            licencias = miLicencias;
            permiso = miPermiso;




        }

    }
}
