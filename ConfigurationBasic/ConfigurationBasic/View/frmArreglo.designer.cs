namespace AppDemo13.View
{
    partial class frmArreglo
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
            this.button1 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.txtpromedio = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtnota3 = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.txtnota2 = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txtnota1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtalumno = new System.Windows.Forms.TextBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.txtnumero = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.dgdAlumnos = new System.Windows.Forms.DataGridView();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdAlumnos)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(409, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 29);
            this.button1.TabIndex = 18;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.txtpromedio);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.txtnota3);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.txtnota2);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.txtnota1);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.txtalumno);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.txtnumero);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(9, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(480, 107);
            this.GroupBox1.TabIndex = 17;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Datos de Alumno";
            // 
            // txtpromedio
            // 
            this.txtpromedio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpromedio.Location = new System.Drawing.Point(425, 69);
            this.txtpromedio.Name = "txtpromedio";
            this.txtpromedio.Size = new System.Drawing.Size(47, 20);
            this.txtpromedio.TabIndex = 8;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(362, 73);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(59, 13);
            this.Label5.TabIndex = 7;
            this.Label5.Text = "Promedio";
            // 
            // txtnota3
            // 
            this.txtnota3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnota3.Location = new System.Drawing.Point(305, 69);
            this.txtnota3.Name = "txtnota3";
            this.txtnota3.Size = new System.Drawing.Size(47, 20);
            this.txtnota3.TabIndex = 11;
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(260, 74);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(41, 13);
            this.Label4.TabIndex = 5;
            this.Label4.Text = "Nota3";
            // 
            // txtnota2
            // 
            this.txtnota2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnota2.Location = new System.Drawing.Point(171, 69);
            this.txtnota2.Name = "txtnota2";
            this.txtnota2.Size = new System.Drawing.Size(47, 20);
            this.txtnota2.TabIndex = 13;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Location = new System.Drawing.Point(126, 74);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(41, 13);
            this.Label3.TabIndex = 6;
            this.Label3.Text = "Nota2";
            // 
            // txtnota1
            // 
            this.txtnota1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnota1.Location = new System.Drawing.Point(66, 70);
            this.txtnota1.Name = "txtnota1";
            this.txtnota1.Size = new System.Drawing.Size(47, 20);
            this.txtnota1.TabIndex = 12;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.Location = new System.Drawing.Point(10, 73);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(41, 13);
            this.Label2.TabIndex = 3;
            this.Label2.Text = "Nota1";
            // 
            // txtalumno
            // 
            this.txtalumno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtalumno.Location = new System.Drawing.Point(180, 32);
            this.txtalumno.Name = "txtalumno";
            this.txtalumno.Size = new System.Drawing.Size(174, 20);
            this.txtalumno.TabIndex = 10;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(126, 35);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(48, 13);
            this.Label6.TabIndex = 4;
            this.Label6.Text = "Alumno";
            // 
            // txtnumero
            // 
            this.txtnumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtnumero.Location = new System.Drawing.Point(66, 32);
            this.txtnumero.Name = "txtnumero";
            this.txtnumero.Size = new System.Drawing.Size(47, 20);
            this.txtnumero.TabIndex = 9;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(10, 35);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(46, 13);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Codigo";
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(273, 263);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(76, 29);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(191, 263);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(76, 29);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGrabar
            // 
            this.btnGrabar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(107, 264);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(76, 29);
            this.btnGrabar.TabIndex = 13;
            this.btnGrabar.Text = "Grabar";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnnuevo
            // 
            this.btnnuevo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnuevo.Location = new System.Drawing.Point(9, 263);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(76, 29);
            this.btnnuevo.TabIndex = 14;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // dgdAlumnos
            // 
            this.dgdAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgdAlumnos.Location = new System.Drawing.Point(12, 125);
            this.dgdAlumnos.MultiSelect = false;
            this.dgdAlumnos.Name = "dgdAlumnos";
            this.dgdAlumnos.Size = new System.Drawing.Size(473, 129);
            this.dgdAlumnos.TabIndex = 12;
            // 
            // frmArreglo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 303);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.dgdAlumnos);
            this.Name = "frmArreglo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Arreglo de Objetos";
            this.Load += new System.EventHandler(this.frmArreglo_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgdAlumnos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button button1;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox txtpromedio;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtnota3;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txtnota2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txtnota1;
        private System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtalumno;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.TextBox txtnumero;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnEliminar;
        internal System.Windows.Forms.Button btnBuscar;
        internal System.Windows.Forms.Button btnGrabar;
        internal System.Windows.Forms.Button btnnuevo;
        internal System.Windows.Forms.DataGridView dgdAlumnos;
    }
}

