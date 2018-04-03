using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public enum TipoVehiculo { auto, acuatico, moto, camion, bus, maquinaria };
    public class Vehiculo
    {
        public string licencia;
        public int ano;
        public TipoVehiculo tipo;
        
        Vehiculo(TipoVehiculo miTipo,string miLicencia,int miAno)
        {
            tipo = miTipo;
            licencia = miLicencia;
            ano = miAno;
        }

    }
}
