﻿namespace Practica5
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
            this.btnsuma = new System.Windows.Forms.Button();
            this.btnresta = new System.Windows.Forms.Button();
            this.btnmult = new System.Windows.Forms.Button();
            this.btndiv = new System.Windows.Forms.Button();
            this.txtentrada = new System.Windows.Forms.TextBox();
            this.lboper1 = new System.Windows.Forms.Label();
            this.lboper2 = new System.Windows.Forms.Label();
            this.lbres = new System.Windows.Forms.Label();
            this.lboperando = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.pro = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnsuma
            // 
            this.btnsuma.Location = new System.Drawing.Point(36, 29);
            this.btnsuma.Name = "btnsuma";
            this.btnsuma.Size = new System.Drawing.Size(75, 23);
            this.btnsuma.TabIndex = 0;
            this.btnsuma.Text = "Suma";
            this.btnsuma.UseVisualStyleBackColor = true;
            this.btnsuma.Click += new System.EventHandler(this.suma_Click);
            // 
            // btnresta
            // 
            this.btnresta.Location = new System.Drawing.Point(36, 73);
            this.btnresta.Name = "btnresta";
            this.btnresta.Size = new System.Drawing.Size(75, 23);
            this.btnresta.TabIndex = 1;
            this.btnresta.Text = "Resta";
            this.btnresta.UseVisualStyleBackColor = true;
            this.btnresta.Click += new System.EventHandler(this.btnresta_Click);
            // 
            // btnmult
            // 
            this.btnmult.Location = new System.Drawing.Point(36, 112);
            this.btnmult.Name = "btnmult";
            this.btnmult.Size = new System.Drawing.Size(87, 23);
            this.btnmult.TabIndex = 1;
            this.btnmult.Text = "Multiplicacion";
            this.btnmult.UseVisualStyleBackColor = true;
            this.btnmult.Click += new System.EventHandler(this.btnmult_Click);
            // 
            // btndiv
            // 
            this.btndiv.Location = new System.Drawing.Point(36, 150);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(75, 23);
            this.btndiv.TabIndex = 1;
            this.btndiv.Text = "Division";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // txtentrada
            // 
            this.txtentrada.Location = new System.Drawing.Point(322, 48);
            this.txtentrada.Name = "txtentrada";
            this.txtentrada.Size = new System.Drawing.Size(100, 20);
            this.txtentrada.TabIndex = 2;
            this.txtentrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtentrada_KeyPress);
            // 
            // lboper1
            // 
            this.lboper1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lboper1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboper1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lboper1.Location = new System.Drawing.Point(61, 17);
            this.lboper1.Name = "lboper1";
            this.lboper1.Size = new System.Drawing.Size(100, 23);
            this.lboper1.TabIndex = 3;
            this.lboper1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lboper2
            // 
            this.lboper2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lboper2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboper2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lboper2.Location = new System.Drawing.Point(64, 61);
            this.lboper2.Name = "lboper2";
            this.lboper2.Size = new System.Drawing.Size(97, 23);
            this.lboper2.TabIndex = 3;
            this.lboper2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbres
            // 
            this.lbres.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbres.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbres.Location = new System.Drawing.Point(41, 142);
            this.lbres.Name = "lbres";
            this.lbres.Size = new System.Drawing.Size(152, 23);
            this.lbres.TabIndex = 3;
            this.lbres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lboperando
            // 
            this.lboperando.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lboperando.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboperando.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lboperando.Location = new System.Drawing.Point(6, 61);
            this.lboperando.Name = "lboperando";
            this.lboperando.Size = new System.Drawing.Size(34, 23);
            this.lboperando.TabIndex = 3;
            this.lboperando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Selecciona la operacion a Realizar";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsuma);
            this.groupBox1.Controls.Add(this.btnresta);
            this.groupBox1.Controls.Add(this.btnmult);
            this.groupBox1.Controls.Add(this.btndiv);
            this.groupBox1.Location = new System.Drawing.Point(22, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 193);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Operadores";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lboper1);
            this.groupBox2.Controls.Add(this.lboperando);
            this.groupBox2.Controls.Add(this.lboper2);
            this.groupBox2.Controls.Add(this.lbres);
            this.groupBox2.Location = new System.Drawing.Point(248, 88);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(199, 168);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(453, 188);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(77, 48);
            this.btnlimpiar.TabIndex = 0;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.lipiarclick);
            // 
            // pro
            // 
            this.pro.Location = new System.Drawing.Point(448, 13);
            this.pro.Name = "pro";
            this.pro.Size = new System.Drawing.Size(100, 55);
            this.pro.TabIndex = 7;
            this.pro.Text = "Version Pro";
            this.pro.UseVisualStyleBackColor = true;
            this.pro.Click += new System.EventHandler(this.pro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 268);
            this.Controls.Add(this.pro);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtentrada);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsuma;
        private System.Windows.Forms.Button btnresta;
        private System.Windows.Forms.Button btnmult;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.TextBox txtentrada;
        private System.Windows.Forms.Label lboper1;
        private System.Windows.Forms.Label lboper2;
        private System.Windows.Forms.Label lbres;
        private System.Windows.Forms.Label lboperando;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button pro;
    }
}

