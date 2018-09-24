namespace Practica8
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
            this.lblista = new System.Windows.Forms.Label();
            this.lbtotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblista
            // 
            this.lblista.BackColor = System.Drawing.Color.Cornsilk;
            this.lblista.Location = new System.Drawing.Point(134, 43);
            this.lblista.Name = "lblista";
            this.lblista.Size = new System.Drawing.Size(274, 109);
            this.lblista.TabIndex = 0;
            this.lblista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblista.Click += new System.EventHandler(this.lblista_Click);
            // 
            // lbtotal
            // 
            this.lbtotal.BackColor = System.Drawing.Color.Cornsilk;
            this.lbtotal.Location = new System.Drawing.Point(197, 172);
            this.lbtotal.Name = "lbtotal";
            this.lbtotal.Size = new System.Drawing.Size(114, 33);
            this.lbtotal.TabIndex = 0;
            this.lbtotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Precio Total A Pagar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lista de Productos";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 304);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbtotal);
            this.Controls.Add(this.lblista);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblista;
        private System.Windows.Forms.Label lbtotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}