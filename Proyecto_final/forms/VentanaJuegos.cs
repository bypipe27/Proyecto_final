using Proyecto_final.modelos;
using Proyecto_final.utilidades;

namespace Proyecto_final.forms
{
    public partial class VentanaJuego : Form
    {
        GameOver gameOver;
        VentanaPrincipal principal;

        int cntMinions = 10;
        int cntMaximadeMinions = 6;
        List<EnemigoMinion> minionsActivos = new List<EnemigoMinion>();
        EnemigoBoss enemigoBoss = new EnemigoBoss();
        int anchoAreaTrabajo;
        int altoAreaTrabajo;
        int coorActualNaveJugadorX;
        int coorActualNaveJugadorY;
        private NaveJugador naveJugador = new NaveJugador();
        List<PictureBox> disparosJugador = new List<PictureBox>();
        List<PictureBox> disparosEnemigos = new List<PictureBox>();
        List<List<PictureBox>> disparosBoss = new List<List<PictureBox>>();
        HashSet<System.Windows.Forms.Timer> timersActivos = new HashSet<System.Windows.Forms.Timer>();
        List<System.Windows.Forms.Timer> listaTimersExplosion = new List<System.Windows.Forms.Timer>();
        Dictionary<Keys, bool> estadosTeclas = new Dictionary<Keys, bool>()
        {
                { Keys.Right, false},
                { Keys.Left, false},
                { Keys.Up, false},
                { Keys.Down, false}
        };
        Random rand = new Random();



        public VentanaJuego(VentanaPrincipal principal)
        {
            InitializeComponent();

            this.principal = principal; 
            
            anchoAreaTrabajo = ClientSize.Width;
            altoAreaTrabajo = ClientSize.Height;

            IniciarPartida();
        }

        private void abrirFormGameOver(Image msj)
        {

            foreach(System.Windows.Forms.Timer timer in timersActivos)
            {
                liberarTimer(timer);
            }

            gameOver = new GameOver(principal);
            gameOver.definirMensaje(msj);
            gameOver.MinimumSize = new Size(this.ClientSize.Width, this.ClientSize.Height);
            gameOver.MaximumSize = new Size(this.ClientSize.Width, this.ClientSize.Height);
            gameOver.Size = new Size(this.ClientSize.Width, this.ClientSize.Height);
            gameOver.Show();
            this.Controls.Clear();
            base.Dispose();
            GC.Collect();
            this.Close();
            
            
        }
        private void Btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                actualizarVidas();

                intergrarTimer(timerFlujoDisparos);
                intergrarTimer(timerMovJugador);
                intergrarTimer(timerSpawnEnemigos);
                intergrarTimer(timerGatilloMinions);
                intergrarTimer(timerMovMiniosYDisp);
                intergrarTimer(timergarbageCollector);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void actualizarVidas()
        {
            lblVidas.Text = "Vidas: " + naveJugador.getVidas().ToString();
        }

        private void actualizarPuntaje()
        {
            lblPuntaje.Text = (naveJugador.getPuntos()).PadLeft(4, '0');
        }

