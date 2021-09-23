using System;

namespace TorneoDeFutbol.App.Dominio
{
    /// <summary>Class <c>Arbitro</c>
    /// Modela un equipo que hace parte del torneo
    /// </summary>   
    public class Arbitro
    {
        //Identificador Unico del equipo
        public int id {get; set;}

        public string nombre {get; set;}

        public int Documento {get; set;} 

        public int Telefono {get; set;} 

        public string Colegio {get; set;} 

        public Partido Partido {get; set;} 
    }
}
