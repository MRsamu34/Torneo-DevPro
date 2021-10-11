using System;
using System.ComponentModel.DataAnnotations;
namespace TorneoDeFutbol.App.Dominio

{
    /// <summary>Class <c>Desempeño</c>
    /// Modela el  Desempeño del  jugandor en un torneo
    /// </summary> 
    public class Desempeño 
    {
        // Identificador único del Desempeño 
        public int Id { get; set; }
        [Display(Name = "Numero de partidos")]
        [Required(ErrorMessage ="El numero de partidos es obligatorio")]
        public int NumeroPartidos { get; set; }
        [Display(Name = "Partidos Ganados")]
        public int PartidosGanados { get; set; }
        [Display(Name = "Partidos Empatados")]
        public int PartidosEmpatados { get; set; }
        [Display(Name = "Goles A favor")]
        public int GolesAfavor { get; set; }
        [Display(Name = "Goles En contra")]
        public int GolesEncontra { get; set; }
        [Display(Name = "Puntos")]
        public int Puntos { get; set; }
    }
}
  