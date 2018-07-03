namespace Examen
{
    partial class Juego
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Juego));
            this.label1 = new System.Windows.Forms.Label();
            this.LPuntaje = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.barra_der = new System.Windows.Forms.PictureBox();
            this.barra_alta = new System.Windows.Forms.PictureBox();
            this.Pacman = new System.Windows.Forms.PictureBox();
            this.barra_izq = new System.Windows.Forms.PictureBox();
            this.barra_baja = new System.Windows.Forms.PictureBox();
            this.redie = new System.Windows.Forms.PictureBox();
            this.Pinky = new System.Windows.Forms.PictureBox();
            this.cherry = new System.Windows.Forms.PictureBox();
            this.melon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.barra_der)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barra_alta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pacman)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barra_izq)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barra_baja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pinky)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.melon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puntaje :";
            // 
            // LPuntaje
            // 
            this.LPuntaje.AutoSize = true;
            this.LPuntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LPuntaje.Location = new System.Drawing.Point(133, 18);
            this.LPuntaje.Name = "LPuntaje";
            this.LPuntaje.Size = new System.Drawing.Size(0, 24);
            this.LPuntaje.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // barra_der
            // 
            this.barra_der.Image = global::Examen.Properties.Resources.Barra_Vertical_usar;
            this.barra_der.Location = new System.Drawing.Point(745, 51);
            this.barra_der.Name = "barra_der";
            this.barra_der.Size = new System.Drawing.Size(10, 387);
            this.barra_der.TabIndex = 4;
            this.barra_der.TabStop = false;
            // 
            // barra_alta
            // 
            this.barra_alta.Cursor = System.Windows.Forms.Cursors.Default;
            this.barra_alta.Image = global::Examen.Properties.Resources.Barra_Horizontal_usar;
            this.barra_alta.InitialImage = global::Examen.Properties.Resources.Barra_Horizontal1;
            this.barra_alta.Location = new System.Drawing.Point(39, 51);
            this.barra_alta.Name = "barra_alta";
            this.barra_alta.Size = new System.Drawing.Size(716, 15);
            this.barra_alta.TabIndex = 3;
            this.barra_alta.TabStop = false;
            // 
            // Pacman
            // 
            this.Pacman.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Pacman.Image = global::Examen.Properties.Resources.pacman_right;
            this.Pacman.InitialImage = ((System.Drawing.Image)(resources.GetObject("Pacman.InitialImage")));
            this.Pacman.Location = new System.Drawing.Point(368, 221);
            this.Pacman.Name = "Pacman";
            this.Pacman.Size = new System.Drawing.Size(18, 19);
            this.Pacman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Pacman.TabIndex = 0;
            this.Pacman.TabStop = false;
            this.Pacman.WaitOnLoad = true;
            this.Pacman.Click += new System.EventHandler(this.PacmanDerecha_Click);
            // 
            // barra_izq
            // 
            this.barra_izq.Image = global::Examen.Properties.Resources.Barra_Vertical_usar;
            this.barra_izq.Location = new System.Drawing.Point(25, 51);
            this.barra_izq.Name = "barra_izq";
            this.barra_izq.Size = new System.Drawing.Size(14, 387);
            this.barra_izq.TabIndex = 5;
            this.barra_izq.TabStop = false;
            // 
            // barra_baja
            // 
            this.barra_baja.Cursor = System.Windows.Forms.Cursors.Default;
            this.barra_baja.Image = global::Examen.Properties.Resources.Barra_Horizontal_usar;
            this.barra_baja.InitialImage = global::Examen.Properties.Resources.Barra_Horizontal1;
            this.barra_baja.Location = new System.Drawing.Point(39, 423);
            this.barra_baja.Name = "barra_baja";
            this.barra_baja.Size = new System.Drawing.Size(716, 15);
            this.barra_baja.TabIndex = 6;
            this.barra_baja.TabStop = false;
            // 
            // redie
            // 
            this.redie.Image = global::Examen.Properties.Resources.red_left1;
            this.redie.InitialImage = global::Examen.Properties.Resources.red_left1;
            this.redie.Location = new System.Drawing.Point(105, 284);
            this.redie.Name = "redie";
            this.redie.Size = new System.Drawing.Size(22, 20);
            this.redie.TabIndex = 7;
            this.redie.TabStop = false;
            // 
            // Pinky
            // 
            this.Pinky.Image = global::Examen.Properties.Resources.pink_left1;
            this.Pinky.InitialImage = global::Examen.Properties.Resources.pink_left1;
            this.Pinky.Location = new System.Drawing.Point(687, 116);
            this.Pinky.Name = "Pinky";
            this.Pinky.Size = new System.Drawing.Size(21, 21);
            this.Pinky.TabIndex = 8;
            this.Pinky.TabStop = false;
            // 
            // cherry
            // 
            this.cherry.Image = global::Examen.Properties.Resources.cherry;
            this.cherry.Location = new System.Drawing.Point(761, 399);
            this.cherry.Name = "cherry";
            this.cherry.Size = new System.Drawing.Size(21, 20);
            this.cherry.TabIndex = 9;
            this.cherry.TabStop = false;
            // 
            // melon
            // 
            this.melon.Image = global::Examen.Properties.Resources.tile114;
            this.melon.Location = new System.Drawing.Point(761, 363);
            this.melon.Name = "melon";
            this.melon.Size = new System.Drawing.Size(21, 20);
            this.melon.TabIndex = 10;
            this.melon.TabStop = false;
            // 
            // Juego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.melon);
            this.Controls.Add(this.cherry);
            this.Controls.Add(this.Pinky);
            this.Controls.Add(this.redie);
            this.Controls.Add(this.barra_baja);
            this.Controls.Add(this.barra_izq);
            this.Controls.Add(this.barra_der);
            this.Controls.Add(this.barra_alta);
            this.Controls.Add(this.LPuntaje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Pacman);
            this.Name = "Juego";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Juego";
            this.Load += new System.EventHandler(this.Juego_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barra_der)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barra_alta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pacman)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barra_izq)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barra_baja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pinky)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cherry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.melon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pacman;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LPuntaje;
        protected internal System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox barra_alta;
        private System.Windows.Forms.PictureBox barra_der;
        private System.Windows.Forms.PictureBox barra_izq;
        private System.Windows.Forms.PictureBox barra_baja;
        private System.Windows.Forms.PictureBox redie;
        private System.Windows.Forms.PictureBox Pinky;
        private System.Windows.Forms.PictureBox cherry;
        private System.Windows.Forms.PictureBox melon;
    }
}