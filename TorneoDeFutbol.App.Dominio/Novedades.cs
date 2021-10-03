using System;

namespace TorneoDeFutbol.App.Dominio
{
    /// <summary>Class <c>Novedades</c>
    /// </summary>   
    public class Novedades
    {
        public int Id { get; set; } 
        public int YellowCards { get; set; }
        public int RedCards { get; set; }
        public int  goles { get; set; }
        public string NombreNovedad {get; set;}
        public DateTime Minuto  { get; set; }
        public Jugador Jugador{get; set;}

    }
}