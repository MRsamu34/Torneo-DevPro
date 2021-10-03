using System;
using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;
using System.Linq;

namespace TorneoDeFutbol.App.Persistencia
{
    public class RepositorioNovedades : IRepositorioNovedades
    {
        private readonly AppContext _appContext = new AppContext();

        public Novedades AddNovedades(Novedades novedades)
        {
            var NovedadesAdicionado = _appContext.Novedades.Add(novedades);
            _appContext.SaveChanges();
            return NovedadesAdicionado.Entity;
        }

        public void DeleteNovedades(int idNovedades)
        {
            var novedadesEncontrado = _appContext.Novedades.Find(idNovedades);
            if (novedadesEncontrado == null)
                return;
            _appContext.Novedades.Remove(novedadesEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Novedades> GetAllNovedades()
        {
            return _appContext.Novedades;
        }

        public Novedades GetNovedades(int idNovedades)
        {
            return _appContext.Novedades.Find(idNovedades);
        }

        public Novedades UpdateNovedades(Novedades novedades)
        {
            var novedadesEncontrado = _appContext.Novedades.Find(novedades.Id);
            if (novedadesEncontrado != null)
            {
                novedadesEncontrado.RedCards = novedades.RedCards;
                novedadesEncontrado.YellowCards = novedades.YellowCards;
                novedadesEncontrado.goles = novedades.goles;
                novedadesEncontrado.NombreNovedad = novedades.NombreNovedad;
                novedadesEncontrado.Minuto = novedades.Minuto;
                novedadesEncontrado.Jugador = novedades.Jugador;
                _appContext.SaveChanges();
            }
            return novedadesEncontrado;
        }
    }
}