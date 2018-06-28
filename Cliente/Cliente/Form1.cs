using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using prueba_imagenes;
using System.Media;

namespace Cliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button_listo.Visible = false;
            label_CuentaAtrasInicio.Visible = false;
            radioButton_chat.Checked = true;
            radioButton_respuesta.Enabled = false;
            desconectarToolStripMenuItem.Enabled = false;
            groupBox_nick.Visible = false;
            labelPista.Visible = false;
            label_time.Visible = false;
        }

        #region Declaraciones globales
        delegate void DelegadoRespuesta();
        delegate void DelegadoNuevaPartida(Image Imagen, string pista);
        delegate void MiDelegado(string dato);
        SoundPlayer simpleSound = new SoundPlayer(Environment.CurrentDirectory + @"\..\..\Resources\timer.wav");

        TcpClient client;
        NetworkStream ns;
        StreamReader sr;
        StreamWriter sw;
        String dato;

        int puertoEscucha;
        int xy = 0; //tamaño de la miniatura pixelizada
        int cuentaAtrasRonda; //cuenta atras de la ronda
        int tiempoRonda;
        int cuentaAtrasInicio; // cuenta atras para el inicio de la partida
        int tiempoPista; //tiempo para que se muestre la pista
        int rondaActual;
        string pista = "";
        string pistaAux = "";
        Image ImagenActual;
        Random rnd = new Random();

        #endregion

        private void NuevaPartida(Image Imagen, string pista) //inicio de una nueva partida 
        {
            cuentaAtrasRonda = tiempoRonda;
            try
            {
                listBox_chat.Items.Clear();
            }
            catch (Exception er)
            { Console.WriteLine(er); }
            xy = 0;
            progressBar1.Maximum = cuentaAtrasRonda;
            ImagenActual = Imagen;
            try
            {
                this.pista = pista;
            }
            catch (Exception er)
            {
                Console.WriteLine("pista: " + er);
            }
            cuentaAtrasInicio = 3;
            tiempoPista = (cuentaAtrasRonda / 2);
            label_CuentaAtrasInicio.Visible = true;
            label_time.Visible = true;
            timer_cuentaInicio.Enabled = true;
            simpleSound.Play();
            timer_cuentaInicio.Start();
        }

        private void timerImagen_Tick(object sender, EventArgs e) // timer pixelar imagen 
        {
            xy += 1;

            Bitmap b = (Bitmap)ImagenActual;
            pictureBox1.Image = b.GetThumbnailImage(xy, xy, null, IntPtr.Zero);

        }

        private void timer_cuentaAtras_Tick(object sender, EventArgs e) // timer cuenta atras de la ronda 
        {
            progressBar1.Value = cuentaAtrasRonda;

            if (cuentaAtrasRonda > 0)
            {
                label_time.Text = "Tiempo: " + cuentaAtrasRonda;
                cuentaAtrasRonda--;
                labelPista.Visible = true;

                if (cuentaAtrasRonda <= tiempoPista) // se muestra la pista al cumplir la condicion 
                {
                    string aux1 = "Pista: ";

                    if (cuentaAtrasRonda <= (tiempoPista / 2))
                    {
                        Random rnd = new Random();
                        int num = rnd.Next(0, pista.Length - 1);
                        char aux = pista[num];
                        StringBuilder sb = new StringBuilder(pistaAux);
                        sb[num] = pista[num];
                        pistaAux = sb.ToString();
                        labelPista.Text = aux1 + sb.ToString();
                    }
                    else
                    {
                        pistaAux = "";

                        for (int i = 0; i < pista.Length; i++)
                        {
                            if (pista[i] != ' ')
                            {
                                pistaAux += "-";
                            }
                            else
                            {
                                pistaAux += ' ';
                            }

                            labelPista.Text = aux1 + pistaAux;

                        }
                    }
                }
                else
                {
                    labelPista.Text = "Pista en " + (cuentaAtrasRonda - tiempoPista) + "s";
                }
            }
            else
            {
                label_time.Text = "FIN";
                sw.WriteLine("#FINDERONDA#");
                sw.Flush();
                dato = sr.ReadLine();
                if (dato.Split('#')[1] == "OK")
                {
                    Console.WriteLine(dato.Split('#')[2]);
                }
                timerImagen.Stop();
                timer_cuentaAtras.Stop();
                timerImagen.Enabled = false;
                timer_cuentaAtras.Enabled = false;
                radioButton_chat.Checked = true;
            }
        }

        private void button_JUGADA_CHAT(object sender, EventArgs e) //enviar respuesta al servidor o mensaje de chat 
        {
            if (!String.IsNullOrEmpty(textbox_respuesta.Text))
            {
                try
                {
                    if (radioButton_chat.Checked)
                    {
                        sw.WriteLine("#MSGCHAT#" + textBox_nick.Text.ToUpper() + " :\t" + textbox_respuesta.Text + "#");
                        sw.Flush();
                        textbox_respuesta.Clear();
                    }

                    if (radioButton_respuesta.Checked)
                    {
                        sw.WriteLine("#JUGADA#" + textbox_respuesta.Text.ToLower().Trim() + "#"); //respuesta siempre en minuscula y sin espacios al inicio y fin
                        sw.Flush();
                        dato = sr.ReadLine();
                        if (dato.Split('#')[1] == "OK")
                        {
                            if (dato.Split('#')[2] == "correcto")
                            {
                                textbox_respuesta.Clear();
                                sw.WriteLine("#PUNTUACION#" + progressBar1.Value + "#"); // puntuacion tiempo restante.
                                sw.Flush();
                                dato = sr.ReadLine();
                                if (dato.Split('#')[1] == "OK")
                                {
                                    DelegadoRespuesta dr = new DelegadoRespuesta(respuestaAcertada);
                                    this.Invoke(dr);
                                }
                                else
                                {
                                    Console.WriteLine(dato.Split('#')[2]);
                                }
                            }
                            else if (dato.Split('#')[2] == "incorrecto")
                            {
                                sw.WriteLine("#MSGCHAT#" + textBox_nick.Text.ToUpper() + " :\t" + textbox_respuesta.Text + "\t( jugada )#");
                                sw.Flush();
                                textbox_respuesta.Clear();
                                listBox_chat.Items.Add("FALLASTE! SIGUE INTENTANDO");
                                // MessageBox.Show("Sigue intentando", "Fallaste");
                            }
                        }
                    }
                }
                catch (Exception er)
                {
                    MessageBox.Show("Tienes que estar conectado al servidor", "Error");
                    textbox_respuesta.Clear();
                    Console.WriteLine(er);
                }
            }
        }

        private void respuestaAcertada() //metodo llamado cuando la respuesta es acertada 
        {
            MessageBox.Show("Acertaste!");
            radioButton_respuesta.Enabled = false;
            radioButton_chat.Checked = true;
        }

        private void toolStripTextBox_ip_Click(object sender, EventArgs e)  // evento borrar textbox ip 
        {
            toolStripTextBox_ip.Clear();
        }

        private void toolStripTextBox_puerto_Click(object sender, EventArgs e)  // evento borrar textbox puerto 
        {
            toolStripTextBox_puerto.Clear();
        }

        private void conectarseAlServidorToolStripMenuItem_Click(object sender, EventArgs e) //conexion al servidor
        {
            if (ValidaIP(toolStripTextBox_ip.Text)) //validacion ip
            {
                if (ValidaPuerto(toolStripTextBox_puerto.Text)) //validacion puerto
                {
                    try
                    {
                        client = new TcpClient(this.toolStripTextBox_ip.Text, Convert.ToInt32(toolStripTextBox_puerto.Text));
                        ns = client.GetStream();
                        sr = new StreamReader(ns);
                        sw = new StreamWriter(ns);
                        dato = sr.ReadLine();
                        DelegadoRespuesta dr = new DelegadoRespuesta(EscribirEstadoConexion);
                        this.Invoke(dr);
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine("Error: " + error.ToString());
                        MessageBox.Show("Error de conexion" + Environment.NewLine + "Comprueba que la ip el puerto y que el servidor esté encendido", "Error");
                    }
                }
                else
                {
                    MessageBox.Show(
                        "El número de puerto es incorrecto: " + Environment.NewLine +
                        "el número tiene que estar comprendido entre 1024 y 2999"
                        );
                }
            }
            else
            {
                MessageBox.Show("La ip es incorrecta");
            }
        }

        private void EscribirEstadoConexion()//escribe label estado de conexion 
        {
            if (dato.Equals("OK"))
            {
                MessageBox.Show("Conectado!" + Environment.NewLine + "Elige un nick y empieza a jugar", "Conectado!");
                this.label_estado.Text = "Estado: Conectado";
                this.groupBox_nick.Enabled = true;
                this.groupBox_nick.Visible = true;
                conectarToolStripMenuItem.Enabled = false;
                desconectarToolStripMenuItem.Enabled = true;
            }

            else
                this.label_estado.Text = "Estado: Error de conexion";
        }

        private static bool ValidaIP(string iP)//comprobar si la ip introducida es correcta 
        {
            try
            { IPAddress ip = IPAddress.Parse(iP); }
            catch
            { return false; }

            return true;
        }

        private static bool ValidaPuerto(string puerto)//comprobar si el puerto introducido es correcto 
        {
            string p = puerto;
            int numPuerto;

            if (int.TryParse(p, out numPuerto) && numPuerto >= 1024 && numPuerto <= 2999)
                return true;

            return false;
        }

        private void button_INSCRIBIR_click(object sender, EventArgs e) //INSCRIBIRSE 
        {
            sw.WriteLine("#INSCRIBIR#" + this.textBox_nick.Text + "#");
            sw.Flush();
            dato = sr.ReadLine();

            if (dato.Split('#')[1] == "OK")
            {
                groupBox_nick.Enabled = false;

                puertoEscucha = Convert.ToInt32(dato.Split('#')[2]);

                button_listo.Visible = true;
                button_listo.Enabled = true;
                radioButton_chat.Select();
                //abrir thread escucha
                Thread t = new Thread(this.EscuchaServidor);
                t.IsBackground = true;
                t.Start();
            }
            else
            {
                MessageBox.Show(dato.Split('#')[2], "No puedes pasar!");
            }
        }

        private void EscuchaServidor()//mini servidor en escucha (HILO SECUNDARIO) 
        {
            TcpListener newsock = new TcpListener(IPAddress.Any, puertoEscucha);
            newsock.Start();
            while (true)
            {
                //instrucciones del servidor
                TcpClient client = newsock.AcceptTcpClient();
                NetworkStream ns = client.GetStream();
                StreamReader sr = new StreamReader(ns);
                StreamWriter sw = new StreamWriter(ns);

                try
                {
                    dato = sr.ReadLine(); //linea bloqueante
                    Console.WriteLine(dato);
                }
                catch (Exception er)
                {
                    Console.WriteLine("Escucha servidor : " + er);
                }

                #region comCHAT

                if (dato.Split('#')[1] == "MSGCHAT")
                {
                    DelegadoRespuesta dr = new DelegadoRespuesta(escribirListBoxChat);
                    this.Invoke(dr);
                }

                #endregion

                #region com INICIAR NUEVA PARTIDA
                if (dato.Split('#')[1] == "INICIARNUEVAPARTIDA")
                {
                    sw.WriteLine("#OK#");
                    sw.Flush();
                    try
                    {
                        string p = sr.ReadLine();
                        Console.WriteLine(p);

                        if (p.Split('#')[1] == "PISTA")
                        {
                            Image Imagen = Image.FromStream(ns);
                            DelegadoNuevaPartida dn = new DelegadoNuevaPartida(NuevaPartida);
                            this.Invoke(dn, Imagen, p.Split('#')[2]);
                        }
                    }
                    catch (Exception er)
                    {
                        sw.WriteLine("#NOK#" + er);
                        sw.Flush();
                    }

                }
                #endregion

                #region com RESULTADO TOTAL
                if (dato.Split('#')[1] == "RESULTADOTOTAL")
                {
                    MiDelegado md = new MiDelegado(escribirListBoxPuntuacion);
                    this.Invoke(md, dato);
                }
                #endregion

                #region com OTRA PARTIDA
                if (dato.Split('#')[1] == "FINDEPARTIDA")
                {
                    rondaActual = 0;
                    sw.WriteLine("#OK#");
                    sw.Flush();
                    MiDelegado md = new MiDelegado(resetFinDePartida);
                    this.Invoke(md, dato);
                }
                #endregion

                #region com DESCONEXION
                if (dato.Split('#')[1] == "DESCONEXION")
                {
                    rondaActual = 0;
                    sw.WriteLine("#OK#");
                    sw.Flush();
                    DelegadoRespuesta dr = new DelegadoRespuesta(Desconectar);
                    this.Invoke(dr);
                }
                #endregion
            }
        }

        private void resetFinDePartida(string dato) //preparar el jugador para una nueva partida 
        {
            foreach (string s in dato.Split('#'))
            {
                if (s != "FINDEPARTIDA")
                    listBox_chat.Items.Add(s);
            }
            button_listo.Enabled = true;
            button_listo.Visible = true;
            radioButton_respuesta.Enabled = false;
            radioButton_chat.Enabled = true;
            radioButton_chat.Checked = true;
            label_time.Text = "";
            labelPista.Visible = false;
            pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\..\..\Resources\brands.jpg");
            label_time.Visible = false;
            label_CuentaAtrasInicio.Visible = false;
            simpleSound.Stop();
        }

        private void escribirListBoxPuntuacion(string puntuacion) //escribe la clasificacion actual en el listbox de puntuacion
        {
            try
            {
                listBox_resultado.Items.Clear();
            }
            catch (Exception er)
            { Console.WriteLine(er); }
            string[] resultados = puntuacion.Split('#');

            for (int i = 2; i < resultados.Length - 1; i++)
            {
                Console.WriteLine(resultados.ElementAt(i));
                try
                {
                    listBox_resultado.Items.Add(resultados.ElementAt(i).ToString());
                }
                catch (Exception er)
                { Console.WriteLine(er); }
            }
        }

        private void escribirListBoxChat()//escribe mensaje en el listbox chat 
        {
            listBox_chat.Items.Add(dato.Split('#')[2]);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) //envía al servidor peticion de desconexion en el cierre de ventana 
        {
            try
            {
                sw.WriteLine("#DESCONEXION#");
                sw.Flush();
            }
            catch (Exception er)
            {
                Console.WriteLine(er);
            }
        }

        private void desconectarToolStripMenuItem_Click(object sender, EventArgs e)//indica al servidor peticion de desconexion 
        {
            try
            {
                sw.WriteLine("#DESCONEXION#");
                sw.Flush();
            }
            catch (Exception er)
            {
                Console.WriteLine(er);
            }
            Desconectar();
        }

        private void Desconectar()
        {
            MessageBox.Show("Desconectado del servidor");
            pictureBox1.Image = null;
            this.label_estado.Text = "Estado: Desconectado";
            this.groupBox_nick.Visible = false;
            conectarToolStripMenuItem.Enabled = true;
            pictureBox1.Image = Image.FromFile(Environment.CurrentDirectory + @"\..\..\Resources\brands.jpg");
            button_listo.Visible = false;
            button_listo.Enabled = false;
            textBox_nick.Clear();
            timerImagen.Stop();
            timer_cuentaAtras.Stop();
            progressBar1.Value = 0;
        }

        private void button_LISTOPARAJUGAR_Click(object sender, EventArgs e)//indica al servidor <listo para jugar> 
        {
            //listo para jugar
            try
            {
                listBox_resultado.Items.Clear();
                Console.WriteLine("listboxresultado borrado");
                sw.WriteLine("#LISTOPARAJUGAR#");
                sw.Flush();
                dato = sr.ReadLine();
                if (dato.Split('#')[1] == "OK")
                {
                    cuentaAtrasRonda = Convert.ToInt32(dato.Split('#')[2]);
                    tiempoRonda = cuentaAtrasRonda;
                    hideButtonListoParaJugar();
                }
                else
                {
                    MessageBox.Show(dato.Split('#')[2], "Error");
                }
            }
            catch (Exception er)
            {
                Console.WriteLine(er);
            }
        }

        private void hideButtonListoParaJugar()//oculta boton listo para jugar 
        {
            button_listo.Visible = false;
            button_listo.Enabled = false;
        }

        private void textbox_respuesta_KeyDown(object sender, KeyEventArgs e)//evento enter para textbox respuesta 
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_JUGADA_CHAT(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)//boton cerrar ventana 
        {
            this.Close();
        }

        private void timer_cuentaInicio_Tick(object sender, EventArgs e)//timer cuenta atras para inicio de partida 
        {
            label_CuentaAtrasInicio.Visible = true;

            if (cuentaAtrasInicio >= 0)
            {

                if (cuentaAtrasInicio == 0)
                {
                    rondaActual++;
                    label_CuentaAtrasInicio.Text = "RONDA " + rondaActual;
                    radioButton_respuesta.Enabled = true;
                    radioButton_respuesta.Checked = true;
                }
                else
                {
                    label_CuentaAtrasInicio.Text = cuentaAtrasInicio.ToString();
                }
            }
            else
            {
                timer_cuentaAtras.Enabled = true;
                timerImagen.Enabled = true;
                timerImagen.Start();
                timer_cuentaAtras.Start();
                timer_cuentaInicio.Stop();
                timer_cuentaInicio.Enabled = false;
            }

            cuentaAtrasInicio--;

        }

        private void verLasNormasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInstrucciones fi = new FormInstrucciones();
            fi.ShowDialog();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logo Quiz V Final" + Environment.NewLine + "Proyecto PSP 2017" + Environment.NewLine + "Óscar Suárez Payo", "Acerca de");
        }

    }
}
