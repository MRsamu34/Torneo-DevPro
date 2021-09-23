//using System;
namespace TorneoDeFutbol.App.Dominio
{
     /// <summary>Class <c>DirectorTecnico</c>
     /// Modela una DirectorTecnico de un equipo
     /// </summary>   
    public class DirectorTecnico
    {
        // Identificador único de cada Director Tecnico
        public int Id {get; set;}
        public string Nombre {get; set;}
        public string Documento {get; set;}
        public string NumeroTelefono {get; set;}
        /// Relacion entre Director Tecnico y el equipo
       // public Equipo Equipo {get; set;}
    }
}