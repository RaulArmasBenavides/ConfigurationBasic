using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using AppDemo13.Colecciones;

namespace AppDemo13
{
    public partial class frmSobrecarga : Form
    {
        public frmSobrecarga()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            /*GenerateRandomNumbers();
            Random random = new Random();*/

        }

        private void grp_Vector1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            GestorColecciones gc = new GestorColecciones();
           

            Dictionary<int, string> dic = new Dictionary<int, string>();

            dic = gc.CrearDictionarioEjemplo();
            dic.Add(4, "cuatro");
            string mresult = "";
            foreach (KeyValuePair<int, string> elemento in dic)
            {
                //Console.WriteLine("Clave: {0}, Valor: {1}", elemento.Key, elemento.Value);
                mresult += "Clave: {0}, Valor: {1}" + elemento.Key.ToString() + elemento.Value.ToString() + "\n";
            }

            lbl_conteo.Text = Convert.ToString(dic.Count);
            // Console.WriteLine("HAY " + k + " ELEMENTOS");
            txt_result.Text = mresult;
            ///Console.ReadKey();
            /*string mresult = "";*/            //Util myvectorclass1 = new Util();
            //myvectorclass1.vec[0] = Convert.ToInt32(txt_component1_1.Text);
            //myvectorclass1.vec[1] = Convert.ToInt32(txt_component1_2.Text);
            //myvectorclass1.vec[2] = Convert.ToInt32(txt_component1_3.Text);
            //myvectorclass1.vec[3] = Convert.ToInt32(txt_component1_4.Text);
            //myvectorclass1.vec[4] = Convert.ToInt32(txt_component1_5.Text);

            ////componentes del vector 2    
            //Util myvectorclass2 = new Util();
            //myvectorclass2.vec[0] = Convert.ToInt32(txt_component2_1.Text);
            //myvectorclass2.vec[1] = Convert.ToInt32(txt_component2_2.Text);
            //myvectorclass2.vec[2] = Convert.ToInt32(txt_component2_3.Text);
            //myvectorclass2.vec[3] = Convert.ToInt32(txt_component2_4.Text);
            //myvectorclass2.vec[4] = Convert.ToInt32(txt_component2_5.Text);


            //Util myvectorclasssum  = new Util();

            //myvectorclasssum = myvectorclass1 + myvectorclass2;

            //mresult = "El vector suma es :\n ";
            //for (int i = 0; i < myvectorclasssum.vec.Length; i++)
            //{
            //    mresult  += myvectorclasssum.vec[i].ToString() + "\n ";
            //}
            //componentes del vector 1    


            //Debug.Print("test");
            //txt_result.Text = "Ejecutando...";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GestorColecciones gc = new GestorColecciones();
            Hashtable hashtable = new Hashtable();

            hashtable = gc.CrearHastTableEjemplo();
            string mresult = "";
            for (int i = 1; i <= hashtable.Keys.Count; i++)
            {
                mresult += "DNI " +  i.ToString() + hashtable[i] + "\n"; //hashtable[i]; // Value
            }
            //foreach (object elemento in hashtable)
            //{
            //    //Console.WriteLine("Clave: {0}, Valor: {1}", elemento.Key, elemento.Value);
            //    mresult += "Clave: {0}, Valor: {1}" + elemento.Key.ToString() + elemento.Value.ToString() + "\n";
            //}

            lbl_conteo.Text = Convert.ToString(hashtable.Count);
            txt_result.Text = mresult;
        }


        /*private void GenerateRandomNumbers()
        {
            
            txt_component1_1.Text = r
            txt_component1_2.Text = "3";
            txt_component1_3.Text = "4";

        }*/


    }
}
