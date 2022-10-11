using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDemo13.View
{
    public partial class frmPais : Form
    {
        public frmPais()
        {
            InitializeComponent();
        }

        //objeto de tipo diccioario
        Dictionary<string, string> pais = new Dictionary<string, string>();

        private void btnListar_Click(object sender, EventArgs e)
        {
            cargaPaises();
            Listar();
        }

        private void Listar()
        {
            foreach (var item in pais.Keys)
            {
                //string clave = item;                
                lstPaises.Items.Add(pais[item]);
            }
        }

        private void cargaPaises()
        {
            //guardar paises en la coleccion Dictionary
            pais.Add("Pe", "Peru");
            pais.Add("Ar", "Argentina");
            pais.Add("Bo", "Bolivia");
            pais.Add("Ch", "Chile");
            pais.Add("Co", "Colombia");
            pais.Add("Ec", "Ecuador");
            pais.Remove("Ch");
           
        }
    }
}
