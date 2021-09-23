using System;

namespace TorneoDeFutbol.App.Dominio
{
    /// <summary>Class <c>Estadio</c>
    /// </summary>   
    public class Estadio
    {
         
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion {get; set;}
        public Municipio Municipio {get; set;}
        public Partido Partido {get; set;}

    }
}