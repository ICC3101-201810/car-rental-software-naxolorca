using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class Cliente
    {
        public string nombre, rut, licencia;
        public int numero;

        public Cliente(string miNombre,string miRut,string miLicencia,int miNumero)
        {
            nombre = miNombre;
            rut = miRut;
            licencia = miLicencia;
            numero = miNumero;


        }

    }
}
