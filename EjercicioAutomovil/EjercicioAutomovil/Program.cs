using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAutomovil
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Datos de mi Automovil");
            Console.WriteLine("---------------------");
            Console.WriteLine();

            //Pido los datos del automovil.

            Console.Write("Ingrese la marca del vehiculo: ");
            string marca = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese la placa del vehiculo: ");
            string placa = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese el modelo del vehiculo: ");
            string modelo = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese el color del vehiculo: ");
            string color = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Ingrese la capacidad total del tanque: ");
            double capacidadTotalTanque = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(".................................................");
            Console.WriteLine("El nivel actual de combustible = 0.");
            Console.WriteLine("Puede realizar un reabastecimiento de combustible");
            Console.WriteLine(".................................................");
            Console.WriteLine();

            //Ubico mis datos en el constructor con parametro.

            Automovil conector1 = new Automovil(marca, placa, modelo, color, capacidadTotalTanque);


            //Pido la cantidad que le hechara de combustible al automovil.

            Console.Write("Ingrese la cantidad de combustible en galones que desea reabastecer: ");
            double cantidadDeCombustible = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();


            //Mando a llamar a mi metodo Reabastecer quien actualizara mi nivel de combustible

            conector1.ReabastecerCombustible(cantidadDeCombustible);

            Console.WriteLine("...........................................................................................");
            Console.WriteLine("Para conocer el rendimiento de combustible de su vehiculo, necesitamos los siguientes datos ");
            Console.WriteLine("...........................................................................................");
            Console.WriteLine();

            Console.Write("Ingrese la distancia total recorrida en km: ");
            int distanciaRecorrida = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Ingrese la cantidad de combustible consumido: ");
            double combustibleConsumido = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //Mando a llamar a mi Conducir 

            conector1.Conducir(distanciaRecorrida, combustibleConsumido);

            Console.WriteLine("-----------------");
            Console.WriteLine("¿Hara viaje o no?");
            Console.WriteLine("-----------------");
            Console.WriteLine();

            Console.Write("Ingrese la distancia del viaje en km que va a recorrer: ");
            int distanciaDelViaje = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            //Mando a llamar a mi metodo PuedeConducir

            conector1.PuedeConducir(distanciaDelViaje);


            //Mando a llamar a mi metodo impresion

            conector1.Impresion();



        }
    }
}
