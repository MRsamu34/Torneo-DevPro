using System;
using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioPartido
    {
      IEnumerable<Partido> GetAllPartido();
       Partido AddPartido(Partido partido);
       Partido UpdatePartido(Partido partido);
        void DeletePartido(int idPartido);    
        Partido GetPartido(int idPartido);
    }
}