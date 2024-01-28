namespace ProyectoFinal_Henry_Pérez_Granados
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtSuposicion = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.btnReiniciar = new System.Windows.Forms.Button();
            this.lblSugerencia = new System.Windows.Forms.Label();
            this.lblIntento = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSuposicion
            // 
            this.txtSuposicion.Location = new System.Drawing.Point(92, 52);
            this.txtSuposicion.MaxLength = 3;
            this.txtSuposicion.Name = "txtSuposicion";
            this.txtSuposicion.Size = new System.Drawing.Size(100, 20);
            this.txtSuposicion.TabIndex = 0;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(104, 78);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 1;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // btnReiniciar
            // 
            this.btnReiniciar.Location = new System.Drawing.Point(104, 107);
            this.btnReiniciar.Name = "btnReiniciar";
            this.btnReiniciar.Size = new System.Drawing.Size(75, 23);
            this.btnReiniciar.TabIndex = 2;
            this.btnReiniciar.Text = "Reiniciar";
            this.btnReiniciar.UseVisualStyleBackColor = true;
            this.btnReiniciar.Click += new System.EventHandler(this.btnReiniciar_Click);
            // 
            // lblSugerencia
            // 
            this.lblSugerencia.AutoSize = true;
            this.lblSugerencia.Location = new System.Drawing.Point(12, 31);
            this.lblSugerencia.Name = "lblSugerencia";
            this.lblSugerencia.Size = new System.Drawing.Size(59, 13);
            this.lblSugerencia.TabIndex = 3;
            this.lblSugerencia.Text = "sugerencia";
            // 
            // lblIntento
            // 
            this.lblIntento.AutoSize = true;
            this.lblIntento.Location = new System.Drawing.Point(12, 9);
            this.lblIntento.Name = "lblIntento";
            this.lblIntento.Size = new System.Drawing.Size(39, 13);
            this.lblIntento.TabIndex = 4;
            this.lblIntento.Text = "intento";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 141);
            this.Controls.Add(this.lblIntento);
            this.Controls.Add(this.lblSugerencia);
            this.Controls.Add(this.btnReiniciar);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtSuposicion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adivina el número";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSuposicion;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Button btnReiniciar;
        private System.Windows.Forms.Label lblSugerencia;
        private System.Windows.Forms.Label lblIntento;
    }
}

