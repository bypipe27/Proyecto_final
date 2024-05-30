﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_final.modelos;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Proyecto_final.forms
{
    public partial class VentanaPruebas : Form
    {
        int anchoAreaTrabajo;
        int altoAreaTrabajo;
        private NaveJugador naveJugador = new NaveJugador();
        List<PictureBox> disparosJugador = new List<PictureBox>();
        public VentanaPruebas()
        {
            InitializeComponent();
            anchoAreaTrabajo = ClientSize.Width;
            altoAreaTrabajo = ClientSize.Height;

            IniciarPartida();
        }

        public void IniciarPartida()
        {
            lblPuntaje.Text = "0000";


            int JugadorPosInicialX = this.ClientSize.Width / 2 - (naveJugador.Size.Width / 2);
            int JugadorPosInicialY = this.ClientSize.Height - naveJugador.Size.Height;
            naveJugador.establecerPosicion(JugadorPosInicialX, JugadorPosInicialY);
            naveJugador.Visible = true;
            this.Controls.Add(naveJugador);


        }

        private void MovimientoNaveJugador(object sender, KeyEventArgs e)
        {
            int coorActualNaveJugadorX = naveJugador.Location.X;
            int coorActualNaveJugadorY = naveJugador.Location.Y;
            switch (e.KeyCode)
            {
                case Keys.Right:
                    if (coorActualNaveJugadorX < ClientSize.Width - naveJugador.Size.Width) coorActualNaveJugadorX += naveJugador.velocidadMovNaveJugador();
                    break;
                case Keys.Left:
                    if (coorActualNaveJugadorX > 0) coorActualNaveJugadorX -= naveJugador.velocidadMovNaveJugador();
                    break;
                case Keys.Up:
                    if (coorActualNaveJugadorY > 0) coorActualNaveJugadorY -= naveJugador.velocidadMovNaveJugador();
                    break;
                case Keys.Down:
                    if (coorActualNaveJugadorY < ClientSize.Height - naveJugador.Size.Height) coorActualNaveJugadorY += naveJugador.velocidadMovNaveJugador();
                    break;
                case Keys.Space:
                    int disparoPosX = ClientSize.Width - naveJugador.Size.Width / 2;
                    int disparoPosY = ClientSize.Height - naveJugador.Size.Height;
                    PictureBox disparoJugador = naveJugador.tipoDeMunicion();
                    disparoJugador.Location = new System.Drawing.Point(disparoPosX, disparoPosY);
                    disparoJugador.Visible = true;
                    disparosJugador.Add(disparoJugador);
                    this.Controls.Add(disparoJugador);
                    break;
                default: Debug.WriteLine("Tecla no válida"); break;
            }

            naveJugador.establecerPosicion(coorActualNaveJugadorX, coorActualNaveJugadorY);
        }

        private void flujoDeTrabajo(object sender, EventArgs e)
        {
            for (int i = 0; i < disparosJugador.Count; i++)
            {
                disparosJugador[i].Top += naveJugador.velocidadMovNaveJugador() * 2;
                if (disparosJugador[i].Bottom < 0)
                {
                    disparosJugador[i].Visible = false;
                    this.Controls.Remove(disparosJugador[i]);
                    disparosJugador.Remove(disparosJugador[i]);
                }
            }
        }

            
    }
}