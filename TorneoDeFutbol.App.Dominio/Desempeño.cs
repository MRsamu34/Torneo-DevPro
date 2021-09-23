using System;
namespace TorneoDeFutbol.App.Dominio

{

/// <summary>Class <c>Desempeño</c>

/// Modela el  Desempeño del  jugandor en un torneo

/// </summary> 

public class Desempeño 

{// Identificador único del Desempeño 
    public int Id { get; set; }


    public int NumeroPartidos { get; set; }


    public int PartidosGanados { get; set; }
    public int PartidosEmpatados { get; set; }



    public int GolesAfavor { get; set; }
    public int GolesEncontra { get; set; }
    public int Puntos { get; set; }


}
 }
  