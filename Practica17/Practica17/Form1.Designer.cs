﻿namespace Practica17
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbNumeroCliente = new System.Windows.Forms.TextBox();
            this.txtbEdadCliente = new System.Windows.Forms.TextBox();
            this.txtbSexoCliente = new System.Windows.Forms.TextBox();
            this.btnContinuar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbNombreTienda = new System.Windows.Forms.TextBox();
            this.txtbNombreRefresco = new System.Windows.Forms.TextBox();
            this.txtbNombreGalletas = new System.Windows.Forms.TextBox();
            this.txtA1 = new System.Windows.Forms.TextBox();
            this.txtA2 = new System.Windows.Forms.TextBox();
            this.txtA3 = new System.Windows.Forms.TextBox();
            this.txtB1 = new System.Windows.Forms.TextBox();
            this.txtB2 = new System.Windows.Forms.TextBox();
            this.txtB3 = new System.Windows.Forms.TextBox();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Edad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Sexo";
            // 
            // txtbNumeroCliente
            // 
            this.txtbNumeroCliente.Location = new System.Drawing.Point(184, 55);
            this.txtbNumeroCliente.Name = "txtbNumeroCliente";
            this.txtbNumeroCliente.Size = new System.Drawing.Size(100, 20);
            this.txtbNumeroCliente.TabIndex = 1;
            // 
            // txtbEdadCliente
            // 
            this.txtbEdadCliente.Location = new System.Drawing.Point(184, 108);
            this.txtbEdadCliente.Name = "txtbEdadCliente";
            this.txtbEdadCliente.Size = new System.Drawing.Size(100, 20);
            this.txtbEdadCliente.TabIndex = 1;
            // 
            // txtbSexoCliente
            // 
            this.txtbSexoCliente.Location = new System.Drawing.Point(184, 170);
            this.txtbSexoCliente.Name = "txtbSexoCliente";
            this.txtbSexoCliente.Size = new System.Drawing.Size(100, 20);
            this.txtbSexoCliente.TabIndex = 1;
            // 
            // btnContinuar
            // 
            this.btnContinuar.Location = new System.Drawing.Point(147, 234);
            this.btnContinuar.Name = "btnContinuar";
            this.btnContinuar.Size = new System.Drawing.Size(75, 23);
            this.btnContinuar.TabIndex = 2;
            this.btnContinuar.Text = "Continuar";
            this.btnContinuar.UseVisualStyleBackColor = true;
            this.btnContinuar.Click += new System.EventHandler(this.btnContinuar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tienda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Productos agotados";
            // 
            // txtbNombreTienda
            // 
            this.txtbNombreTienda.Enabled = false;
            this.txtbNombreTienda.Location = new System.Drawing.Point(570, 62);
            this.txtbNombreTienda.Name = "txtbNombreTienda";
            this.txtbNombreTienda.Size = new System.Drawing.Size(100, 20);
            this.txtbNombreTienda.TabIndex = 6;
            // 
            // txtbNombreRefresco
            // 
            this.txtbNombreRefresco.Location = new System.Drawing.Point(570, 173);
            this.txtbNombreRefresco.Name = "txtbNombreRefresco";
            this.txtbNombreRefresco.Size = new System.Drawing.Size(100, 20);
            this.txtbNombreRefresco.TabIndex = 7;
            // 
            // txtbNombreGalletas
            // 
            this.txtbNombreGalletas.Location = new System.Drawing.Point(570, 341);
            this.txtbNombreGalletas.Name = "txtbNombreGalletas";
            this.txtbNombreGalletas.Size = new System.Drawing.Size(100, 20);
            this.txtbNombreGalletas.TabIndex = 8;
            // 
            // txtA1
            // 
            this.txtA1.Location = new System.Drawing.Point(715, 140);
            this.txtA1.Name = "txtA1";
            this.txtA1.Size = new System.Drawing.Size(100, 20);
            this.txtA1.TabIndex = 9;
            // 
            // txtA2
            // 
            this.txtA2.Location = new System.Drawing.Point(715, 173);
            this.txtA2.Name = "txtA2";
            this.txtA2.Size = new System.Drawing.Size(100, 20);
            this.txtA2.TabIndex = 9;
            // 
            // txtA3
            // 
            this.txtA3.Location = new System.Drawing.Point(715, 208);
            this.txtA3.Name = "txtA3";
            this.txtA3.Size = new System.Drawing.Size(100, 20);
            this.txtA3.TabIndex = 9;
            // 
            // txtB1
            // 
            this.txtB1.Location = new System.Drawing.Point(715, 304);
            this.txtB1.Name = "txtB1";
            this.txtB1.Size = new System.Drawing.Size(100, 20);
            this.txtB1.TabIndex = 9;
            // 
            // txtB2
            // 
            this.txtB2.Location = new System.Drawing.Point(715, 341);
            this.txtB2.Name = "txtB2";
            this.txtB2.Size = new System.Drawing.Size(100, 20);
            this.txtB2.TabIndex = 9;
            // 
            // txtB3
            // 
            this.txtB3.Location = new System.Drawing.Point(715, 376);
            this.txtB3.Name = "txtB3";
            this.txtB3.Size = new System.Drawing.Size(100, 20);
            this.txtB3.TabIndex = 9;
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.txtB3);
            this.Controls.Add(this.txtB2);
            this.Controls.Add(this.txtB1);
            this.Controls.Add(this.txtA3);
            this.Controls.Add(this.txtA2);
            this.Controls.Add(this.txtA1);
            this.Controls.Add(this.txtbNombreGalletas);
            this.Controls.Add(this.txtbNombreRefresco);
            this.Controls.Add(this.txtbNombreTienda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnContinuar);
            this.Controls.Add(this.txtbSexoCliente);
            this.Controls.Add(this.txtbEdadCliente);
            this.Controls.Add(this.txtbNumeroCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbNumeroCliente;
        private System.Windows.Forms.TextBox txtbEdadCliente;
        private System.Windows.Forms.TextBox txtbSexoCliente;
        private System.Windows.Forms.Button btnContinuar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbNombreTienda;
        private System.Windows.Forms.TextBox txtbNombreRefresco;
        private System.Windows.Forms.TextBox txtbNombreGalletas;
        private System.Windows.Forms.TextBox txtA1;
        private System.Windows.Forms.TextBox txtA2;
        private System.Windows.Forms.TextBox txtA3;
        private System.Windows.Forms.TextBox txtB1;
        private System.Windows.Forms.TextBox txtB2;
        private System.Windows.Forms.TextBox txtB3;
        private System.Windows.Forms.ErrorProvider errorProv;
    }
}

