namespace PjtVEntaHeredada
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btncontado = new System.Windows.Forms.Button();
            this.btncredito = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(159, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENTA DE PRODUCTOS";
            // 
            // btncontado
            // 
            this.btncontado.Location = new System.Drawing.Point(86, 104);
            this.btncontado.Name = "btncontado";
            this.btncontado.Size = new System.Drawing.Size(133, 25);
            this.btncontado.TabIndex = 1;
            this.btncontado.Text = "Venta al contado";
            this.btncontado.UseVisualStyleBackColor = true;
            this.btncontado.Click += new System.EventHandler(this.btncontado_Click);
            // 
            // btncredito
            // 
            this.btncredito.Location = new System.Drawing.Point(294, 104);
            this.btncredito.Name = "btncredito";
            this.btncredito.Size = new System.Drawing.Size(126, 25);
            this.btncredito.TabIndex = 2;
            this.btncredito.Text = "Venta al credito";
            this.btncredito.UseVisualStyleBackColor = true;
            this.btncredito.Click += new System.EventHandler(this.btncredito_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 174);
            this.Controls.Add(this.btncredito);
            this.Controls.Add(this.btncontado);
            this.Controls.Add(this.label1);
            this.Name = "frmPrincipal";
            this.Text = "Formulario Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btncontado;
        private Button btncredito;
    }
}