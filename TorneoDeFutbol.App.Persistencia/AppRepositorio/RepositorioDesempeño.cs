using System;
using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia
{
    public class RepositorioDesempeño : IRepositorioDesempeño
    {
        private readonly AppContext _appContext = new AppContext();

        public Desempeño AddDesempeño(Desempeño desempeño)
        {
            var desempeñoAdicionado = _appContext.Desempeño.Add(desempeño);
            _appContext.SaveChanges();
            return desempeñoAdicionado.Entity;
        }

        public void DeleteDesempeño(int idDesempeño)
        {
            var desempeñoEncontrado = _appContext.Desempeño.Find(idDesempeño);
            if (desempeñoEncontrado == null)
                return;
            _appContext.Desempeño.Remove(desempeñoEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Desempeño> GetAllDesempeño()
        {
            return _appContext.Desempeño;
        }

        public Desempeño GetDesempeño(int idDesempeño)
        {
            return _appContext.Desempeño.Find(idDesempeño);
        }

        public Desempeño UpdateDesempeño(Desempeño desempeño)
        {
            var desempeñoEncontrado = _appContext.Desempeño.Find(desempeño.Id);
            if (desempeñoEncontrado != null)
            {
                desempeñoEncontrado.NumeroPartidos = desempeño.NumeroPartidos;
                desempeñoEncontrado.PartidosGanados = desempeño.PartidosGanados;
                desempeñoEncontrado.PartidosEmpatados = desempeño.PartidosEmpatados;
                desempeñoEncontrado.GolesAfavor = desempeño.GolesAfavor;
                desempeñoEncontrado.GolesEncontra = desempeño.GolesEncontra;
                desempeñoEncontrado.Puntos = desempeño.Puntos;
                
                _appContext.SaveChanges();
            }
            return desempeñoEncontrado;
        }
    }
}