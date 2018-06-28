using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Partida
    {
        private bool partidaIniciada;
        private int maxPuntos;
        private int maxRondas;
        private string respuesta;
        private int rondaActual;
        private List<Bitmap> listaImg = new List<Bitmap>();

        public bool PartidaIniciada
        {
            get
            {
                return partidaIniciada;
            }

            set
            {
                partidaIniciada = value;
            }
        }

        public int MaxPuntos
        {
            get
            {
                return maxPuntos;
            }

            set
            {
                maxPuntos = value;
            }
        }

        public int MaxRondas
        {
            get
            {
                return maxRondas;
            }

            set
            {
                maxRondas = value;
            }
        }

        public string Respuesta
        {
            get
            {
                return respuesta;
            }

            set
            {
                respuesta = value;
            }
        }

        public int RondaActual
        {
            get
            {
                return rondaActual;
            }

            set
            {
                rondaActual = value;
            }
        }

        public List<Bitmap> ListaImg
        {
            get
            {
                return listaImg;
            }

            set
            {
                listaImg = value;
            }
        }

        public List<Bitmap> Barajar(List<Bitmap> lista)
        {
            Random r = new Random();
            Bitmap temp;
            int randomNumber;
            int count = lista.Count;
            for (int index = count - 1; index > 0; index--)
            {
                randomNumber = r.Next(0, index + 1);
                temp = lista[index];
                lista[index] = lista[randomNumber];
                lista[randomNumber] = temp;
            }
            return lista;
        }

        public Bitmap NewImg()
        {
            Bitmap img = ListaImg[RondaActual];
            Respuesta = img.Tag.ToString().ToLower().Trim();
            Console.WriteLine("Respuesta :" + Respuesta);
            return img;
        }
    }
}