using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        int coorActualNaveJugadorX;
        int coorActualNaveJugadorY;
        private NaveJugador naveJugador = new NaveJugador();
        List<PictureBox> disparosJugador = new List<PictureBox>();
        Dictionary<Keys, bool> estadosTeclas = new Dictionary<Keys, bool>() 
        {
                { Keys.Right, false},
                { Keys.Left, false},
                { Keys.Up, false},
                { Keys.Down, false}
        };

        Image imgMunicionJugador;
        Size tamanoMunicionJug;
        


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
            imgMunicionJugador = naveJugador.tipoDeMunicion().Image;
            tamanoMunicionJug = naveJugador.tipoDeMunicion().Size;

            timerFlujoDisparos.Start();
            timerMovJugador.Start();
        }

        private void keyDownAction(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Right ||
                    e.KeyCode == Keys.Left ||
                    e.KeyCode == Keys.Up ||
                    e.KeyCode == Keys.Down)
            {
                estadosTeclas[e.KeyCode] = true;
            }

        }

        private void keyUpAction(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                PictureBox disparoJugador = new PictureBox()
                {
                    Image = imgMunicionJugador,
                    Size = tamanoMunicionJug,
                    SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
                    TabIndex = 2,
                    TabStop = false,
                    Visible = false,
                };
                int disparoPosX = naveJugador.Location.X - disparoJugador.Width / 2 + naveJugador.Width / 2 + 1;
                int disparoPosY = naveJugador.Location.Y + disparoJugador.Height;
                disparoJugador.Location = new System.Drawing.Point(disparoPosX, disparoPosY);
                disparoJugador.Visible = true;
                disparosJugador.Add(disparoJugador);
                this.Controls.Add(disparoJugador);
                estadosTeclas[Keys.Space] = false;
            }

            if (e.KeyCode == Keys.Right ||
                   e.KeyCode == Keys.Left ||
                   e.KeyCode == Keys.Up ||
                   e.KeyCode == Keys.Down )
            {
                estadosTeclas[e.KeyCode] = false;
            }
            
        }

        private void timerDisparos(object sender, EventArgs e)
        {
            timerFlujoDisparos.Stop();
            for (int i = 0; i < disparosJugador.Count; i++)
            {
                disparosJugador[i].Top -= naveJugador.velocidadMovNaveJugador()*5;
                if (disparosJugador[i].Bottom < 0)
                {
                    disparosJugador[i].Visible = false;
                    this.Controls.Remove(disparosJugador[i]);
                    disparosJugador.Remove(disparosJugador[i]);
                }
            }
            timerFlujoDisparos.Enabled = true;
        }

        private void timerFlujoDeMovJug(object sender, EventArgs e)
        {
            timerMovJugador.Stop();
            coorActualNaveJugadorX = naveJugador.Location.X;
            coorActualNaveJugadorY = naveJugador.Location.Y;

            if (estadosTeclas[Keys.Right] && coorActualNaveJugadorX < ClientSize.Width - naveJugador.Size.Width)
                coorActualNaveJugadorX += naveJugador.velocidadMovNaveJugador();

            if (estadosTeclas[Keys.Left] && coorActualNaveJugadorX > 0)
                coorActualNaveJugadorX -= naveJugador.velocidadMovNaveJugador();

            if (estadosTeclas[Keys.Up] && coorActualNaveJugadorY > 0)
                coorActualNaveJugadorY -= naveJugador.velocidadMovNaveJugador();

            if (estadosTeclas[Keys.Down] && coorActualNaveJugadorY < ClientSize.Height - naveJugador.Size.Height)
                coorActualNaveJugadorY += naveJugador.velocidadMovNaveJugador();

            naveJugador.establecerPosicion(coorActualNaveJugadorX, coorActualNaveJugadorY);
            timerMovJugador.Enabled=true;
        }
    }
}
