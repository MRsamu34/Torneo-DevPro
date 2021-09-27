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

        public IEnumerable<Estadio> GetAllEstadios()
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
                estadioEncontrado.Nombre = estadio.Nombre;
                estadioEncontrado.Direccion = estadio.Direccion;
                estadioEncontrado.Municipio = estadio.Municipio;
                estadioEncontrado.Partido = estadio.Partido;
               
                _appContext.SaveChanges();
            }
            return estadioEncontrado;
        }
    }
}