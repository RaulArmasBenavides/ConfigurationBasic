using AppDemo13.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AppDemo13.View
{
    public partial class frmArreglo : Form
    {
        public frmArreglo()
        {
            InitializeComponent();
        }
        // instanciar objeto de la clase Alumno
        Alumno[] alumnos = new Alumno[3];

        byte fila = 0;

        void LimpiaCajas()
        {
            txtnumero.Clear();
            txtnota1.Clear();
            txtnota2.Clear();
            txtnota3.Clear();
            txtpromedio.Clear();
            txtalumno.Clear();
            txtnumero.Focus();
        }

        private void frmArreglo_Load(object sender, EventArgs e)
        {
            GroupBox1.Enabled = false;
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            GroupBox1.Enabled = true;
            LimpiaCajas();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Desea Registrar notas","Registra Notas",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)==System.Windows.Forms.DialogResult.Yes){
                Alumno alu = new Alumno();// instanciar objeto
                // asigna valores a las propiedades
                alu.Codigo = txtnumero.Text;
                alu.Nota1 = Int32.Parse(txtnota1.Text);
                alu.Nota2 = Int32.Parse(txtnota2.Text);
                alu.Nota3 = Int32.Parse(txtnota3.Text);
                txtpromedio.Text = alu.Promedio().ToString("n2");
                // agrear objeto al arreglo
                alumnos[fila] = alu;
                fila++;
            // listar
                dgdAlumnos.DataSource = null;
                dgdAlumnos.DataSource = alumnos;
                GroupBox1.Enabled = false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            bool sw = false;
            string numero = txtnumero.Text;
            if (numero != "")
            {
                for (byte pos = 0; pos < fila; pos++)
                {
                    if (alumnos[pos].Codigo.Equals(numero))
                    {
                        txtnumero.Text = alumnos[pos].Codigo;
                        txtnota1.Text = alumnos[pos].Nota1.ToString();
                        txtnota2.Text = alumnos[pos].Nota2.ToString();
                        txtnota3.Text = alumnos[pos].Nota3.ToString();
                        txtpromedio.Text = alumnos[pos].Promedio().ToString("n2");
                        sw = true; break;
                    }

                }
                if (sw == false)
                {
                    MessageBox.Show("Codigo no existe", "Aviso");
                    txtnumero.Clear();
                    txtnumero.Focus();
                }
            }
            else
            {
                MessageBox.Show("Ingrese Codigo de Alumno","Buscar");
                txtnumero.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
