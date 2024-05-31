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
using Proyecto_final.utilidades;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace Proyecto_final.forms
{
    public partial class VentanaPruebas : Form
    {
        int cntMinions = 20;
        List<EnemigoMinion> enemigosActivos = new List<EnemigoMinion>();
        int anchoAreaTrabajo;
        int altoAreaTrabajo;
        int coorActualNaveJugadorX;
        int coorActualNaveJugadorY;
        private NaveJugador naveJugador = new NaveJugador();
        List<PictureBox> disparosJugador = new List<PictureBox>();
        List<PictureBox> disparosEnemigos = new List<PictureBox>();
        Dictionary<Keys, bool> estadosTeclas = new Dictionary<Keys, bool>()
        {
                { Keys.Right, false},
                { Keys.Left, false},
                { Keys.Up, false},
                { Keys.Down, false}
        };
        Random rand = new Random();



        public VentanaPruebas()
        {
            InitializeComponent();
            anchoAreaTrabajo = ClientSize.Width;
            altoAreaTrabajo = ClientSize.Height;

            IniciarPartida();
        }

        public void IniciarPartida()
        {
            try
            {
                lblPuntaje.Text = "0000";
                int JugadorPosInicialX = this.ClientSize.Width / 2 - (naveJugador.Size.Width / 2);
                int JugadorPosInicialY = this.ClientSize.Height - naveJugador.Size.Height;
                naveJugador.establecerPosicion(JugadorPosInicialX, JugadorPosInicialY);
                naveJugador.Visible = true;
                this.Controls.Add(naveJugador);

                timerFlujoDisparos.Start();
                timerMovJugador.Start();
                timerSpawnEnemigos.Start();
                timerGatilloMinions.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }




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
            try
            {
                if (e.KeyCode == Keys.S &&
                    (disparosJugador.Count() == 0 ||
                        (disparosJugador.Count() > 0 &&
                        disparosJugador[disparosJugador.Count() - 1].Bottom < (coorActualNaveJugadorY + MunicionJugador.getAlto()))))
                {
                    PictureBox disparoJugador = MunicionJugador.getMunicion();
                    int disparoPosX = naveJugador.Location.X - disparoJugador.Width / 2 + naveJugador.Width / 2 + 1;
                    int disparoPosY = naveJugador.Location.Y + disparoJugador.Height;

                    disparoJugador.Location = new System.Drawing.Point(disparoPosX, disparoPosY);
                    disparoJugador.Visible = true;
                    disparosJugador.Add(disparoJugador);
                    this.Controls.Add(disparoJugador);
                    estadosTeclas[Keys.Space] = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            if (e.KeyCode == Keys.Right ||
                   e.KeyCode == Keys.Left ||
                   e.KeyCode == Keys.Up ||
                   e.KeyCode == Keys.Down)
            {
                estadosTeclas[e.KeyCode] = false;
            }

        }


        private void timerDisparos(object sender, EventArgs e)
        {
            timerFlujoDisparos.Stop();
            for (int i = 0; i < disparosJugador.Count; i++)
            {
                disparosJugador[i].Top -= naveJugador.velocidadMovNaveJugador() * 5;
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

            for (int i = 0; i < enemigosActivos.Count; i++)
            {
                String orientacion = enemigosActivos[i].getOrientacionMov();
                int velocidad = enemigosActivos[i].velocidadMinion();

                if (orientacion == Direcciones.Opciones.IZQ.ToString())
                {
                    enemigosActivos[i].Left -= velocidad;
                    if (enemigosActivos[i].Right <= 0)
                    {
                        enemigosActivos[i].Visible = false;
                        this.Controls.Remove(enemigosActivos[i]);
                        enemigosActivos.Remove(enemigosActivos[i]);
                    }
                }
                else if (orientacion == Direcciones.Opciones.DER.ToString())
                {
                    enemigosActivos[i].Left += velocidad;
                    if (enemigosActivos[i].Left >= anchoAreaTrabajo)
                    {
                        enemigosActivos[i].Visible = false;
                        this.Controls.Remove(enemigosActivos[i]);
                        enemigosActivos.Remove(enemigosActivos[i]);
                    }
                }
                else if (orientacion == Direcciones.Opciones.NONE.ToString())
                {
                    enemigosActivos[i].Top += velocidad;
                    if (enemigosActivos[i].Top >= altoAreaTrabajo)
                    {
                        enemigosActivos[i].Visible = false;
                        this.Controls.Remove(enemigosActivos[i]);
                        enemigosActivos.Remove(enemigosActivos[i]);
                    }
                }


            }

            for (int i = 0; i < disparosEnemigos.Count; i++)
            {
                disparosEnemigos[i].Top += 50;
                if (disparosEnemigos[i].Bottom < 0)
                {
                    disparosEnemigos[i].Visible = false;
                    this.Controls.Remove(disparosEnemigos[i]);
                    disparosEnemigos.Remove(disparosEnemigos[i]);
                }
            }

            timerMovJugador.Enabled = true;
        }

        private void TimerFlujoaparicionEnemigos(object sender, EventArgs e)
        {
            timerSpawnEnemigos.Stop();
            if (cntMinions > 0)
            {
                EnemigoMinion enemigoMinion = new EnemigoMinion();
                int minionPosInicialX = posicionAleatoriaX(enemigoMinion.Size.Width);
                int minionPosInicialY = posicionAleatoriaY(minionPosInicialX);
                enemigoMinion.establecerPosicion(minionPosInicialX, minionPosInicialY);
                enemigoMinion.Visible = true;

                if (minionPosInicialY == 0)
                {
                    enemigoMinion.setOrientacionMov(Direcciones.Opciones.NONE.ToString());
                }
                else
                {
                    if (minionPosInicialX < anchoAreaTrabajo / 2)
                    {
                        enemigoMinion.setOrientacionMov(Direcciones.Opciones.DER.ToString());
                    }
                    else
                    {
                        enemigoMinion.setOrientacionMov(Direcciones.Opciones.IZQ.ToString());
                    }
                }
                enemigosActivos.Add(enemigoMinion);
                this.Controls.Add(enemigoMinion);
                cntMinions--;
                timerSpawnEnemigos.Enabled = true;
            }

        }

        private int posicionAleatoriaX(int sizeW)
        {
            int posX = rand.Next(anchoAreaTrabajo);

            if (posX <= anchoAreaTrabajo * 0.15)
            {
                double v = sizeW * 0.9;
                return 0 - ((int)v);
            }
            else if (posX >= anchoAreaTrabajo * 0.85)
            {
                double v = sizeW * 0.1;
                return anchoAreaTrabajo - ((int)v);
            }
            else
            {
                return posX;
            }



        }

        private int posicionAleatoriaY(int x)
        {
            if (x <= anchoAreaTrabajo * 0.15 || x >= anchoAreaTrabajo * 0.85)
            {
                return rand.Next(altoAreaTrabajo / 2);
            }
            else
            {
                return 0;
            }
        }

        private void timerDisparoMinions(object sender, EventArgs e)
        {
            timerGatilloMinions.Stop();

            for (int i = 0; i < enemigosActivos.Count; i++)
            {
                PictureBox nuevoDisparoEnemigo = MunicionMinion.getMunicion();
                int disparoPosX = enemigosActivos[i].Location.X - nuevoDisparoEnemigo.Width / 2 + enemigosActivos[i].Width / 2 + 1;
                int disparoPosY = enemigosActivos[i].Location.Y + nuevoDisparoEnemigo.Height;

                nuevoDisparoEnemigo.Location = new System.Drawing.Point(disparoPosX, disparoPosY);
                nuevoDisparoEnemigo.Visible = true;
                disparosEnemigos.Add(nuevoDisparoEnemigo);
                this.Controls.Add(nuevoDisparoEnemigo);

            }
            timerGatilloMinions.Enabled = true;
            
        }
    }
}
