using AppDemo13.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace AppDemo13
{
    public partial class frmCola : Form
    {
        public frmCola()
        {
            InitializeComponent();
        }
        // declarar objeto cola de la clase factura
        Queue<Factura> cola = new Queue<Factura>();

        void ListarFactura()
        {
            //Limpiamos el grid eliminando todas sus filas
            dgdfactura.Rows.Clear();
            //Creamos una variable contador de filas
            Int32 fila = 0;
            foreach (Factura fact in cola)
            {
                //agregamos una fila nueva al grid
                dgdfactura.Rows.Add();
                //llenamos sus celdas
                dgdfactura.Rows[fila].Cells[0].Value = fact.Numero;
                dgdfactura.Rows[fila].Cells[1].Value = fact.Fecha;
                dgdfactura.Rows[fila].Cells[2].Value = fact.Monto;
                dgdfactura.Rows[fila].Cells[3].Value = fact.Cliente;
                fila++;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Crear una instancia de factura
            Factura fact = new Factura();
            //asignar valores al objeto fact
            fact.Numero = Int32.Parse(txtnumero.Text);
            fact.Fecha = DateTime.Parse(dtfecha.Text);
            fact.Monto = decimal.Parse(txtmonto.Text);
            fact.Cliente = txtcliente.Text;
            //guardar la factura en la cola
            cola.Enqueue(fact);
            //Mostrar la cola en el grid
             MessageBox.Show("factura guardada");
            ListarFactura();          
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //Leer y quitar el primer elemento de la cola 
            Factura fact = cola.Dequeue();
            //mostar datos
            txtnumero.Text = fact.Numero.ToString();
            dtfecha.Text = fact.Fecha.ToString();
            txtmonto.Text = fact.Monto.ToString();
            txtcliente.Text = fact.Cliente;
            //Mostrar los elementos restantes por leer de cola en el grid
            ListarFactura();
        }
    }
}
