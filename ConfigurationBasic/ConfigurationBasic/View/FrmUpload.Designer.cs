
namespace AppDemo13.View
{
    partial class FrmUpload
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
            this.btnSubir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.RichTextBox();
            this.txtProperty = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSubir
            // 
            this.btnSubir.Location = new System.Drawing.Point(61, 28);
            this.btnSubir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubir.Name = "btnSubir";
            this.btnSubir.Size = new System.Drawing.Size(156, 31);
            this.btnSubir.TabIndex = 3;
            this.btnSubir.Text = "Subir Documento";
            this.btnSubir.UseVisualStyleBackColor = true;
            this.btnSubir.Click += new System.EventHandler(this.btnSubir_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(474, 34);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "LDAP";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_result
            // 
            this.txt_result.Location = new System.Drawing.Point(61, 70);
            this.txt_result.Name = "txt_result";
            this.txt_result.Size = new System.Drawing.Size(819, 422);
            this.txt_result.TabIndex = 6;
            this.txt_result.Text = "";
            // 
            // txtProperty
            // 
            this.txtProperty.Location = new System.Drawing.Point(311, 34);
            this.txtProperty.Name = "txtProperty";
            this.txtProperty.Size = new System.Drawing.Size(148, 20);
            this.txtProperty.TabIndex = 10;
            this.txtProperty.TextChanged += new System.EventHandler(this.txtProperty_TextChanged);
            // 
            // FrmUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 553);
            this.Controls.Add(this.txtProperty);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSubir);
            this.Name = "FrmUpload";
            this.Text = "FrmUpload";
            this.Load += new System.EventHandler(this.FrmUpload_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox txt_result;
        internal System.Windows.Forms.TextBox txtProperty;
    }
}