using System;

namespace TorneoDeFutbol.App.Dominio
{
    /// <summary>Class <c>Marcador Final</c>
    /// Modela el municipio de un equipo y estadio
    /// </summary>   
    public class MarcadorFinal
    {
        public int Id { get; set; } 
        public string EquipoGanador { get; set; }
        public int MarcadorGanador { get; set; }
        public string EquipoPerdedor { get; set; }
        public int MarcadorPerdedor { get; set; }
        public Partido Partido {get; set;}
    }
}