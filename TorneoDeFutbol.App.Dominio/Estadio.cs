using System;
using System.ComponentModel.DataAnnotations;

namespace TorneoDeFutbol.App.Dominio
{
    /// <summary>Class <c>Estadio</c>
    /// </summary>   
    public class Estadio
    {       
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [Required(ErrorMessage ="El nombre es obligatorio")]
        [StringLength(50,ErrorMessage ="Maximo 50 caracteres")]
        public string Nombre { get; set; }

        [Display(Name = "Dirección")]
        [Required(ErrorMessage ="La dirección es obligatoria")]
        [StringLength(50,ErrorMessage ="Maximo 50 caracteres")]
        public string Direccion {get; set;}
        
        [Display(Name = "Municipio")]
        public Municipio Municipio {get; set;}
    
    }
}