namespace ArbolBinario
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
            this.ptbArbol = new System.Windows.Forms.PictureBox();
            this.txtbDato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbNivel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCaracterísticas = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbOrden = new System.Windows.Forms.TextBox();
            this.txtbGrado = new System.Windows.Forms.TextBox();
            this.txtbAltura = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbArbol)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbArbol
            // 
            this.ptbArbol.Location = new System.Drawing.Point(194, 160);
            this.ptbArbol.Name = "ptbArbol";
            this.ptbArbol.Size = new System.Drawing.Size(724, 413);
            this.ptbArbol.TabIndex = 0;
            this.ptbArbol.TabStop = false;
            // 
            // txtbDato
            // 
            this.txtbDato.Location = new System.Drawing.Point(160, 42);
            this.txtbDato.Name = "txtbDato";
            this.txtbDato.Size = new System.Drawing.Size(77, 20);
            this.txtbDato.TabIndex = 1;
            this.txtbDato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbDato_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresa dato";
            // 
            // txtbNivel
            // 
            this.txtbNivel.Location = new System.Drawing.Point(473, 27);
            this.txtbNivel.Name = "txtbNivel";
            this.txtbNivel.Size = new System.Drawing.Size(100, 20);
            this.txtbNivel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nivel";
            // 
            // btnCaracterísticas
            // 
            this.btnCaracterísticas.Location = new System.Drawing.Point(538, 112);
            this.btnCaracterísticas.Name = "btnCaracterísticas";
            this.btnCaracterísticas.Size = new System.Drawing.Size(161, 23);
            this.btnCaracterísticas.TabIndex = 5;
            this.btnCaracterísticas.Text = "Mostrar características";
            this.btnCaracterísticas.UseVisualStyleBackColor = true;
            this.btnCaracterísticas.Click += new System.EventHandler(this.btnCaracterísticas_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Orden";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(665, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Grado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Altura";
            // 
            // txtbOrden
            // 
            this.txtbOrden.Location = new System.Drawing.Point(473, 70);
            this.txtbOrden.Name = "txtbOrden";
            this.txtbOrden.Size = new System.Drawing.Size(100, 20);
            this.txtbOrden.TabIndex = 9;
            // 
            // txtbGrado
            // 
            this.txtbGrado.Location = new System.Drawing.Point(729, 27);
            this.txtbGrado.Name = "txtbGrado";
            this.txtbGrado.Size = new System.Drawing.Size(100, 20);
            this.txtbGrado.TabIndex = 9;
            // 
            // txtbAltura
            // 
            this.txtbAltura.Location = new System.Drawing.Point(729, 70);
            this.txtbAltura.Name = "txtbAltura";
            this.txtbAltura.Size = new System.Drawing.Size(100, 20);
            this.txtbAltura.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 585);
            this.Controls.Add(this.txtbAltura);
            this.Controls.Add(this.txtbGrado);
            this.Controls.Add(this.txtbOrden);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCaracterísticas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbNivel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbDato);
            this.Controls.Add(this.ptbArbol);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ptbArbol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbArbol;
        private System.Windows.Forms.TextBox txtbDato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbNivel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCaracterísticas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbOrden;
        private System.Windows.Forms.TextBox txtbGrado;
        private System.Windows.Forms.TextBox txtbAltura;
    }
}

