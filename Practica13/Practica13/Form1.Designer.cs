namespace Practica13
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
            this.dgvVideojuegos = new System.Windows.Forms.DataGridView();
            this.columnaNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaGenero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaDesarrollador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnaAño = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.Label();
            this.Género = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbNombre = new System.Windows.Forms.TextBox();
            this.txtbGenero = new System.Windows.Forms.TextBox();
            this.txtbDesarrollador = new System.Windows.Forms.TextBox();
            this.txtbAño = new System.Windows.Forms.TextBox();
            this.errorProv = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEnviar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideojuegos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVideojuegos
            // 
            this.dgvVideojuegos.BackgroundColor = System.Drawing.Color.Green;
            this.dgvVideojuegos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVideojuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVideojuegos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnaNombre,
            this.columnaGenero,
            this.columnaDesarrollador,
            this.columnaAño});
            this.dgvVideojuegos.Location = new System.Drawing.Point(30, 110);
            this.dgvVideojuegos.Name = "dgvVideojuegos";
            this.dgvVideojuegos.Size = new System.Drawing.Size(434, 262);
            this.dgvVideojuegos.TabIndex = 0;
            // 
            // columnaNombre
            // 
            this.columnaNombre.Frozen = true;
            this.columnaNombre.HeaderText = "Nombre";
            this.columnaNombre.Name = "columnaNombre";
            this.columnaNombre.ReadOnly = true;
            // 
            // columnaGenero
            // 
            this.columnaGenero.Frozen = true;
            this.columnaGenero.HeaderText = "Género";
            this.columnaGenero.Name = "columnaGenero";
            this.columnaGenero.ReadOnly = true;
            // 
            // columnaDesarrollador
            // 
            this.columnaDesarrollador.Frozen = true;
            this.columnaDesarrollador.HeaderText = "Desarrollador";
            this.columnaDesarrollador.Name = "columnaDesarrollador";
            this.columnaDesarrollador.ReadOnly = true;
            // 
            // columnaAño
            // 
            this.columnaAño.Frozen = true;
            this.columnaAño.HeaderText = "Año de lanzamiento";
            this.columnaAño.Name = "columnaAño";
            this.columnaAño.ReadOnly = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(520, 281);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(80, 31);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(636, 281);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(81, 31);
            this.btnBorrar.TabIndex = 2;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(517, 113);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(67, 22);
            this.Nombre.TabIndex = 3;
            this.Nombre.Text = "Nombre";
            // 
            // Género
            // 
            this.Género.AutoSize = true;
            this.Género.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Género.Location = new System.Drawing.Point(517, 151);
            this.Género.Name = "Género";
            this.Género.Size = new System.Drawing.Size(59, 22);
            this.Género.TabIndex = 3;
            this.Género.Text = "Género";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(517, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Desarrollador";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(517, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Año de lanzamiento";
            // 
            // txtbNombre
            // 
            this.txtbNombre.BackColor = System.Drawing.SystemColors.Window;
            this.txtbNombre.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtbNombre.Location = new System.Drawing.Point(667, 113);
            this.txtbNombre.Name = "txtbNombre";
            this.txtbNombre.Size = new System.Drawing.Size(100, 20);
            this.txtbNombre.TabIndex = 4;
            // 
            // txtbGenero
            // 
            this.txtbGenero.Location = new System.Drawing.Point(667, 151);
            this.txtbGenero.Name = "txtbGenero";
            this.txtbGenero.Size = new System.Drawing.Size(100, 20);
            this.txtbGenero.TabIndex = 4;
            // 
            // txtbDesarrollador
            // 
            this.txtbDesarrollador.Location = new System.Drawing.Point(667, 188);
            this.txtbDesarrollador.Name = "txtbDesarrollador";
            this.txtbDesarrollador.Size = new System.Drawing.Size(100, 20);
            this.txtbDesarrollador.TabIndex = 4;
            // 
            // txtbAño
            // 
            this.txtbAño.Location = new System.Drawing.Point(667, 224);
            this.txtbAño.Name = "txtbAño";
            this.txtbAño.Size = new System.Drawing.Size(100, 20);
            this.txtbAño.TabIndex = 4;
            // 
            // errorProv
            // 
            this.errorProv.ContainerControl = this;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnviar.Location = new System.Drawing.Point(561, 334);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(111, 23);
            this.btnEnviar.TabIndex = 5;
            this.btnEnviar.Text = "Enviar a XBOX";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(191, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 47);
            this.label1.TabIndex = 7;
            this.label1.Text = "Títulos mejor rankeados";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Practica13.Properties.Resources.microsoft;
            this.pictureBox2.Location = new System.Drawing.Point(30, 296);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practica13.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(101, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(799, 384);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtbAño);
            this.Controls.Add(this.txtbDesarrollador);
            this.Controls.Add(this.txtbGenero);
            this.Controls.Add(this.txtbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Género);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvVideojuegos);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "XBOX México";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideojuegos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVideojuegos;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaGenero;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaDesarrollador;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnaAño;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Género;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbNombre;
        private System.Windows.Forms.TextBox txtbGenero;
        private System.Windows.Forms.TextBox txtbDesarrollador;
        private System.Windows.Forms.TextBox txtbAño;
        private System.Windows.Forms.ErrorProvider errorProv;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

