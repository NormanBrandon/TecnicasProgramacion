namespace Practica11
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbNumCuenta = new System.Windows.Forms.TextBox();
            this.txtbPromedio = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbSuma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbSitAcademica = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbCal1 = new System.Windows.Forms.TextBox();
            this.txtbCal2 = new System.Windows.Forms.TextBox();
            this.txtbCal3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del alumno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de cuenta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Promedio";
            // 
            // txtbNombre
            // 
            this.txtbNombre.Enabled = false;
            this.txtbNombre.Location = new System.Drawing.Point(157, 29);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(100, 20);
            this.txtbNombre.TabIndex = 5;
            // 
            // txtbNumCuenta
            // 
            this.txtbNumCuenta.Enabled = false;
            this.txtbNumCuenta.Location = new System.Drawing.Point(157, 93);
            this.txtbNumCuenta.Name = "txtbNumCuenta";
            this.txtbNumCuenta.Size = new System.Drawing.Size(100, 20);
            this.txtbNumCuenta.TabIndex = 7;
            // 
            // txtbPromedio
            // 
            this.txtbPromedio.Enabled = false;
            this.txtbPromedio.Location = new System.Drawing.Point(479, 160);
            this.txtbPromedio.Name = "txtbPromedio";
            this.txtbPromedio.Size = new System.Drawing.Size(100, 20);
            this.txtbPromedio.TabIndex = 9;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnMostrar.ForeColor = System.Drawing.Color.Blue;
            this.btnMostrar.Location = new System.Drawing.Point(463, 221);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(100, 44);
            this.btnMostrar.TabIndex = 10;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Suma de las calificaciones";
            // 
            // txtbSuma
            // 
            this.txtbSuma.Enabled = false;
            this.txtbSuma.Location = new System.Drawing.Point(479, 29);
            this.txtbSuma.Name = "txtbSuma";
            this.txtbSuma.Size = new System.Drawing.Size(100, 20);
            this.txtbSuma.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(341, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Situación académica";
            // 
            // txtbSitAcademica
            // 
            this.txtbSitAcademica.Enabled = false;
            this.txtbSitAcademica.Location = new System.Drawing.Point(479, 93);
            this.txtbSitAcademica.Name = "txtbSitAcademica";
            this.txtbSitAcademica.Size = new System.Drawing.Size(100, 20);
            this.txtbSitAcademica.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Calificación 1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Calificación 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Calificación 3";
            // 
            // txtbCal1
            // 
            this.txtbCal1.Location = new System.Drawing.Point(157, 143);
            this.txtbCal1.Name = "txtbCal1";
            this.txtbCal1.Size = new System.Drawing.Size(100, 20);
            this.txtbCal1.TabIndex = 18;
            // 
            // txtbCal2
            // 
            this.txtbCal2.Location = new System.Drawing.Point(157, 198);
            this.txtbCal2.Name = "txtbCal2";
            this.txtbCal2.Size = new System.Drawing.Size(100, 20);
            this.txtbCal2.TabIndex = 19;
            // 
            // txtbCal3
            // 
            this.txtbCal3.Location = new System.Drawing.Point(157, 249);
            this.txtbCal3.Name = "txtbCal3";
            this.txtbCal3.Size = new System.Drawing.Size(100, 20);
            this.txtbCal3.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(594, 290);
            this.Controls.Add(this.txtbCal3);
            this.Controls.Add(this.txtbCal2);
            this.Controls.Add(this.txtbCal1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbSitAcademica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtbSuma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.txtbPromedio);
            this.Controls.Add(this.txtbNumCuenta);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Name = "Form1";
            this.Text = "Implementación de librería de clases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbNumCuenta;
        private System.Windows.Forms.TextBox txtbPromedio;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbSuma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbSitAcademica;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbCal1;
        private System.Windows.Forms.TextBox txtbCal2;
        private System.Windows.Forms.TextBox txtbCal3;
    }
}

