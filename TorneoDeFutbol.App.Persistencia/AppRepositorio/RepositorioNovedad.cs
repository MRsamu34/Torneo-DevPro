using System;
using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;
using System.Linq;

namespace TorneoDeFutbol.App.Persistencia
{
    public class RepositorioNovedad : IRepositorioNovedad
    {
        private readonly AppContext _appContext = new AppContext();

        public Novedad AddNovedad(Novedad novedad)
        {
            var NovedadAdicionado = _appContext.Novedad.Add(novedad);
            _appContext.SaveChanges();
            return NovedadAdicionado.Entity;
        }

        public void DeleteNovedad(int idNovedad)
        {
            var novedadEncontrado = _appContext.Novedad.Find(idNovedad);
            if (novedadEncontrado == null)
                return;
            _appContext.Novedad.Remove(novedadEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Novedad> GetAllNovedad()
        {
            return _appContext.Novedad;
        }

        public Novedad GetNovedad(int idNovedad)
        {
            return _appContext.Novedad.Find(idNovedad);
        }

        public Novedad UpdateNovedad(Novedad novedad)
        {
            var novedadEncontrado = _appContext.Novedad.Find(novedad.Id);
            if (novedadEncontrado != null)
            {
                novedadEncontrado.RedCards = novedad.RedCards;
                novedadEncontrado.YellowCards = novedad.YellowCards;
                novedadEncontrado.goles = novedad.goles;
                novedadEncontrado.NombreNovedad = novedad.NombreNovedad;
                novedadEncontrado.Minuto = novedad.Minuto;
                novedadEncontrado.Jugador = novedad.Jugador;
                _appContext.SaveChanges();
            }
            return novedadEncontrado;
        }
    }
}