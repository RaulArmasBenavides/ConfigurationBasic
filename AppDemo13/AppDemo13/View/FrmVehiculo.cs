using AppDemo13.Model;
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
    public partial class FrmVehiculo : Form
    {
        public FrmVehiculo()
        {
            InitializeComponent();
        }


        // variables
        List<Vehiculo> lista_vehiculos = new List<Vehiculo>(); // Lista de vehiculos 


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
        {

        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            GroupBox1.Enabled = true;
            LimpiaCajasTexto();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        //creación de métodos 
        //Método que limpiar las cajas de textos 
        void LimpiaCajasTexto()
        {
            TxtModelo.Text = string.Empty;
            TxtPlaca.Text = string.Empty;
            TxtPrecio.Text = string.Empty;
            TxtTipo.Text = string.Empty;

        }

        
        
        //método que grabe un nuevo vehículo 
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea guardar el registro del nuevo vehículo?", "Grabar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                // Alumno alu = new Alumno(txtnumero.Text, Int32.Parse(txtnota1.Text), Int32.Parse(txtnota2.Text), Int32.Parse(txtnota3.Text));

                Vehiculo ve = new Vehiculo(TxtPlaca.Text, TxtModelo.Text, TxtTipo.Text, Convert.ToDecimal(TxtPrecio.Text));

                lista_vehiculos.Add(ve);
                //Mostrar el registro en el DataGridview ( Lista de vehículos)
                dgvVehiculo.DataSource = null;
                dgvVehiculo.DataSource = lista_vehiculos; //aquí viene la data 
                GroupBox1.Enabled = false;
            }
        }
    }
}
