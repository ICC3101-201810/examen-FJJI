using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Form1 : Form
    {
        bool ver = false;
        Juego juego;
        int contadorPuntajes = 0;
        public Form1()
        {
            InitializeComponent();
            puntajes.Items.Add(0 + "\t" + "prueba");
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void BotonIngresar_Click(object sender, EventArgs e)
        {
            if ((TNombreUsuario.Text == "")||(TNombreUsuario == null))
            {
                MessageBox.Show("Ingrese nombre de usuario");
                return;
            }
            else if (TNombreUsuario.Text.Length < 3 )
            {
                MessageBox.Show("Ingrese a lo menos 3 caracteres");
                return;
            }
            else
            {
                if (ver == false)
                {
                    juego = new Juego();
                    this.Hide();
                    juego.ShowDialog();
                }
                else
                {
                    this.Hide();
                    juego.ShowDialog();
                }
                this.Show();
                //abre juego

                foreach (object item in puntajes.Items)
                {
                    string[] separados = item.ToString().Split(new char[0]);
                    string uso = separados[0];
                    int numero =Int32.Parse(uso);
                    if (numero >= juego.puntaje())
                    {
                        contadorPuntajes++;
                    }
                }
                if (contadorPuntajes < 10)
                {
                    puntajes.Items.Add(juego.puntaje() + "\t" + TNombreUsuario.Text);
                    contadorPuntajes = 0;
                }
                TNombreUsuario.Text = "";
                return;
            }
        }
    }
}
