using System;
using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
            var estadio = _appContext.Estadio
                .Where(e => e.Id == idEstadio)
                .Include(e => e.Municipio)
                .FirstOrDefault();
            return estadio;
        }

        public Estadio UpdateEstadio(Estadio estadio)
        {
            var estadioEncontrado = _appContext.Estadio.Find(estadio.Id);
            if (estadioEncontrado != null)
            {
                estadioEncontrado.Nombre = estadio.Nombre;
                estadioEncontrado.Direccion = estadio.Direccion;
                estadioEncontrado.Municipio = estadio.Municipio;               
                _appContext.SaveChanges();
            }
            return estadioEncontrado;
        }

        Municipio IRepositorioEstadio.AgregarMunicipio(int idEstadio, int idMunicipio)
        {
            var estadioEncontrado = _appContext.Estadio.FirstOrDefault(e => e.Id == idEstadio);
            if (estadioEncontrado != null)
            {
                var municipioEncontrado = _appContext.Municipio.FirstOrDefault(m => m.Id == idMunicipio);
                if (municipioEncontrado != null)
                {
                    estadioEncontrado.Municipio = municipioEncontrado;
                    _appContext.SaveChanges();
                }    
                return municipioEncontrado;
            }
            return null;
        }
    }
}