using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; // desactiva la deteccion de llamadas no seguras a controles WindowsForms            
        }

        #region Declaraciones Globales
        //configuracion del juego
        int jugadoresMax;
        int puertoEscucha = 3000;
        private static object key = new object();
        List<Jugador> Jugadores = new List<Jugador>();
        delegate void DelegadoInstruccion(int numInstruccion, string mensaje);
        delegate void DelegadoEscribirLista();
        delegate void DelegadoRespuesta();

        DelegadoEscribirLista del;

        TimeSpan horaConexion;
        TcpListener newsock;
        Partida p = new Partida();
        Jugador j;
        Thread t;
        #endregion

        private void RecibirClientes()
        {
            try
            {
                newsock = new TcpListener(IPAddress.Any, Convert.ToInt32(numericUpDown_puertoEscucha.Value));
                newsock.Start();

                Console.WriteLine("Esperando por clientes");

                while (true)
                {
                    TcpClient cliente = newsock.AcceptTcpClient(); //linea bloqueante
                    Thread t = new Thread(() => this.ManejarCliente(cliente));
                    t.Start();
                }
            }
            catch (Exception er)
            {
                Console.WriteLine(er.ToString());
            }
        }

        private void ManejarCliente(TcpClient cli)
        {
            string data;

            NetworkStream ns = cli.GetStream();
            StreamReader sr = new StreamReader(ns);
            StreamWriter sw = new StreamWriter(ns);
            string ip = cli.Client.RemoteEndPoint.ToString().Split(':')[0];

            //confirmacion de conexion  
            sw.WriteLine("OK");
            sw.Flush();


            while (true)
            {
                try
                {
                    //Manejo del cliente
                    //instrucciones del juego AQUI

                    data = sr.ReadLine();
                    Console.WriteLine("data: " + data); //para depurar en el server
                    String[] subdatos = data.Split('#');

                    #region comINSCRIBIR
                    if (subdatos[1] == "INSCRIBIR")
                    {
                        if (!p.PartidaIniciada)
                        {
                            if (Jugadores.Count < jugadoresMax)
                            {
                                if (!Jugadores.Any(c => c.Nick.Equals(subdatos[2])))
                                {
                                    puertoEscucha++;
                                    sw.WriteLine("#OK#" + puertoEscucha + "#");
                                    sw.Flush();
                                    EnviarInstruccion(8, subdatos[2] + " ENTRÓ EN LA SALA" + "#"); //Aviso a todos los jugadores que el cliente entró en la sala
                                    Jugadores.Add(new Jugador(cli, subdatos[2], cli.Client.RemoteEndPoint.ToString().Split(':')[0], puertoEscucha));
                                    del = new DelegadoEscribirLista(escribirListaClientes);
                                    del.Invoke();
                                }
                                else
                                {
                                    sw.WriteLine("#NOK#el nick ya existe, elige otro");
                                    sw.Flush();
                                }

                            }
                            else
                            {
                                sw.WriteLine("#NOK#Límite máximo de " + jugadoresMax + " jugadores alcanzado#");
                                sw.Flush();
                            }
                        }
                        else
                        {
                            sw.WriteLine("#NOK#Ya hay una partida en curso#");
                            sw.Flush();
                        }
                    }
                    #endregion

                    #region com LISTOPARAJUGAR
                    if (subdatos[1] == "LISTOPARAJUGAR")
                    {
                        lock (key)
                        {
                            try
                            {
                                Jugador j = Jugadores.Find(c => c.Cliente.Equals(cli));
                                Console.WriteLine(subdatos[1]);
                                //El jugador esta listo para jugar la partida
                                j.Listoparajugar = true;
                                sw.WriteLine("#OK#" + numericUpDown_tiempoRonda.Value + "#");
                                sw.Flush();

                                EnviarInstruccion(8, j.Nick.ToUpper() + " ESTÁ LISTO!" + "#");


                                // SI TODOS LOS JUGADORES ESTÁN LISTOS INICIA NUEVA PARTIDA
                                if (Jugadores.All(c => c.Listoparajugar) == true)
                                {
                                    Console.WriteLine("Todos los jugadores estan listos para jugar");
                                    p.PartidaIniciada = true;
                                    p.MaxPuntos = Convert.ToInt32(numericUpDown_maxPuntos.Value);
                                    p.MaxRondas = Convert.ToInt32(numericUpDown_maxRondas.Value);

                                    //Envia instruccion de nueva partida con la primera imagen de la pila
                                    EnviarInstruccion(3);
                                }
                            }

                            catch (Exception error)
                            {
                                sw.WriteLine("#NOK#" + error);
                                sw.Flush();
                            }
                        }
                    }
                    #endregion

                    #region com JUGADA
                    if (subdatos[1] == "JUGADA")
                    {
                        lock (key)
                        {
                            if (p.Respuesta == subdatos[2]) //respuesta acertada
                            {
                                j = Jugadores.Find(c => c.Cliente == cli);
                                j.RespuestaAdivinada = true;
                                sw.WriteLine("#OK#correcto");
                                sw.Flush();
                                EnviarInstruccion(8, j.Nick.ToUpper() + " ACERTÓ!");
                            }
                            else
                            {
                                sw.WriteLine("#OK#incorrecto");
                                sw.Flush();
                            }
                        }
                    }
                    #endregion

                    #region com PUNTUACION
                    if (subdatos[1] == "PUNTUACION")
                    {
                        try
                        {
                            j = Jugadores.Find(c => c.Cliente == cli);
                            j.Puntuacion += Convert.ToInt32(subdatos[2]);
                            sw.WriteLine("#OK#");
                            sw.Flush();
                        }
                        catch (Exception er)
                        {
                            sw.WriteLine("#NOK#" + er);
                            sw.Flush();
                        }
                    }
                    #endregion

                    #region com FIN DE RONDA
                    if (subdatos[1] == "FINDERONDA")
                    {
                        lock (key)
                        {
                            j = Jugadores.Find(c => c.Cliente == cli);
                            j.PartidaFinalizada = true;
                            sw.WriteLine("#OK#faltan " + Jugadores.Where(c => c.PartidaFinalizada == false).ToList().Count + " jugadores#");
                            sw.Flush();
                            EnviarInstruccion(7);
                        }
                    }
                    #endregion

                    #region com CHAT
                    if (subdatos[1] == "MSGCHAT")
                    {
                        EnviarInstruccion(8, subdatos[2]);
                    }
                    #endregion

                    #region comDESCONEXION

                    if (subdatos[1] == "DESCONEXION")
                    {
                        lock (key)
                        {
                            j = Jugadores.Find(c => c.Cliente.Equals(cli));
                            Jugadores.Remove(j);
                            del = new DelegadoEscribirLista(escribirListaClientes);
                            EnviarInstruccion(8, j.Nick.ToUpper() + " SE DESCONECTÓ");
                            del.Invoke();
                            cli.Close();
                        }
                    }
                    #endregion

                }
                catch (Exception error)
                {
                    Console.WriteLine("Errro: {0}", error.ToString());
                    break;
                }
            }
        }

        private void buttonStartServer_Click(object sender, EventArgs e)
        {

            CargarImagenes();
            jugadoresMax = Convert.ToInt32(numericUpDown_maxPlayers.Value);
            horaConexion = DateTime.Now.TimeOfDay;
            timer_uptime.Start();
            SwitchStartStopButtons();
            label_connectedPlayers.Text = "Esperando jugadores...";
            //thread de repción continua de clientes;
            t = new Thread(this.RecibirClientes);
            t.Start();
        }

        private void escribirListaClientes()
        {
            listbox_connectedPlayers.Items.Clear();

            foreach (var j in Jugadores)
            {
                string player = j.Nick + " - Ip:" + j.Ip + " Puerto: " + j.PuertoEscucha;
                listbox_connectedPlayers.Items.Add(player);
            }
            label_connectedPlayers.Text = "Jugadores conectados (" + Jugadores.Count + ")";
        }

        private void button_StopServer_Click(object sender, EventArgs e)
        {
            EnviarInstruccion(11);
            try
            {
                label_connectedPlayers.Text = "Inicia el servidor";
                label_ServerState.Text = "Estado del servidor: APAGADO";
                timer_uptime.Stop();
                Jugadores.Clear();
                listbox_connectedPlayers.Items.Clear();
                newsock.Stop();
                t.Abort();
                SwitchStartStopButtons();
                progressBar_imagenes.Value = 0;
                p.ListaImg.Clear();

            }
            catch (Exception er)
            { Console.WriteLine(er); }
        }

        private void timer_uptime_Tick(object sender, EventArgs e)
        {
            TimeSpan horaActual = DateTime.Now.TimeOfDay;
            label_ServerState.Text = "Estado del servidor: ACTIVO " + (horaActual - horaConexion).ToString().Split('.')[0];
        }

        public void SwitchStartStopButtons()
        {
            button_StopServer.Enabled = !button_StopServer.Enabled;
            button_StopServer.Visible = !button_StopServer.Visible;
            buttonStartServer.Enabled = !buttonStartServer.Enabled;
            buttonStartServer.Visible = !buttonStartServer.Visible;
            button_kickPlayer.Enabled = !button_kickPlayer.Enabled;
            numericUpDown_puertoEscucha.Enabled = !numericUpDown_puertoEscucha.Enabled;
            numericUpDown_maxPuntos.Enabled = !numericUpDown_maxPuntos.Enabled;
            numericUpDown_maxPlayers.Enabled = !numericUpDown_maxPlayers.Enabled;
            numericUpDown_maxRondas.Enabled = !numericUpDown_maxRondas.Enabled;
            numericUpDown_tiempoRonda.Enabled = !numericUpDown_tiempoRonda.Enabled;
            p.PartidaIniciada = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            button_StopServer_Click(sender, e);
        }

        private void EnviarInstruccion(int numInstruccion, string mensaje = "")
        {
            lock (key)
            {
                Thread.Sleep(100);
                TcpClient cliente;
                NetworkStream ns;
                StreamReader sr;
                StreamWriter sw;

                #region Instruccion Nueva Partida - 3
                if (numInstruccion == 3) //ENVIO INSTRUCCION DE NUEVA PARTIDA
                {
                    p.RondaActual++;

                    foreach (Jugador j in Jugadores)
                    {
                        j.PartidaFinalizada = false;
                        j.RespuestaAdivinada = false;

                        cliente = new TcpClient(j.Ip, j.PuertoEscucha);
                        ns = cliente.GetStream();
                        sr = new StreamReader(ns);
                        sw = new StreamWriter(ns);

                        sw.WriteLine("#INICIARNUEVAPARTIDA#");
                        sw.Flush();
                        string dato = sr.ReadLine(); //recibe respuesta del cliente
                        if (dato.Split('#')[1].Equals("OK"))
                        {
                            try
                            {
                                //Enviar Imagen
                                Bitmap tImage = p.NewImg();

                                sw.WriteLine("#PISTA#" + p.Respuesta + "#");
                                sw.Flush();

                                ImageConverter imageConverter = new ImageConverter();

                                byte[] bStream = (byte[])imageConverter.ConvertTo(tImage, typeof(byte[])); //convierte imagen a array de byte
                                ns.Write(bStream, 0, bStream.Length);
                            }
                            catch (SocketException er)
                            {
                                Console.WriteLine("Error Envio: " + er);
                            }
                        }
                        else
                        {
                            Console.WriteLine("No se pudo iniciar la partida");
                        }
                        cliente.Close();
                    }
                }
                #endregion

                #region Enviar Resultado total - 7
                if (numInstruccion == 7) //ENVIAR RESULTADO TOTAL
                {
                    if (Jugadores.All(c => c.PartidaFinalizada == true))
                    {
                        string resultados = "#RESULTADOTOTAL#";
                        int cont = 0;
                        foreach (Jugador j in Jugadores.OrderByDescending(c => c.Puntuacion))
                        {
                            cont++;
                            resultados += cont + ") " + j.Nick + " - " + j.Puntuacion + "#";
                        }

                        foreach (Jugador j in Jugadores)
                        {
                            //Envio resultados a todos los clientes
                            cliente = new TcpClient(j.Ip, j.PuertoEscucha);
                            ns = cliente.GetStream();
                            sr = new StreamReader(ns);
                            sw = new StreamWriter(ns);
                            sw.WriteLine(resultados);
                            sw.Flush();
                        }

                        Console.WriteLine("ronda: " + p.RondaActual);

                        //COMPRUEBA SI SE ALCANZÓ EL NUMERO MAX DE RONDAS, 
                        //TODO NUMERO MAX DE PUNTOS

                        if (p.RondaActual < numericUpDown_maxRondas.Value)
                        {
                            EnviarInstruccion(3);
                        }
                        else
                        {
                            //FIN DE LA PARTIDA
                            EnviarInstruccion(9);
                        }
                    }
                }
                #endregion

                #region Enviar Mensaje - 8
                if (numInstruccion == 8) //ENVIO DE MENSAJE DE CHAT
                {
                    foreach (Jugador j in Jugadores)
                    {
                        //envio info al primer cliente
                        cliente = new TcpClient(j.Ip, j.PuertoEscucha);
                        ns = cliente.GetStream();
                        sr = new StreamReader(ns);
                        sw = new StreamWriter(ns);
                        Console.WriteLine(j.Nick + ":" + mensaje);
                        sw.WriteLine("#MSGCHAT#" + mensaje);
                        sw.Flush();
                    }
                }
                #endregion

                #region EnviarDesconexion - 11
                if (numInstruccion == 11 && mensaje == "")
                {
                    foreach (Jugador j in Jugadores)
                    {
                        cliente = new TcpClient(j.Ip, j.PuertoEscucha);
                        ns = cliente.GetStream();
                        sr = new StreamReader(ns);
                        sw = new StreamWriter(ns);
                        sw.WriteLine("#DESCONEXION#");
                        sw.Flush();
                        string dato = sr.ReadLine(); //recibe respuesta del cliente
                        if (dato.Split('#')[1] == "OK")
                        {
                            j.Cliente.Close();
                            j.Cliente.Dispose();
                        }
                    }
                }
                if (numInstruccion == 11 && mensaje != "")
                {
                    if (listbox_connectedPlayers.SelectedIndex > -1)
                    {
                        try
                        {
                            string value = listbox_connectedPlayers.Text;
                            string ip = value.Split(':')[1].Split(' ')[0].Trim();
                            int puerto = Convert.ToInt32(value.Split(':')[2].Trim());

                            cliente = new TcpClient(ip, puerto);
                            ns = cliente.GetStream();
                            sr = new StreamReader(ns);
                            sw = new StreamWriter(ns);
                            sw.WriteLine("#DESCONEXION#");
                            sw.Flush();
                            string dato = sr.ReadLine(); //recibe respuesta del cliente
                            if (dato.Split('#')[1] == "OK")
                            {
                                listbox_connectedPlayers.Items.RemoveAt(listbox_connectedPlayers.SelectedIndex);
                                Jugadores.Remove(Jugadores.Where(c => c.PuertoEscucha.Equals(puerto)).First());
                                label_connectedPlayers.Text = "Jugadores conectados (" + Jugadores.Count + ")";
                                cliente.Close();
                            }
                        }
                        catch (Exception er)
                        {
                            Console.WriteLine(er);
                        }
                    }
                }
                #endregion

                #region FIN DE PARTIDA

                if (numInstruccion == 9) // FIN DE PARTIDA
                {
                    p.PartidaIniciada = false;
                    p.RondaActual = 0;
                    p.ListaImg = p.Barajar(p.ListaImg);

                    //recuento de puntos y podio
                    List<Jugador> podio = new List<Jugador>();
                    podio = Jugadores.Where(c => c.Puntuacion.Equals(Jugadores.Max(x => x.Puntuacion))).ToList();
                    string clasificacion = "#";
                    if (podio.Count > 1)
                    {
                        clasificacion += "HAY " + podio.Count + " GANADORES EMPATADOS:#";
                    }
                    else
                    {
                        clasificacion += "GANADOR:#";
                    }
                    foreach (Jugador x in podio)
                    {
                        clasificacion += x.Nick.ToUpper() + " - " + x.Puntuacion + "PUNTOS#";
                    }

                    foreach (Jugador j in Jugadores)
                    {
                        cliente = new TcpClient(j.Ip, j.PuertoEscucha);
                        ns = cliente.GetStream();
                        sr = new StreamReader(ns);
                        sw = new StreamWriter(ns);
                        Console.WriteLine("ENTRO AQUI " + j.Nick + "pts: " + j.Puntuacion);
                        j.Listoparajugar = false;
                        j.PartidaFinalizada = false;
                        j.Puntuacion = 0;
                        j.RespuestaAdivinada = false;
                        Console.WriteLine("SALIO AQUI " + j.Nick + "pts: " + j.Puntuacion);
                        sw.WriteLine("#FINDEPARTIDA#=====FIN DE LA PARTIDA=====" + clasificacion);
                        sw.Flush();
                        Console.WriteLine(sr.ReadLine());
                    }
                }
                #endregion
            }
        }

        private void CargarImagenes()
        {
            progressBar_imagenes.Maximum = Directory.GetFiles(Environment.CurrentDirectory + "/imagenes/").Count();
            //Carga de imagenes en la lista

            string[] imagenes = Directory.GetFiles(Environment.CurrentDirectory + "/imagenes/");
            foreach (string item in imagenes)
            {
                Bitmap img = new Bitmap(item);
                img.Tag = Path.GetFileName(item).Split('.')[0].Replace('_', ' ').ToLower().Trim();
                p.ListaImg.Add(img);
                progressBar_imagenes.Value = p.ListaImg.Count();
            }

            listbox_connectedPlayers.Items.Add(p.ListaImg.Count + " Imagenes cargadas");
            p.ListaImg = p.Barajar(p.ListaImg);
        }

        private void button_kickPlayer_Click(object sender, EventArgs e)
        {
            EnviarInstruccion(11, "kickPlayer");
        }
    }
}


