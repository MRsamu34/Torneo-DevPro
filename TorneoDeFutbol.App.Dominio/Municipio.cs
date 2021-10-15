using System;
using System.ComponentModel.DataAnnotations;

namespace TorneoDeFutbol.App.Dominio
{
    /// <summary>Class <c>Municipio</c>
    /// Modela el municipio de un equipo y estadio
    /// </summary>   
    public class Municipio
    {
        /// id municipio   
        public int Id { get; set; }
      //   [Required(ErrorMessage = "Campo obligatorio")]
       // [StringLength(50, ErrorMessage = "Longitad maxima 50")]

        public string Nombre { get; set; }
    }
}