using System;
namespace TorneoDeFutbol.App.Dominio

{
/// <summary>Class <c>Partido</c>

/// Modela el partido que juegan los equipos
/// </summary> 

public class Partido 

{
/// Identificador único del partido
        public int Id { get; set; }

/// Fecha y hora en que se juega el partido
        public DateTime FechaHora  { get; set; }

/// Nombre del equipo local
	public string Equipo_Local { get; set; }

/// Marcador inicial del equipo local
	public int Marcador_Inicial_Equipo_Local { get; set; }

/// Nombre del equipo visitante
	public string Equipo_Visitante { get; set; }

/// Marcador inicial del equipo visitante
	public int Marcador_Inicial_Equipo_Visitante { get; set; }


	}
}