using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDemo13.Colecciones
{
    public class GestorColecciones
    {


        //constructor

        public GestorColecciones()
        {

        }


        public Dictionary<int, string> CrearDictionarioEjemplo()
        {
            Dictionary<int, string> diccionario = new Dictionary<int, string>()
            {
                { 1, "Uno" },
                { 2, "Dos" },
                { 3, "Tres" },
            };
            return diccionario;
        }


        public Hashtable  CrearHastTableEjemplo()
        {
            Hashtable hs = new Hashtable() ;
            hs.Add(1, "73262442");
            hs.Add(2, "32424234");
            hs.Add(3, "343432");
            return hs;

        }

        public void CrearListaEjemplo()
        {

        }


    }
}
