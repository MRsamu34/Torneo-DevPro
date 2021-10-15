using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace TorneoDeFutbol.App.Dominio
{
    /// <summary>Class <c>Equipo</c>
    /// Modela un equipo que hace parte del torneo
    /// </summary>   
    public class Equipo
    {
        //Identificador Unico del equipo
        public int Id {get; set;}
        [Display(Name = "Nombre")]
        [Required(ErrorMessage ="El nombre es obligatorio")]
        [StringLength(50,ErrorMessage ="Maximo 50 caracteres")]

        public string Nombre {get; set;}
        [Display(Name = "Director tecnico")]
        public int DirectorTecnicoId {get; set;}
        public DirectorTecnico DirectorTecnico {get; set;}  
        [Display(Name = "Municipio")]
        public int MunicipioId {get; set;}
        public Municipio Municipio {get; set;} 

        public List<Jugador> Jugador {get; set;}
    }
}
