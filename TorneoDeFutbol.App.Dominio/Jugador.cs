using System;
namespace TorneoDeFutbol.App.Dominio

{
   /// <summary>Class <c>Jugadores</c>
   /// Modela un Jugador que esta jugando en un torneo
   /// </summary> 
   public class Jugador 
   {
        // Identificador único del jugador
        public int Id { get; set; }
        ///Nombre del jugador
        public string Nombre { get; set; }
        /// Numero que identifica al jugador
        public string Numero { get; set; }
        // Posicion en la que juega el jugador
        public String Posicion { get; set; }
        
        public Equipo Equipo {get; set;}
   }
}
