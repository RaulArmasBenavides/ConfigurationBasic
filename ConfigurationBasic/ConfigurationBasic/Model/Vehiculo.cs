using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDemo13.Model
{
    public class Vehiculo
    {

        //constructor por defecto 
        public Vehiculo()
        {

        }


        //constructor alternativo 
        public Vehiculo(string placap, string modelop, string tipop, decimal preciop)
        {

            this.placa = placap;
            this.precio = preciop;
            this.modelo = modelop;
            this.tipo_vehiculo = tipop;

        }

        //propiedades 

        public string placa { get; set; }

        public string modelo { get; set; }

        //comentarios, sirven para documenar tu código 
        // tipo_vehiculo : automático o manual
        public string tipo_vehiculo { get; set; }

        public decimal precio { get; set; }


    }
}
