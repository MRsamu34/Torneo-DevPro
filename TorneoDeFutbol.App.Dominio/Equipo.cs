using System;
namespace TorneoDeFutbol.App.Dominio
{
    /// <summary>Class <c>Equipo</c>
    /// Modela un equipo que hace parte del torneo
    /// </summary>   
    public class Equipo
    {
        //Identificador Unico del equipo
        public int Id {get; set;}

        public string Nombre {get; set;}

        public DirectorTecnico DirectorTecnico_id {get; set;}  

        public Municipio Municipio_id {get; set;} 

        public Jugador Jugador_id {get; set;} 
    }
}
