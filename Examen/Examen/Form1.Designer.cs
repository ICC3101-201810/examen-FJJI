namespace Examen
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
            this.TNombreUsuario = new System.Windows.Forms.TextBox();
            this.BotonIngresar = new System.Windows.Forms.Button();
            this.BotonSalir = new System.Windows.Forms.Button();
            this.puntajes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenido a Pacman";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(282, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese Su Nombre :";
            // 
            // TNombreUsuario
            // 
            this.TNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TNombreUsuario.Location = new System.Drawing.Point(309, 99);
            this.TNombreUsuario.Name = "TNombreUsuario";
            this.TNombreUsuario.Size = new System.Drawing.Size(343, 38);
            this.TNombreUsuario.TabIndex = 2;
            // 
            // BotonIngresar
            // 
            this.BotonIngresar.Location = new System.Drawing.Point(647, 378);
            this.BotonIngresar.Name = "BotonIngresar";
            this.BotonIngresar.Size = new System.Drawing.Size(141, 60);
            this.BotonIngresar.TabIndex = 3;
            this.BotonIngresar.Text = "Ingresar";
            this.BotonIngresar.UseVisualStyleBackColor = true;
            this.BotonIngresar.Click += new System.EventHandler(this.BotonIngresar_Click);
            // 
            // BotonSalir
            // 
            this.BotonSalir.Location = new System.Drawing.Point(12, 378);
            this.BotonSalir.Name = "BotonSalir";
            this.BotonSalir.Size = new System.Drawing.Size(141, 60);
            this.BotonSalir.TabIndex = 4;
            this.BotonSalir.Text = "Salir";
            this.BotonSalir.UseVisualStyleBackColor = true;
            this.BotonSalir.Click += new System.EventHandler(this.BotonSalir_Click);
            // 
            // puntajes
            // 
            this.puntajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puntajes.FormattingEnabled = true;
            this.puntajes.ItemHeight = 20;
            this.puntajes.Location = new System.Drawing.Point(188, 162);
            this.puntajes.Name = "puntajes";
            this.puntajes.Size = new System.Drawing.Size(500, 184);
            this.puntajes.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 62);
            this.label3.TabIndex = 6;
            this.label3.Text = "Maximos\r\npuntajes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.puntajes);
            this.Controls.Add(this.BotonSalir);
            this.Controls.Add(this.BotonIngresar);
            this.Controls.Add(this.TNombreUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TNombreUsuario;
        private System.Windows.Forms.Button BotonIngresar;
        private System.Windows.Forms.Button BotonSalir;
        private System.Windows.Forms.ListBox puntajes;
        private System.Windows.Forms.Label label3;
    }
}

