namespace Practica9
{
    partial class InformacionAntibioticos
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
            this.txtbDosis = new System.Windows.Forms.TextBox();
            this.txtbSuministro = new System.Windows.Forms.TextBox();
            this.txtbPiezas = new System.Windows.Forms.TextBox();
            this.txtbTotal = new System.Windows.Forms.TextBox();
            this.btnCalculaTotal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbDosis
            // 
            this.txtbDosis.Enabled = false;
            this.txtbDosis.Location = new System.Drawing.Point(181, 21);
            this.txtbDosis.Name = "txtbDosis";
            this.txtbDosis.Size = new System.Drawing.Size(100, 20);
            this.txtbDosis.TabIndex = 2;
            // 
            // txtbSuministro
            // 
            this.txtbSuministro.Enabled = false;
            this.txtbSuministro.Location = new System.Drawing.Point(181, 112);
            this.txtbSuministro.Name = "txtbSuministro";
            this.txtbSuministro.Size = new System.Drawing.Size(100, 20);
            this.txtbSuministro.TabIndex = 3;
            // 
            // txtbPiezas
            // 
            this.txtbPiezas.Location = new System.Drawing.Point(181, 187);
            this.txtbPiezas.Name = "txtbPiezas";
            this.txtbPiezas.Size = new System.Drawing.Size(100, 20);
            this.txtbPiezas.TabIndex = 4;
            // 
            // txtbTotal
            // 
            this.txtbTotal.Enabled = false;
            this.txtbTotal.Location = new System.Drawing.Point(252, 265);
            this.txtbTotal.Name = "txtbTotal";
            this.txtbTotal.Size = new System.Drawing.Size(100, 20);
            this.txtbTotal.TabIndex = 5;
            // 
            // btnCalculaTotal
            // 
            this.btnCalculaTotal.Location = new System.Drawing.Point(261, 336);
            this.btnCalculaTotal.Name = "btnCalculaTotal";
            this.btnCalculaTotal.Size = new System.Drawing.Size(102, 23);
            this.btnCalculaTotal.TabIndex = 6;
            this.btnCalculaTotal.Text = "Calcular total";
            this.btnCalculaTotal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dosis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Suministro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Piezas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(205, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total a pagar y dosis totales";
            // 
            // InformacionAntibioticos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(375, 365);
            this.Controls.Add(this.btnCalculaTotal);
            this.Controls.Add(this.txtbTotal);
            this.Controls.Add(this.txtbPiezas);
            this.Controls.Add(this.txtbSuministro);
            this.Controls.Add(this.txtbDosis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "InformacionAntibioticos";
            this.Text = "Informacion Antibioticos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbDosis;
        private System.Windows.Forms.TextBox txtbSuministro;
        private System.Windows.Forms.TextBox txtbPiezas;
        private System.Windows.Forms.TextBox txtbTotal;
        private System.Windows.Forms.Button btnCalculaTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}