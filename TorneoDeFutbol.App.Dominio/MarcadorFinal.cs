using System;

namespace TorneoDeFutbol.App.Dominio
{
    /// <summary>Class <c>Marcador Final</c>
    /// Modela el municipio de un equipo y estadio
    /// </summary>   
    public class MarcadorFinal
    {
        // identificador unico de la tabla
        public int Id { get; set; } 
        public String EquipoGanador { get; set; }
        public int MarcadorGanador { get; set; }
        public String EquipoPerdedor { get; set; }
        public int MarcadorPerdedor { get; set; }
        public Partido Partido {get; set;}
    }
}