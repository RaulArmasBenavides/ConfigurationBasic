using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppDemo13.Model
{
    public class Factura
    {
        // propiedades
        public Int32 Numero { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Monto { get; set; }
        public string Cliente { get; set; }
        //constructor
        public Factura() { }

        public Factura(Int32 num,DateTime fec,decimal mon,string cli)
        {
            Numero = num;
            Fecha = fec;
            Monto = mon;
            Cliente = cli;
        }


    }
}
