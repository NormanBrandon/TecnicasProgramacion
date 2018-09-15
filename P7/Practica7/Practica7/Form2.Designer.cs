namespace Practica7
{
    partial class Form2
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
            this.next = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Operaciones = new System.Windows.Forms.GroupBox();
            this.btnSumar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbres = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.a22 = new System.Windows.Forms.TextBox();
            this.a12 = new System.Windows.Forms.TextBox();
            this.a21 = new System.Windows.Forms.TextBox();
            this.a11 = new System.Windows.Forms.TextBox();
            this.lbal = new System.Windows.Forms.Label();
            this.Operaciones.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(185, 35);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(134, 44);
            this.next.TabIndex = 18;
            this.next.Text = "Siguiente Matriz";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Calculadora de Matrices 3x3";
            // 
            // Operaciones
            // 
            this.Operaciones.Controls.Add(this.next);
            this.Operaciones.Controls.Add(this.btnSumar);
            this.Operaciones.Location = new System.Drawing.Point(12, 226);
            this.Operaciones.Name = "Operaciones";
            this.Operaciones.Size = new System.Drawing.Size(354, 100);
            this.Operaciones.TabIndex = 16;
            this.Operaciones.TabStop = false;
            this.Operaciones.Text = "Operaciones";
            // 
            // btnSumar
            // 
            this.btnSumar.Location = new System.Drawing.Point(21, 35);
            this.btnSumar.Name = "btnSumar";
            this.btnSumar.Size = new System.Drawing.Size(102, 49);
            this.btnSumar.TabIndex = 0;
            this.btnSumar.Text = "Sumar Almacenadas";
            this.btnSumar.UseVisualStyleBackColor = true;
            this.btnSumar.Click += new System.EventHandler(this.btnSumar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbres);
            this.groupBox2.Location = new System.Drawing.Point(420, 42);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 169);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // lbres
            // 
            this.lbres.BackColor = System.Drawing.SystemColors.Info;
            this.lbres.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbres.Location = new System.Drawing.Point(33, 30);
            this.lbres.Name = "lbres";
            this.lbres.Size = new System.Drawing.Size(166, 102);
            this.lbres.TabIndex = 0;
            this.lbres.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbal);
            this.groupBox1.Controls.Add(this.a22);
            this.groupBox1.Controls.Add(this.a12);
            this.groupBox1.Controls.Add(this.a21);
            this.groupBox1.Controls.Add(this.a11);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(392, 169);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculadora";
            // 
            // a22
            // 
            this.a22.Location = new System.Drawing.Point(81, 76);
            this.a22.Name = "a22";
            this.a22.Size = new System.Drawing.Size(27, 20);
            this.a22.TabIndex = 1;
            // 
            // a12
            // 
            this.a12.Location = new System.Drawing.Point(81, 41);
            this.a12.Name = "a12";
            this.a12.Size = new System.Drawing.Size(27, 20);
            this.a12.TabIndex = 1;
            // 
            // a21
            // 
            this.a21.Location = new System.Drawing.Point(30, 76);
            this.a21.Name = "a21";
            this.a21.Size = new System.Drawing.Size(27, 20);
            this.a21.TabIndex = 1;
            // 
            // a11
            // 
            this.a11.Location = new System.Drawing.Point(30, 41);
            this.a11.Name = "a11";
            this.a11.Size = new System.Drawing.Size(27, 20);
            this.a11.TabIndex = 1;
            // 
            // lbal
            // 
            this.lbal.BackColor = System.Drawing.SystemColors.Info;
            this.lbal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbal.Location = new System.Drawing.Point(188, 33);
            this.lbal.Name = "lbal";
            this.lbal.Size = new System.Drawing.Size(166, 102);
            this.lbal.TabIndex = 2;
            this.lbal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 335);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Operaciones);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Operaciones.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Operaciones;
        private System.Windows.Forms.Button btnSumar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox a22;
        private System.Windows.Forms.TextBox a12;
        private System.Windows.Forms.TextBox a21;
        private System.Windows.Forms.TextBox a11;
        private System.Windows.Forms.Label lbal;
    }
}