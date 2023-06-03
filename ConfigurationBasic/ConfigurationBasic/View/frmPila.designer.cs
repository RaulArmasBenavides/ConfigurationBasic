namespace AppDemo13.View
{
    partial class frmPila
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dgdfactura = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtfecha = new System.Windows.Forms.DateTimePicker();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgdfactura)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLeer
            // 
            this.btnLeer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeer.Location = new System.Drawing.Point(139, 384);
            this.btnLeer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(97, 39);
            this.btnLeer.TabIndex = 35;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(33, 384);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(97, 39);
            this.btnAgregar.TabIndex = 36;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dgdfactura
            // 
            this.dgdfactura.AllowUserToAddRows = false;
            this.dgdfactura.AllowUserToDeleteRows = false;
            this.dgdfactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdfactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Fecha,
            this.Monto,
            this.Cliente});
            this.dgdfactura.Location = new System.Drawing.Point(35, 108);
            this.dgdfactura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgdfactura.Name = "dgdfactura";
            this.dgdfactura.ReadOnly = true;
            this.dgdfactura.Size = new System.Drawing.Size(596, 257);
            this.dgdfactura.TabIndex = 34;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            this.Numero.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            this.Monto.ReadOnly = true;
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            this.Cliente.ReadOnly = true;
            // 
            // dtfecha
            // 
            this.dtfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtfecha.Location = new System.Drawing.Point(273, 28);
            this.dtfecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtfecha.Name = "dtfecha";
            this.dtfecha.Size = new System.Drawing.Size(168, 22);
            this.dtfecha.TabIndex = 33;
            // 
            // txtcliente
            // 
            this.txtcliente.Location = new System.Drawing.Point(273, 76);
            this.txtcliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(168, 22);
            this.txtcliente.TabIndex = 32;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(199, 80);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(58, 17);
            this.Label4.TabIndex = 29;
            this.Label4.Text = "Cliente";
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(113, 73);
            this.txtmonto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(61, 22);
            this.txtmonto.TabIndex = 30;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(39, 76);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(52, 17);
            this.Label3.TabIndex = 27;
            this.Label3.Text = "Monto";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(199, 33);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(52, 17);
            this.Label2.TabIndex = 28;
            this.Label2.Text = "Fecha";
            // 
            // txtnumero
            // 
            this.txtnumero.Location = new System.Drawing.Point(113, 30);
            this.txtnumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(61, 22);
            this.txtnumero.TabIndex = 31;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(39, 33);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(64, 17);
            this.Label1.TabIndex = 26;
            this.Label1.Text = "Numero";
            // 
            // frmPila
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgdfactura);
            this.Controls.Add(this.dtfecha);
            this.Controls.Add(this.txtcliente);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtmonto);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtnumero);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmPila";
            this.Text = ":: Coleccion Stack ::";
            ((System.ComponentModel.ISupportInitialize)(this.dgdfactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnLeer;
        internal System.Windows.Forms.Button btnAgregar;
        internal System.Windows.Forms.DataGridView dgdfactura;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        internal System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        internal System.Windows.Forms.DateTimePicker dtfecha;
        internal System.Windows.Forms.TextBox txtcliente;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtmonto;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtnumero;
        internal System.Windows.Forms.Label Label1;
    }
}