        private void actualizarVidaBoss()
        {
            int porcentajeVidaBoss = 100 * enemigoBoss.getVidas() / enemigoBoss.getVidaTotal();

            lblVidaBoss.Text = "Boss: " + porcentajeVidaBoss.ToString() + "%";
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
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        //Se captura los eventos referentes a cuando se suelta una tecla presionada
        private void keyUpAction(object sender, KeyEventArgs e)
        {
            

            //guarda el estado de la tecla que sera juzgada en timerFlujoDeMovJug - detiene el movimiento en la tecla liberada
            if (e.KeyCode == Keys.Right ||
                   e.KeyCode == Keys.Left ||
                   e.KeyCode == Keys.Up ||
                   e.KeyCode == Keys.Down)
            {
                estadosTeclas[e.KeyCode] = false;
            }

            e.Handled = true;

        }

        //Timer encargado de mover los disparos creados del jugador
        private void timerDisparosJugador(object sender, EventArgs e)
        {
            timerFlujoDisparos.Stop();

            for (int i = 0; i < disparosJugador.Count; i++)
            {
                disparosJugador[i].Top -= naveJugador.velocidadMovNaveJugador();
                if (disparosJugador[i].Bottom < 0)
                {
                    liberarRecursosProyectilJugador(disparosJugador[i]);
                }
            }

            //Colision proyectil nave jugador y nave boss
            if ( timersActivos.Contains(timerMovBoss))
            {
                for (int i = 0; i < disparosJugador.Count; i++)
                {
                    if (disparosJugador[i].Bounds.IntersectsWith(enemigoBoss.Bounds))
                    {
                        impactoExplosion(disparosJugador[i].Left + disparosJugador[i].Width / 2, disparosJugador[i].Top);
                        naveJugador.sumarPuntos(enemigoBoss.getPuntos());
                        actualizarPuntaje();
                        enemigoBoss.restarVida();
                        actualizarVidaBoss();
                        liberarRecursosProyectilJugador(disparosJugador[i]);
                        break;
                    }
                }
            }

            if (minionsActivos.Count > 0 ) 
            {
                //Detección de colision entre proyectiles de jugador y nave o proyectiles minions
                for (int ind = 0; ind < minionsActivos.Count; ind++)
                {
                    if (minionsActivos[ind].Bounds.IntersectsWith(naveJugador.Bounds))
                    {
                        impactoExplosion(naveJugador.Left + naveJugador.Width / 2, naveJugador.Top);
                        impactoExplosion(minionsActivos[ind].Left + minionsActivos[ind].Width / 2, minionsActivos[ind].Top);
                        danoNaveJug();
                        liberarRecursosNaveMinios(minionsActivos[ind]);
                        break;
                    }
                    for (int j = 0; j < disparosJugador.Count; j++)
                    {
                        if (minionsActivos[ind].Bounds.IntersectsWith(disparosJugador[j].Bounds))
                        {
                            impactoExplosion(disparosJugador[j].Left + disparosJugador[j].Width / 2, disparosJugador[j].Bottom);
                            naveJugador.sumarPuntos(minionsActivos[ind].getPuntos());
                            actualizarPuntaje();
                            liberarRecursosNaveMinios(minionsActivos[ind]);
                            liberarRecursosProyectilJugador(disparosJugador[j]);
                            break;
                        }
                    }
                }
            }

            if (enemigoBoss.getVidas() == 0)
            {
                this.enemigoBoss.Dispose();
                this.Controls.Remove(this.enemigoBoss);
                Image imageMsj = Image.FromFile("..\\..\\..\\Images_Gif\\youwin.gif");
                abrirFormGameOver(imageMsj);
                timerFlujoDisparos.Stop();
            }
            else
            {
                timerFlujoDisparos.Start();
            } 

            
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

            timerMovJugador.Start();
        }

        //Aqui se controla la creacion de enemigos cada cierto tiempo e inicia la aparicion del boss
        private void TimerFlujoaparicionEnemigos(object sender, EventArgs e)
        {
            timerSpawnEnemigos.Stop();
            if (cntMinions > 0 && minionsActivos.Count < cntMaximadeMinions)
            {
                EnemigoMinion enemigoMinion = new EnemigoMinion();
                int minionPosInicialX = posicionAleatoriaAparicionMinionX(enemigoMinion.Size.Width);
                int minionPosInicialY = posicionAleatoriaAparicionMinionY(minionPosInicialX);
                enemigoMinion.establecerPosicion(minionPosInicialX, minionPosInicialY + BarraTitle.Height);
                enemigoMinion.Visible = true;

                if (minionPosInicialY == 0)
                {
                    enemigoMinion.setOrientacionMov(Direcciones.Opciones.ABJ.ToString());
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

            if (cntMinions == 0 && minionsActivos.Count == 0 && disparosEnemigos.Count == 0)
            {
                enemigoBoss.Location = new System.Drawing.Point(anchoAreaTrabajo / 2 - enemigoBoss.Width / 2, -enemigoBoss.Height);
                enemigoBoss.Visible = true;
                this.Controls.Add(enemigoBoss);

                liberarTimer(timerSpawnEnemigos);
                liberarTimer(timerGatilloMinions);
                liberarTimer(timerMovMiniosYDisp);

                intergrarTimer(timerMovInicialBoss);
            }
            else
            {
                timerSpawnEnemigos.Start();
            }
        }

        //Determina la posicion aleatoria X del minion
        private int posicionAleatoriaAparicionMinionX(int sizeW)
        {
            int posX = rand.Next(anchoAreaTrabajo);

            if (posX <= anchoAreaTrabajo * 0.2)
            {
                double v = sizeW * 0.9;
                return 0 - ((int)v);
            }
            else if (posX >= anchoAreaTrabajo * 0.80)
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
        private int posicionAleatoriaAparicionMinionY(int x)
        {
            if (x <= anchoAreaTrabajo * 0.2 || x >= anchoAreaTrabajo * 0.8)
            {
                return rand.Next(altoAreaTrabajo / 2);
            }
            else
            {
                return 0;
            }
        }

        //Este timer esta encargado de crear los disparos de cada minion 
        private void timerAccionamientoDisparoMinions(object sender, EventArgs e)
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
        //ya creados en el control; asi como su eliminacion cuando salen del area de trabajo y 
        //de detectar las colisiones de la nave del jugador con los disparos de los minions
        private void timerFlujoMovMinionsYProyectiles(object sender, EventArgs e)
        {
            timerMovMiniosYDisp.Stop();

            if (this.Controls.Contains(naveJugador))
            {
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
                            liberarRecursosNaveMinios(minionsActivos[i]);
                        }
                        continue;
                    }
                    else if (orientacion == Direcciones.Opciones.DER.ToString())
                    {
                        minionsActivos[i].Left += velocidad;
                        if (minionsActivos[i].Left >= anchoAreaTrabajo)
                        {
                            liberarRecursosNaveMinios(minionsActivos[i]);
                        }
                        continue;
                    }
                    else if (orientacion == Direcciones.Opciones.ABJ.ToString())
                    {
                        minionsActivos[i].Top += velocidad;
                        if (minionsActivos[i].Top >= altoAreaTrabajo)
                        {
                            liberarRecursosNaveMinios(minionsActivos[i]);
                        }
                        continue;
                    }

                }

                //control movimiento proyectiles enemigos y su colision con nave jugador
                for (int i = 0; i < disparosEnemigos.Count; i++)
                {
                    disparosEnemigos[i].Top += 50;
                    bool colision = disparosEnemigos[i].Bounds.IntersectsWith(naveJugador.Bounds);
                    if (disparosEnemigos[i].Top > altoAreaTrabajo || colision)
                    {
                        if (colision)
                        {
                            danoNaveJug();
                            impactoExplosion(disparosEnemigos[i].Left + disparosEnemigos[i].Width / 2, disparosEnemigos[i].Top);
                        }
                        liberarRecursosProyectilMinios(disparosEnemigos[i]);
                    }

                }
                timerMovMiniosYDisp.Start();
            }
        }

        private void liberarRecursosProyectilJugador(PictureBox proyectilJugador)
        {
            proyectilJugador.Dispose();
            this.Controls.Remove(proyectilJugador);
            disparosJugador.Remove(proyectilJugador);
        }

        private void liberarRecursosNaveMinios(EnemigoMinion enemigoMinion)
        {
            enemigoMinion.Dispose();
            this.Controls.Remove(enemigoMinion);
            minionsActivos.Remove(enemigoMinion);
        }

        private void liberarRecursosProyectilMinios(PictureBox pryectilMinion)
        {
            pryectilMinion.Dispose();
            this.Controls.Remove(pryectilMinion);
            disparosEnemigos.Remove(pryectilMinion);
        }

        private void liberarRecursosProyectilBoss(List<PictureBox> proyectilBoss, int cntDisparosBoss)
        {
            for (int indice = 0; indice < cntDisparosBoss; indice++)
            {
                proyectilBoss[indice].Dispose();
                this.Controls.Remove(proyectilBoss[indice]);
            }
            disparosBoss.Remove(proyectilBoss);
        }

        private void intergrarTimer(System.Windows.Forms.Timer timer)
        {
            timersActivos.Add(timer);
            timer.Start();
        }
        
        private void liberarTimer(System.Windows.Forms.Timer timer)
        {
            timer.Enabled = false;
            timersActivos.Remove(timer);
        }
        
        //Resta la vida del jugador y lo elimina si llega a 0
        private void danoNaveJug()
        {

            naveJugador.restarVida();
            actualizarVidas();
            if (naveJugador.getVidas() == 0)
            {
                naveJugador.Location = new Point(-naveJugador.Width, -naveJugador.Height);
                naveJugador.Visible = false;
                this.Controls.Remove(naveJugador);
                naveJugador.Dispose();

                Image imageMsj = Image.FromFile("..\\..\\..\\Images_Gif\\Fondo_Gameover.gif");
                abrirFormGameOver(imageMsj);
            }

        }

        //Control de la entrada del jefe y activacion de su flujo de movimiento y disparos
        private void timerFlujoInicialMovBoss(object sender, EventArgs e)
        {
            timerMovInicialBoss.Stop();

            if (enemigoBoss.Bottom < altoAreaTrabajo / 2)
            {
                enemigoBoss.Top += enemigoBoss.velocidadBoss();
                timerMovInicialBoss.Start();
            }
            else
            {
                liberarTimer(timerMovInicialBoss);
                actualizarVidaBoss();
                lblVidaBoss.Visible = true;
                enemigoBoss.Location = new Point(posicionAleatoriaMovBossX(), posicionAleatoriaMovBossY());

                intergrarTimer(timerMovBoss);
                intergrarTimer(timerGatilloBoss);
                intergrarTimer(timerDisparosBoss);
                

            }
        }

        //Control de rafaga de la nave Boss
        private void timerAccionmientoDisparosBoss(object sender, EventArgs e)
        {
            timerGatilloBoss.Stop();

            int posicionBossX = enemigoBoss.Right - enemigoBoss.Width / 2;
            int posicionBossY = enemigoBoss.Bottom - enemigoBoss.Height / 2;

            disparosBoss.Add(municionBoss.getMunicion(posicionBossX, posicionBossY));
            int posUltimaRafaga = disparosBoss.Count - 1;
            for (int k = 0; k < municionBoss.getCntDisparos(); k++)
            {
                this.Controls.Add(disparosBoss[posUltimaRafaga][k]);
            }

            if (enemigoBoss.getVidas() == 0 || naveJugador.getVidas() == 0)
            {
                liberarTimer(timerGatilloBoss);
            }
            else
            {
                timerGatilloBoss.Start();
            }
        }

        //control del movimiento de los disparos del Boss
        private void timerFlujoDisparosBoss(object sender, EventArgs e)
        {
            timerDisparosBoss.Stop();

            int velocidadBoss = enemigoBoss.velocidadBoss();
            int cntDisparosBossNoVisibles = 0;
            int velCardinales = Convert.ToInt32(velocidadBoss * 1.3);

            for (int i = 0; i < disparosBoss.Count; i++)
            {
                for (int j = 0; j < disparosBoss[i].Count; j++)
                {
                    if (disparosBoss[i][j].Visible == true)
                    {
                        switch (j)
                        {
                            case 0:
                                disparosBoss[i][j].Top -= velCardinales;
                                break;
                            case 1:
                                disparosBoss[i][j].Top -= velocidadBoss;
                                disparosBoss[i][j].Left -= velocidadBoss;
                                break;
                            case 2:
                                disparosBoss[i][j].Left -= velCardinales;
                                break;
                            case 3:
                                disparosBoss[i][j].Left -= velocidadBoss;
                                disparosBoss[i][j].Top += velocidadBoss;
                                break;
                            case 4:
                                disparosBoss[i][j].Top += velCardinales;
                                break;
                            case 5:
                                disparosBoss[i][j].Top += velocidadBoss;
                                disparosBoss[i][j].Left += velocidadBoss;
                                break;
                            case 6:
                                disparosBoss[i][j].Left += velCardinales;
                                break;
                            case 7:
                                disparosBoss[i][j].Top -= velocidadBoss;
                                disparosBoss[i][j].Left += velocidadBoss;
                                break;

                            default:
                                Console.WriteLine("Fuera de rango de conteo - disparo boss");
                                break;
                        }

                        if (disparosBoss[i][j].Left >= anchoAreaTrabajo ||
                        disparosBoss[i][j].Right <= 0 ||
                        disparosBoss[i][j].Top >= altoAreaTrabajo ||
                        disparosBoss[i][j].Bottom <= 0)
                        {
                            disparosBoss[i][j].Visible = false;
                            cntDisparosBossNoVisibles++;
                        }

                        if (naveJugador.Bounds.IntersectsWith(disparosBoss[i][j].Bounds))
                        {
                            impactoExplosion(disparosBoss[i][j].Left + disparosBoss[i][j].Width / 2, disparosBoss[i][j].Bottom);
                            danoNaveJug();
                            disparosBoss[i][j].Visible = false;
                            cntDisparosBossNoVisibles++;
                        }
                    }
                    else
                    {
                        cntDisparosBossNoVisibles++;
                    }

                }

                if (cntDisparosBossNoVisibles == municionBoss.getCntDisparos())
                {
                    liberarRecursosProyectilBoss(disparosBoss[i], municionBoss.getCntDisparos());
                }

                cntDisparosBossNoVisibles = 0;
            }
            if (disparosBoss.Count == 0 && enemigoBoss.getVidas() == 0)
            {
                liberarTimer(timerDisparosBoss);
            }
            else
            {
                timerDisparosBoss.Start();
            }
        }

        //Se controla flujo de movimiento del boss y su colision con la nave del jugador
        private void timerFlujoMovBoss(object sender, EventArgs e)
        {
            timerMovBoss.Stop();

            enemigoBoss.Location = new Point(posicionAleatoriaMovBossX(), posicionAleatoriaMovBossY());

            if (enemigoBoss.Bounds.IntersectsWith(naveJugador.Bounds))
            {
                impactoExplosion(naveJugador.Left + naveJugador.Width / 2, naveJugador.Top);
                danoNaveJug();
            }

            timerMovBoss.Start();
        }

        //Determina la posicion aleatoria movimiento X del boss
        private int posicionAleatoriaMovBossX()
        {
            int posX = rand.Next(anchoAreaTrabajo);

            if (posX >= anchoAreaTrabajo - enemigoBoss.Width)
            {
                return anchoAreaTrabajo - enemigoBoss.Width;
            }
            else
            {
                return posX;
            }
        }

        //Determina la posicion aleatoria movimiento Y del boss
        private int posicionAleatoriaMovBossY()
        {
            int posY = rand.Next(altoAreaTrabajo / 2);

            return posY + BarraTitle.Height;

        }

        private void accionamientoGarbageCollector(object sender, EventArgs e)
        {
            timergarbageCollector.Stop();
            GC.Collect();
            timergarbageCollector.Start();
        }

        private void impactoExplosion(int X, int Y)
        {
            PictureBox Explosion = new PictureBox
            {
                Image = Image.FromFile("..\\..\\..\\Resources\\explosion_colision.png"),
                SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
                TabIndex = 2,
                TabStop = false,
                Size = new Size(40, 40),
                Location = new Point(X, Y),
                Visible = true,
                BackColor = System.Drawing.Color.Transparent
            };

            System.Windows.Forms.Timer timerExplosion = new System.Windows.Forms.Timer();
            timerExplosion.Interval = 500;
            timerExplosion.Tag = Explosion;
            timerExplosion.Tick += (sender, e) => terminarExplosion(timerExplosion.Tag, Explosion);
            listaTimersExplosion.Add(timerExplosion);

            this.Controls.Add(Explosion);
            Explosion.BringToFront();
            timerExplosion.Start();
        }

        private void terminarExplosion(object timerTag, PictureBox explosion)
        {
            try
            {
                for(int i = 0; i < listaTimersExplosion.Count; i++)
                {
                    if (listaTimersExplosion[i].Tag == timerTag)
                    {
                        listaTimersExplosion[i].Stop();
                        PictureBox expl = (PictureBox) listaTimersExplosion[i].Tag;
                        expl.Dispose();
                        listaTimersExplosion[i].Dispose();
                        listaTimersExplosion.Remove(listaTimersExplosion[i]);
                        break;
                    }
                }                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                this.Controls.Remove(explosion);
            }

        }
    }
}
