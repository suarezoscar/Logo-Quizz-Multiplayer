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
    class Jugador
    {
        private TcpClient cliente;
        private string nick;
        private string ip;
        private int puertoEscucha;
        private int puntuacion;
        private bool listoparajugar;
        private bool partidaFinalizada;
        private bool respuestaAdivinada;




        public Jugador() { }

        public Jugador(TcpClient cliente, string nick, string ip, int puertoEscucha)
        {
            this.cliente = cliente;
            this.nick = nick;
            this.ip = ip;
            this.puertoEscucha = puertoEscucha;
            this.puntuacion = 0;
            this.listoparajugar = false;
            this.partidaFinalizada = false;
            this.respuestaAdivinada = false;
        }

        public TcpClient Cliente
        {
            get
            {
                return cliente;
            }

            set
            {
                cliente = value;
            }
        }

        public string Nick
        {
            get
            {
                return nick;
            }

            set
            {
                nick = value;
            }
        }

        public string Ip
        {
            get
            {
                return ip;
            }

            set
            {
                ip = value;
            }
        }

        public int PuertoEscucha
        {
            get
            {
                return puertoEscucha;
            }

            set
            {
                puertoEscucha = value;
            }
        }

        public bool Listoparajugar
        {
            get
            {
                return listoparajugar;
            }

            set
            {
                listoparajugar = value;
            }
        }

        public bool PartidaFinalizada
        {
            get
            {
                return partidaFinalizada;
            }

            set
            {
                partidaFinalizada = value;
            }
        }

        public bool RespuestaAdivinada
        {
            get
            {
                return respuestaAdivinada;
            }

            set
            {
                respuestaAdivinada = value;
            }
        }

        public int Puntuacion
        {
            get
            {
                return puntuacion;
            }

            set
            {
                puntuacion = value;
            }
        }
    }
}
