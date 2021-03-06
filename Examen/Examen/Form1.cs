﻿using System;
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
    public partial class Form1 : Form
    {
        bool ver = false;
        Juego juego;
        int contadorPuntajes = 0;
        List<int> numeros = new List<int>();
        public Form1()
        {
            InitializeComponent();
            puntajes.Items.Add(0 + " puntos,\t nombre: " + "prueba" +" \t Tiempo: "+ "9999999");
            intro();
        }

        private void BotonSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BotonIngresar_Click(object sender, EventArgs e)
        {
            if ((TNombreUsuario.Text == "") || (TNombreUsuario == null))
            {
                MessageBox.Show("Ingrese nombre de usuario");
                return;
            }
            else if (TNombreUsuario.Text.Length < 3)
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
                intro();
                foreach (object item in puntajes.Items)
                {
                    string[] separados = item.ToString().Split(new char[0]);
                    string uso = separados[0];
                    int numero = Int32.Parse(uso);
                    numeros.Add(numero);
                    if (numero >= juego.puntaje())
                    {
                        contadorPuntajes++;

                    }
                }
                if (contadorPuntajes < 10)
                {
                    puntajes.Items.Add(juego.puntaje() + " puntos,\t nombre: " + TNombreUsuario.Text + " \t Tiempo: " + juego.timepo());
                    contadorPuntajes = 0;
                    if (puntajes.Items.Count > 10)
                    {
                        int a = -1;
                        int b = -1;
                        int low = -1;
                        foreach (int numero in numeros)
                        {
                            b = a;
                            a = numero;

                            if (b == -1)
                            {
                                continue;
                            }
                            if (a < b) low = a;
                            else low = b;
                        }
                        foreach (object item in puntajes.Items)
                        {
                            string[] separados = item.ToString().Split(new char[0]);
                            string uso = separados[0];
                            int numero = Int32.Parse(uso);
                            if (numero == low)
                            {
                                puntajes.Items.Remove(item);
                                break;
                            }
                        }
                    }
                    TNombreUsuario.Text = "";
                    return;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void intro()
        {
            SoundPlayer simpleSound = new SoundPlayer(@"..\..\..\..\start-pacman.wav");
            simpleSound.Play();
        }
    }
}
