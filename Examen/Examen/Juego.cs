using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Examen
{
    public partial class Juego : Form, Ipuntaje
    {
        int puntos = 0;
        int tiempo = 0;
        int frutaTiempo = 0;
        Random ran = new Random();
        bool mov = false;
        public Juego()
        {
            InitializeComponent();
            KeyDown += new KeyEventHandler(Form1_KeyDown);
            LPuntaje.Text = puntos.ToString();
            redie.Location = new Point(ran.Next(32, 740), ran.Next(55, 415));
            Pinky.Location = new Point(ran.Next(32, 740), ran.Next(55, 415));
            melon.Visible = false;
            cherry.Visible = false;
            
        }

        private void Juego_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            puntos++;
            tiempo++;
            frutaTiempo++;
            LPuntaje.Text = puntos.ToString();
            if (tiempo % 30 == 0)
            {
                int frutita = ran.Next(2);
                if (frutita == 0)
                {
                    cherry.Location = new Point(ran.Next(35, 745), ran.Next(51, 400));
                    frutaTiempo = 0;
                    cherry.Visible = true;
                }
                if (frutita == 1)
                {
                    melon.Location = new Point(ran.Next(35, 745), ran.Next(51, 400));
                    frutaTiempo = 0;
                    melon.Visible = true;
                }
            }
            if (frutaTiempo == 10)
            {
                melon.Location = new Point(761, 363);
                cherry.Location = new Point(761, 399);
                melon.Visible = false;
                cherry.Visible = false;
            }

            if (mov == false) //castigo
            {
                int x = Pacman.Location.X;
                int y = Pacman.Location.Y;

                int xr = redie.Location.X;
                int yr = redie.Location.Y;

                int xp = Pinky.Location.X;
                int yp = Pinky.Location.Y;

                if (xr < x) xr += 10;
                else if (xr > x) xr -= 10;
                if (yr < y) yr += 10;
                else if (yr > y) yr -= 10;
                if (xp < x) xp += 10;
                else if (xp > x) xp -= 10;
                if (yp < y) yp += 10;
                else if (yp > y) yp -= 10;

                redie.Location = new Point(xr, yr);
                Pinky.Location = new Point(xp, yp);
            }
            mov = false;


        }

        private void PacmanDerecha_Click(object sender, EventArgs e)
        {

        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = Pacman.Location.X;
            int y = Pacman.Location.Y;

            //movimiento pacman
            if (e.KeyCode == Keys.Right)
            {
                x += 10;
                Pacman.Image = Examen.Properties.Resources.pacman_right;
                mov = true;
            }
            else if (e.KeyCode == Keys.Left)
            {
                x -= 10;
                Pacman.Image = Examen.Properties.Resources.pacman_left;
                mov = true;
            }
            else if (e.KeyCode == Keys.Up)
            {
                y -= 10;
                Pacman.Image = Examen.Properties.Resources.pacman_up;
                mov = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                y += 10;
                Pacman.Image = Examen.Properties.Resources.pacman_down;
                mov = true;
            }

            Pacman.Location = new Point(x, y);

            //choque con barras
            if (Pacman.Bounds.IntersectsWith(barra_alta.Bounds))
            {
                timer1.Stop();
                playDeath();
                MessageBox.Show("\tGAME OVER\n" + "Su puntaje es de: " + puntos + " Puntos");
                this.Close();
            }
            else if (Pacman.Bounds.IntersectsWith(barra_izq.Bounds))
            {
                timer1.Stop();
                playDeath();
                MessageBox.Show("\tGAME OVER\n" + "Su puntaje es de: " + puntos + " Puntos");
                this.Close();
            }
            else if (Pacman.Bounds.IntersectsWith(barra_der.Bounds))
            {
                timer1.Stop();
                playDeath();
                MessageBox.Show("\tGAME OVER\n" + "Su puntaje es de: " + puntos + " Puntos");
                this.Close();
            }
            else if (Pacman.Bounds.IntersectsWith(barra_baja.Bounds))
            {
                timer1.Stop();
                playDeath();
                MessageBox.Show("\tGAME OVER\n"+"Su puntaje es de: " + puntos + " Puntos");
                this.Close();
            }
            //movimiento fantasmas
            int xr = redie.Location.X;
            int yr = redie.Location.Y;

            int xp = Pinky.Location.X;
            int yp = Pinky.Location.Y;

            if (mov == true)
            {
                if (xr < x) xr += 1;
                else if (xr > x) xr -= 1;
                if (yr < y) yr += 1;
                else if (yr > y) yr -= 1;
                if (xp < x) xp += 1;
                else if (xp > x) xp -= 1;
                if (yp < y) yp += 1;
                else if (yp > y) yp -= 1;

                redie.Location = new Point(xr,yr);
                Pinky.Location = new Point(xp,yp);
            }
            //choque con fantasmitas
            if (Pacman.Bounds.IntersectsWith(Pinky.Bounds))
            {
                timer1.Stop();
                playDeath();
                MessageBox.Show("\tGAME OVER\n" + "Su puntaje es de: " + puntos + " Puntos");
                this.Close();
            }
            if (Pacman.Bounds.IntersectsWith(redie.Bounds))
            {
                timer1.Stop();
                playDeath();
                MessageBox.Show("\tGAME OVER\n" + "Su puntaje es de: " + puntos + " Puntos");
                this.Close();
            }

            //comer fruta
            if (Pacman.Bounds.IntersectsWith(cherry.Bounds))
            {
                puntos =  puntos + 10;
                LPuntaje.Text = puntos.ToString();
                cherry.Location = new Point(761, 399);
                
            }
            else if (Pacman.Bounds.IntersectsWith(melon.Bounds))
            {
                puntos = puntos + 15;
                LPuntaje.Text = puntos.ToString();
                melon.Location = new Point(761, 363);
                
            }
           
        }
        public int getpuntos()
        { return puntos; }
        public int puntaje()
        {
            return puntos;
        }
        private void playDeath()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"..\..\..\..\pacman-die.wav");
            simpleSound.Play();
        }
    }
}
