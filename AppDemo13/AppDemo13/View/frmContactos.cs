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
    public partial class frmContactos : Form
    {
        public frmContactos()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rdbMasculino.Checked = true;
            cbxDistrito.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("El codigo es obligatorio", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtNombres.Text == "")
            {
                MessageBox.Show("El nombre es obligatorio", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtTelefono.Text == "")
            {
                MessageBox.Show("El Teléfono es obligatorio", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("El Email es obligatorio", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (cbxDistrito.Text == "")
            {
                MessageBox.Show("El Distrito es obligatorio", "Alerta",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            string sexo = "";
            if (rdbMasculino.Checked)
            {
                sexo = "Maculino";
                dgvContacto.Rows.Add(txtCodigo.Text, txtNombres.Text, txtTelefono.Text, txtEmail.Text, sexo, cbxDistrito.Text);
                tabControl1.SelectTab(1);
            }
            else
            {
                sexo = "Femenino";
                dgvContacto.Rows.Add(txtCodigo.Text, txtNombres.Text, txtTelefono.Text, txtEmail.Text, sexo, cbxDistrito.Text);
                tabControl1.SelectTab(1);
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            cbxDistrito.Text = string.Empty;
        }
    }
}
