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
        int cntMinions = 10;
        List<EnemigoMinion> minionsActivos = new List<EnemigoMinion>();
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
                int JugadorPosInicialX = this.ClientSize.Width / 2 - (naveJugador.Size.Width / 2);
                int JugadorPosInicialY = this.ClientSize.Height - naveJugador.Size.Height;
                naveJugador.establecerPosicion(JugadorPosInicialX, JugadorPosInicialY);
                naveJugador.Visible = true;
                this.Controls.Add(naveJugador);
                lblVidas.Text = naveJugador.getVidas().ToString();

                timerFlujoDisparos.Start();
                timerMovJugador.Start();
                timerSpawnEnemigos.Start();
                timerGatilloMinions.Start();
                timerMovMinios.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }




        }
        //Se captura los eventos referentes a cuando se presiona una tecla
        private void keyDownAction(object sender, KeyEventArgs e)
        {
            //guarda el estado de la tecla que sera juzgada en timerFlujoDeMovJug - permite que se mueva fluido
            if (e.KeyCode == Keys.Right ||
                    e.KeyCode == Keys.Left ||
                    e.KeyCode == Keys.Up ||
                    e.KeyCode == Keys.Down)
            {
                estadosTeclas[e.KeyCode] = true;
            }

        }

        //Se captura los eventos referentes a cuando se suelta una tecla presionada
        
        private void keyUpAction(object sender, KeyEventArgs e)
        {
            try
            {
                //detecta si la tecla S encargada del disparo del jugador deja de presionarse y crea un proyecto siempre
                //y cuando no colicione con otro
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

            //guarda el estado de la tecla que sera juzgada en timerFlujoDeMovJug - detiene el movimiento en la tecla liberada
            if (e.KeyCode == Keys.Right ||
                   e.KeyCode == Keys.Left ||
                   e.KeyCode == Keys.Up ||
                   e.KeyCode == Keys.Down)
            {
                estadosTeclas[e.KeyCode] = false;
            }

        }

        //Timer encargado de mover los disparos creados del jugador
        private void timerDisparosJugador(object sender, EventArgs e)
        {
            timerFlujoDisparos.Stop();
            for (int i = 0; i < disparosJugador.Count; i++)
            {
                disparosJugador[i].Top -= naveJugador.velocidadMovNaveJugador() * 5;
                if (disparosJugador[i].Bottom < 0)
                {
                    this.Controls.Remove(disparosJugador[i]);
                    disparosJugador.Remove(disparosJugador[i]);
                }
            }

            timerFlujoDisparos.Enabled = true;
        }

        //En este timer se controla el desplazamiento de la nave del jugador
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

            timerMovJugador.Enabled = true;
        }
       
        //Aqui se controla la creacion de enemigos cada cierto tiempo
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
                minionsActivos.Add(enemigoMinion);
                this.Controls.Add(enemigoMinion);
                cntMinions--;

            }


            GC.Collect();

            timerSpawnEnemigos.Enabled = true;
        }

        //Determina la posicion aleatoria X del minion
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
        //Determina la posicion aleatoria Y del minion
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

        //Este timer esta encargado de crear los disparos de cada minion
        private void timerDisparoMinions(object sender, EventArgs e)
        {
            timerGatilloMinions.Stop();

            for (int i = 0; i < minionsActivos.Count; i++)
            {
                PictureBox nuevoDisparoEnemigo = MunicionMinion.getMunicion();
                int disparoPosX = minionsActivos[i].Location.X - nuevoDisparoEnemigo.Width / 2 + minionsActivos[i].Width / 2 + 1;
                int disparoPosY = minionsActivos[i].Location.Y + nuevoDisparoEnemigo.Height;

                nuevoDisparoEnemigo.Location = new System.Drawing.Point(disparoPosX, disparoPosY);
                nuevoDisparoEnemigo.Visible = true;
                disparosEnemigos.Add(nuevoDisparoEnemigo);
                this.Controls.Add(nuevoDisparoEnemigo);

            }
            timerGatilloMinions.Enabled = true;

        }


        //Timer que capta cuando un minion es impactado por un proyectil del jugador y la borra,
        //asi como si el minion colisiona con la nave del jugador.
        //También controla el movimiento de los minions y sus proyectiles si estos se encuentran
        //ya creados en el control; asi como su eliminacion cuando salen del area de trabajo
        private void timerFlujoMovMinions(object sender, EventArgs e)
        {
            timerMovMinios.Stop();
            //Deteccion de colision entre nave minion y proyectil o nave de jugador
            for(int ind = 0; ind < minionsActivos.Count; ind++)
            {
                if (minionsActivos[ind].Bounds.IntersectsWith(naveJugador.Bounds))
                {
                    danoNaveJug();
                    this.Controls.Remove(minionsActivos[ind]);
                    minionsActivos.Remove(minionsActivos[ind]);
                    break;
                }
                for (int j = 0; j < disparosJugador.Count; j++)
                {
                    if (minionsActivos[ind].Bounds.IntersectsWith(disparosJugador[j].Bounds))
                    {
                        naveJugador.sumarPuntos(minionsActivos[ind].getPuntos());
                        lblPuntaje.Text =  (naveJugador.getPuntos()).PadLeft(4, '0');

                        this.Controls.Remove(minionsActivos[ind]);
                        minionsActivos.Remove(minionsActivos[ind]);
                        this.Controls.Remove(disparosJugador[j]);
                        disparosJugador.Remove(disparosJugador[j]);
                        break;
                    }
                }

                
            }
            //control del movimiento de las naves minions
            for (int i = 0; i < minionsActivos.Count; i++)
            {
                String orientacion = minionsActivos[i].getOrientacionMov();
                int velocidad = minionsActivos[i].velocidadMinion();



                if (orientacion == Direcciones.Opciones.IZQ.ToString())
                {
                    minionsActivos[i].Left -= velocidad;
                    if (minionsActivos[i].Right <= 0)
                    {
                        this.Controls.Remove(minionsActivos[i]);
                        minionsActivos.Remove(minionsActivos[i]);
                    }
                    continue;
                }
                else if (orientacion == Direcciones.Opciones.DER.ToString())
                {
                    minionsActivos[i].Left += velocidad;
                    if (minionsActivos[i].Left >= anchoAreaTrabajo)
                    {
                        this.Controls.Remove(minionsActivos[i]);
                        minionsActivos.Remove(minionsActivos[i]);
                    }
                    continue;
                }
                else if (orientacion == Direcciones.Opciones.NONE.ToString())
                {
                    minionsActivos[i].Top += velocidad;
                    if (minionsActivos[i].Top >= altoAreaTrabajo)
                    {

                        this.Controls.Remove(minionsActivos[i]);
                        minionsActivos.Remove(minionsActivos[i]);
                    }
                    continue;
                }


            }
            //control movimiento proyectiles enemigos
            for (int i = 0; i < disparosEnemigos.Count; i++)
            {
                disparosEnemigos[i].Top += 50;
                if (disparosEnemigos[i].Top > altoAreaTrabajo)
                {

                    this.Controls.Remove(disparosEnemigos[i]);
                    disparosEnemigos.Remove(disparosEnemigos[i]);

                }
            }

            timerMovMinios.Enabled = true;
        }


        //Resta la vida del jugador y lo elimina si llega a 0
        private void danoNaveJug()
        {
            naveJugador.restarVida();
            lblVidas.Text = naveJugador.getVidas().ToString();
            if(naveJugador.getVidas() == 0)
            {
                this.Controls.Remove(naveJugador);
                disparosEnemigos.Remove(naveJugador);
            }
        }
    }
}
