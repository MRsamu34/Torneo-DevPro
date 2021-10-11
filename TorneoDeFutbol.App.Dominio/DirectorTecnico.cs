//using System;
using System.ComponentModel.DataAnnotations;
namespace TorneoDeFutbol.App.Dominio
{
     /// <summary>Class <c>DirectorTecnico</c>
     /// Modela una DirectorTecnico de un equipo
     /// </summary>   
    public class DirectorTecnico
    {
        // Identificador único de cada Director Tecnico
        public int Id {get; set;}
        [Display(Name = "Nombre")]
        [Required(ErrorMessage ="El nombre es obligatorio")]
        [StringLength(50,ErrorMessage ="Maximo 50 caracteres")]
        public string Nombre {get; set;}
        [Required(ErrorMessage ="El documento es obligatorio")]
        [StringLength(10,ErrorMessage ="Maximo 10 caracteres")]
        public string Documento {get; set;}
        [Display(Name = "Numero telefonico")]
        public string NumeroTelefono {get; set;}
        /// Relacion entre Director Tecnico y el equipo
        //public Equipo Equipo {get; set;}
    }
}