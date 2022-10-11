using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppDemo13.Model
{
   public class Alumno
    {
       // propiedades
       public string Codigo { get; set; }
       public int Nota1 { get; set; }
       public int Nota2 { get; set; }
       public int Nota3 { get; set; }
       // constructor vacío 
       public Alumno()
       {
          
       }

        // constructor 
        public Alumno(string cod,int n1,int n2,int n3)
       {
           Codigo = cod;
           Nota1 = n1;
           Nota2 = n2;
           Nota3 = n3;
       }
        // metodo
       public float Promedio()
       {
           return (Nota1 + Nota2 + Nota3) / 3;
       }

    }
}
