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
            var partidoEncontrado = _appContext.Equipo.Find(idPartido);
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
               
                partidoEncontrado.Partido_id = partido.Partido_id;
                equipoEncontrado.Municipio_id = equipo.Municipio_id;
                jugadoresEncontrado.Equipo = jugadores.Equipo;
                
                
                _appContext.SaveChanges();
            }
            return partidoEncontrado;
        }
    }
}