using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioAutomovil
{
    public partial class Automovil
    {

        public string Marca { get; set; }
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public double CapacidadTotalTanqueCombustible { get; set; }

        public double RendimientoCombustible; 
      
        public double NivelCombustible = 0;

        public Automovil(string marca, string placa, string modelo, string color, double capacidadTotalTanqueCombustible)
        {

            this.Marca = marca;
            this.Placa = placa;
            this.Modelo = modelo;
            this.Color = color;
            this.CapacidadTotalTanqueCombustible = capacidadTotalTanqueCombustible;

        }

    }
}
