using System;
using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia
{
    public class RepositorioEstadio : IRepositorioEstadio
    {
        private readonly AppContext _appContext = new AppContext();

        public Estadio AddEstadio(Estadio estadio)
        {
            var estadioAdicionado = _appContext.Estadio.Add(estadio);
            _appContext.SaveChanges();
            return estadioAdicionado.Entity;
        }

        public void DeleteEstadio(int idEstadio)
        {
            var estadioEncontrado = _appContext.Estadio.Find(idEstadio);
            if (estadioEncontrado == null)
                return;
            _appContext.Estadio.Remove(estadioEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Estadio> GetAllEstadio()
        {
            return _appContext.Estadio;
        }

        public Estadio GetEstadio(int idEstadio)
        {
            return _appContext.Estadio.Find(idEstadio);
        }

        public Estadio UpdateEstadio(Estadio estadio)
        {
            var estadioEncontrado = _appContext.Estadio.Find(estadio.Id);
            if (estadioEncontrado != null)
            {
                estadioEncontrado.NumeroPartidos = estadio.NumeroPartidos;
                estadioEncontrado.PartidosGanados = estadio.PartidosGanados;
                estadioEncontrado.PartidosEmpatados = estadio.PartidosEmpatados;
                estadioEncontrado.GolesAfavor = estadio.GolesAfavor;
                estadioEncontrado.GolesEncontra = estadio.GolesEncontra;
                estadioEncontrado.Puntos = estadio.Puntos;
                
                _appContext.SaveChanges();
            }
            return estadioEncontrado;
        }
    }
}