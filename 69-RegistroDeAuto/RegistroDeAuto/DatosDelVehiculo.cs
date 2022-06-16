using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegistroDeAuto
{
    class DatosDelVehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string TipoCombustible { get; set; }
        public int CantPuertas { get; set; }

        public string presentacion()
        {
            return "Marca: " + " " + this.Marca + ", modelo" + " " + this.Modelo + ", combustible"+ " " + this.TipoCombustible + ", numero de puertas " + " " + this.CantPuertas;
        }
    }
}
