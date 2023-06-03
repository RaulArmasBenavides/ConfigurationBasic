using AppDemo13.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppDemo13.View
{
    public partial class frmLista : Form
    {
        public frmLista()
        {
            InitializeComponent();
        }
        // variables
        List<Alumno> alumnos = new List<Alumno>(); // Lista de alumnos
        List<int> mylistint = new List<int>(); // Lista de enteros 

        void LimpiaCajas()
        {
            txtalumno.Clear();
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
            txtpromedio.Clear();
            txtnumero.Focus();
        }


        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea guardar el registro de alumno?", "Grabar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
            {
                Alumno alu = new Alumno(txtnumero.Text,Int32.Parse(txtnota1.Text),Int32.Parse(txtnota2.Text),Int32.Parse(txtnota3.Text));
                alumnos.Add(alu);   
                txtpromedio.Text = alu.Promedio().ToString();
                     
                //Mostrar el registro en el DataGridview
                dgdAlumnos.DataSource = null;
                dgdAlumnos.DataSource = alumnos;
                GroupBox1.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string numero = txtnumero.Text;
            if (numero != "")
            {
                //Realizar un bucle para buscar en el arreglo desde la primera fila hasta el 
                foreach(Alumno alu in alumnos)
                {
                    if (alu.Codigo.Equals(numero))
                    {
                        //Si encontramos el registro entonces mostramos sus datos en el formulario
                        txtnumero.Text = alu.Codigo;
                        txtnota1.Text = alu.Nota1.ToString();
                        txtnota2.Text = alu.Nota2.ToString();
                        txtnota3.Text = alu.Nota3.ToString();
                        txtpromedio.Text = alu.Promedio().ToString();                   
                    }
                }
                //Si el procedimiento no fue cancelado y el bucle termino su recorrido entonces
                MessageBox.Show("El registro no existe", "No encontrado", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }
        }

        private void ImprimirIteracion( )
        {
            foreach (Alumno al in alumnos)
            {
                Debug.Print(" Te presento al alumno " + al.Codigo + " con notas : " + al.Nota1 + " - " + al.Nota2);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
              foreach(Alumno alu in alumnos){
                if (alu.Codigo.Equals(txtnumero.Text)) {
                //Si encontramos el registro de alumno lo eliminamos de la coleccion
                alumnos.Remove(alu);
                //Actualizamos el grid
                dgdAlumnos.DataSource = null;
                dgdAlumnos.DataSource = alumnos;                
            }
            MessageBox.Show("Alumno eliminado");
           }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            GroupBox1.Enabled = true;
            LimpiaCajas();
        }

        private void Debugger_Click(object sender, EventArgs e)
        {
            ImprimirIteracion();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
