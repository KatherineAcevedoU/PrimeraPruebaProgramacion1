using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAutomovil
{
    public partial class Automovil
    {


        public void ReabastecerCombustible(double cantidadDeCombustibleEnGalones)  //Primero rellenamos el tanque, ya que el nivel de combustible esta en cero.
        {

            if (this.CapacidadTotalTanqueCombustible >= cantidadDeCombustibleEnGalones)
            {

                Console.Write("El tanque del vehiculo se esta llenando....");
                Console.WriteLine();
                this.NivelCombustible += cantidadDeCombustibleEnGalones; //Esta parte le agrega combustible al tanque, ya que estaba vacio.
                Console.WriteLine("El nivel actual de combustible es de: " + this.NivelCombustible);
                Console.WriteLine("");


            }
            else
            {

                Console.WriteLine("La cantidad de combustible exede la capacidad del tanque!");
                Console.WriteLine();
                
            }


        }

        public void Conducir(int distanciaTotalRecorridaEnKm, double cantidadDeCombustibleConsumido)
        {

            this.RendimientoCombustible = (distanciaTotalRecorridaEnKm / cantidadDeCombustibleConsumido);  //Estos son los km que recorro por cada galos.

            Console.WriteLine("Valor aproximado de los km por galones:");
            Console.WriteLine("El rendimiento de combustible del vehiculo es: " + this.RendimientoCombustible);
            Console.WriteLine();

        }

        public void PuedeConducir(int distanciaDelViaje)
        {

            double cantidadNecesariaDeCombustibleParaViajar = distanciaDelViaje / this.RendimientoCombustible;

            if (this.NivelCombustible >= cantidadNecesariaDeCombustibleParaViajar) //Si el nivel de combustible que tengo actualmente es mayor o igual a la cantidad de combustible
                                                                                   //que necesito para viajar, entonces si se puede viajar.
            {

                Console.WriteLine("Si puede realizar el viaje.");
                Console.WriteLine();

                this.NivelCombustible -= cantidadNecesariaDeCombustibleParaViajar;

                Console.WriteLine("Su nivel de combustible actual es: " + this.NivelCombustible);  //Disminuyo el nivel actual de combustible la cantidad de combustible que utilice para poder viajar.
                Console.WriteLine();


            }
            else
            {

                Console.Write("No puede realizar el viaje.");
                Console.WriteLine("Hay insuficiente combustible.");
                Console.WriteLine();


            }

        }

        //Metodo para imprimir datos

        public void Impresion()
        {
            Console.WriteLine($"Marca: {this.Marca} \n"     +
                              $"Placa: {this.Placa} \n"     +
                              $"Modelo: {this.Modelo} \n"   +
                              $"Color: {this.Color} \n"     +
                              $" Capacidad total del tanque de combustible: {this.CapacidadTotalTanqueCombustible} \n" +
                              $"Rendimiento de combustible: {this.RendimientoCombustible} \n" +
                              $" Nivel de combustible: {this.NivelCombustible} ");
        }

    }
}
