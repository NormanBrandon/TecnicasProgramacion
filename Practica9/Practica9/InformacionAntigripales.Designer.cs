namespace Practica9
{
    partial class InformacionAntigripales
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCalcularTotal = new System.Windows.Forms.Button();
            this.txtbDosis = new System.Windows.Forms.TextBox();
            this.txtbSuministro = new System.Windows.Forms.TextBox();
            this.txtbPiezas = new System.Windows.Forms.TextBox();
            this.txtbTotalDosis = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dosis (pastillas por día)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Suministro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Piezas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total a pagar y dosis totales";
            // 
            // btnCalcularTotal
            // 
            this.btnCalcularTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularTotal.Location = new System.Drawing.Point(254, 312);
            this.btnCalcularTotal.Name = "btnCalcularTotal";
            this.btnCalcularTotal.Size = new System.Drawing.Size(104, 23);
            this.btnCalcularTotal.TabIndex = 1;
            this.btnCalcularTotal.Text = "Calcular total";
            this.btnCalcularTotal.UseVisualStyleBackColor = true;
            this.btnCalcularTotal.Click += new System.EventHandler(this.btnCalcularTotal_Click);
            // 
            // txtbDosis
            // 
            this.txtbDosis.Location = new System.Drawing.Point(215, 34);
            this.txtbDosis.Name = "txtbDosis";
            this.txtbDosis.Size = new System.Drawing.Size(100, 20);
            this.txtbDosis.TabIndex = 3;
            // 
            // txtbSuministro
            // 
            this.txtbSuministro.Enabled = false;
            this.txtbSuministro.Location = new System.Drawing.Point(158, 98);
            this.txtbSuministro.Name = "txtbSuministro";
            this.txtbSuministro.Size = new System.Drawing.Size(100, 20);
            this.txtbSuministro.TabIndex = 4;
            // 
            // txtbPiezas
            // 
            this.txtbPiezas.Location = new System.Drawing.Point(158, 158);
            this.txtbPiezas.Name = "txtbPiezas";
            this.txtbPiezas.Size = new System.Drawing.Size(100, 20);
            this.txtbPiezas.TabIndex = 5;
            // 
            // txtbTotalDosis
            // 
            this.txtbTotalDosis.Enabled = false;
            this.txtbTotalDosis.Location = new System.Drawing.Point(254, 230);
            this.txtbTotalDosis.Name = "txtbTotalDosis";
            this.txtbTotalDosis.Size = new System.Drawing.Size(100, 20);
            this.txtbTotalDosis.TabIndex = 6;
            // 
            // InformacionAntigripales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(390, 360);
            this.Controls.Add(this.txtbTotalDosis);
            this.Controls.Add(this.txtbPiezas);
            this.Controls.Add(this.txtbSuministro);
            this.Controls.Add(this.txtbDosis);
            this.Controls.Add(this.btnCalcularTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Name = "InformacionAntigripales";
            this.Text = "Tabcin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCalcularTotal;
        private System.Windows.Forms.TextBox txtbDosis;
        private System.Windows.Forms.TextBox txtbSuministro;
        private System.Windows.Forms.TextBox txtbPiezas;
        private System.Windows.Forms.TextBox txtbTotalDosis;
    }
}