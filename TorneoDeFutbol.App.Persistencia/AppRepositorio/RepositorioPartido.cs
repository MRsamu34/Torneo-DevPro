using System;
using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia
{
    public class RepositorioPartido : IRepositorioPartido
    {
        private readonly AppContext _appContext = new AppContext();

        public Partido AddPartido(Partido partido)
        {
            var partidoAdicionado = _appContext.Partido.Add(partido);
            _appContext.SaveChanges();
            return partidoAdicionado.Entity;
        }

        public void DeletePartido(int idPartido)
        {
            var partidoEncontrado = _appContext.Partido.Find(idPartido);
            if (partidoEncontrado == null)
                return;
            _appContext.Partido.Remove(partidoEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Partido> GetAllPartido()
        {
            return _appContext.Partido;
        }

        public Partido GetPartido(int idPartido)
        {
            return _appContext.Partido.Find(idPartido);
        }

        public Partido UpdatePartido(Partido partido)
        {
            var partidoEncontrado = _appContext.Partido.Find(partido.Id);
            if (partidoEncontrado != null)
            {
               
                partidoEncontrado.FechaHora = partido.FechaHora;
                partidoEncontrado.Equipo_Local = partido.Equipo_Local;
                partidoEncontrado.Marcador_Inicial_Equipo_Local = partido.Marcador_Inicial_Equipo_Local;
                partidoEncontrado.Equipo_Visitante = partido.Equipo_Visitante;
                partidoEncontrado.Marcador_Inicial_Equipo_Visitante = partido.Marcador_Inicial_Equipo_Visitante;                
                _appContext.SaveChanges();
            }
            return partidoEncontrado;
        }
    }
}