using System;
using System.ComponentModel.DataAnnotations;

namespace TorneoDeFutbol.App.Dominio
{
    /// <summary>Class <c>Arbitro</c>
    /// Modela un equipo que hace parte del torneo
    /// </summary>   
    public class Arbitro
    {
        //Identificador Unico del equipo
        public int Id {get; set;}
        [Required(ErrorMessage = "Escriba el nombre del Arbitro")]
        [StringLength(50, ErrorMessage = "Maximo 50 caracteres")]
        public string Nombre {get; set;}

        [Required(ErrorMessage = "El documento es obligatorio")]
        public int Documento {get; set;} 
    
        public int Telefono {get; set;} 

        [Required(ErrorMessage = "Campo obligatorio")]
        public string Colegio {get; set;} 

        //public Partido Partido {get; set;} 
    }
}
