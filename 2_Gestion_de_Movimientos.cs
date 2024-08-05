using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_de_Movimientos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MovimientosJugador jugador = new MovimientosJugador("Juan");

            jugador.MostrarPosicion();

            jugador.MoverArriba();
            jugador.MostrarPosicion();

            jugador.MoverDerecha();
            jugador.MostrarPosicion();

            jugador.MoverAbajo();
            jugador.MostrarPosicion();

            jugador.MoverIzquierda();
            jugador.MostrarPosicion();
        }
    }

    public class MovimientosJugador
    {
        private string nombre;
        private int posicionX;
        private int posicionY;
        private int velocidad;

        public string Nombre { get => nombre; set => nombre = value; }
        public int PosicionX { get => posicionX; set => posicionX = value; }
        public int PosicionY { get => posicionY; set => posicionY = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }

        public MovimientosJugador(string nombre, int posicionX = 0, int posicionY = 0, int velocidad = 1)
        {
            this.nombre = nombre;
            this.posicionX = posicionX;
            this.posicionY = posicionY;
            this.velocidad = velocidad;
        }

        public void MoverArriba()
        {
            posicionY += velocidad;
        }

        public void MoverAbajo()
        {
            posicionY -= velocidad;
        }

        public void MoverIzquierda()
        {
            posicionX -= velocidad;
        }

        public void MoverDerecha()
        {
            posicionX += velocidad;
        }

        public void MostrarPosicion()
        {
            Console.WriteLine($"Posición del jugador {nombre}: ({posicionX}, {posicionY})");
        }
    }
}
