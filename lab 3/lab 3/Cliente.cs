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

        public Cliente(string miNombre,string miRut,int miNumero,List<string> licencias )
        {
            nombre = miNombre;
            rut = miRut;
            numero = miNumero;
            licencias = new List<string>();



        }

    }
}
