using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class Sucursal
    {
        public string nombre, ubicacion;
        public List<Vehiculo> disponibles;
        public List<Arriendo> arriendos ;
        public Sucursal(string miNombre, string miUbicacion,List<Arriendo> miArriendos,List<Vehiculo> miDisponibles)
        {
            nombre = miNombre;
            ubicacion = miUbicacion;
            arriendos = miArriendos;
            disponibles = miDisponibles;

        }

        public void CrearVehiculo(int tipo, string patente, string licencia, int ano, int precio,Sucursal s)
        {
            if(tipo == 1)
                s.disponibles.Add(new Auto(patente, licencia, ano, precio));
            if (tipo == 2)
                s.disponibles.Add(new Normal(patente, licencia, ano, precio));
            if (tipo == 3)
                s.disponibles.Add(new Camion(patente, licencia, ano, precio));
            if (tipo == 4)
                s.disponibles.Add(new Liviano(patente, licencia, ano, precio));
            if (tipo == 5)
                s.disponibles.Add(new Lujo(patente, licencia, ano, precio));
            if (tipo == 6)
                s.disponibles.Add(new Maquinaria(patente, licencia, ano, precio));
            if (tipo == 7)
                s.disponibles.Add(new Moto(patente, licencia, ano, precio));
       
        }           
        

        public void Arrendar(Cliente cliente, Vehiculo vehiculo, DateTime dia, DateTime fin,List<Extra> extras)
        {

            if (cliente is Persona && vehiculo is Bus)
            {
                return;
            }

            if (cliente is Persona && cliente.licencias.Contains(vehiculo.licencia))
            {
                Arriendo arriendo = new Arriendo(dia, fin, cliente, vehiculo,extras);
                arriendos.Add(arriendo);
                Console.WriteLine(arriendo.vehiculo.patente);
                Console.WriteLine(arriendo.vehiculo.ano);
                Console.WriteLine(arriendo.vehiculo.costo);
                Console.WriteLine(arriendo.fin);
                


            }

            if (cliente is Empresa && vehiculo is Maquinaria )
            {
                Random rnd = new Random();
                int muni = rnd.Next(0, 100);
                if (muni <= 63 && cliente.licencias.Contains(vehiculo.licencia))
                {
                    Arriendo arriendo = new Arriendo(dia, fin, cliente, vehiculo, extras);
                    arriendos.Add(arriendo);
                }

            }

            if(cliente is Empresa && vehiculo is Bus)
            {
                Random rnd = new Random();
                int muni = rnd.Next(0, 100);
                if (muni <= 80 && cliente.licencias.Contains(vehiculo.licencia))
                {
                    Arriendo arriendo = new Arriendo(dia, fin, cliente, vehiculo, extras);
                    arriendos.Add(arriendo);
                }

            }

            if (cliente is Organizacion && vehiculo is Normal)
            {
                Random rnd = new Random();
                int muni = rnd.Next(0, 100);
                if (muni <= 35 && cliente.licencias.Contains(vehiculo.licencia) )
                {
                    Arriendo arriendo = new Arriendo(dia, fin, cliente, vehiculo, extras);
                    arriendos.Add(arriendo);
                }

            }

            if (cliente is Empresa && vehiculo is Bus)
            {
                Random rnd = new Random();
                int muni = rnd.Next(0, 100);
                if (muni <= 58 && cliente.licencias.Contains(vehiculo.licencia))
                {
                    Arriendo arriendo = new Arriendo(dia, fin, cliente, vehiculo, extras);
                    arriendos.Add(arriendo);
                }

            }

        }

    }
}
