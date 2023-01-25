using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDemo13.Model
{

    public class Util
    {
        public int[] vec; //vector 

        public Util()
        {
            vec = new int[5];
        }
 
        public void Cargar()
        {
            for (int f = 0; f < vec.Length; f++)
            {
                vec[f] = vec[f];
            }
        }
        
        public static Util operator +(Util v1, Util v2)
        {
            Util su = new Util();
            for (int f = 0; f < su.vec.Length; f++)
            {
                su.vec[f] = v1.vec[f] + v2.vec[f];
            }
            return su;
        }
    }
}
