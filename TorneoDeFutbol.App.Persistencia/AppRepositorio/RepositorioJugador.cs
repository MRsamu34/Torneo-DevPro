using System;
using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia
{
    public class RepositorioJugador : IRepositorioJugador
    {
        private readonly AppContext _appContext = new AppContext();

        public Jugador AddJugador(Jugador jugador)
        {
            var jugadorAdicionado = _appContext.Jugador.Add(jugador);
            _appContext.SaveChanges();
            return jugadorAdicionado.Entity;
        }

        public void DeleteJugador(int idJugador)
        {
            var jugadorEncontrado = _appContext.Equipo.Find(idJugador);
            if (jugadoroEncontrado == null)
                return;
            _appContext.Jugador.Remove(jugadorEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Jugador> GetAllJugador()
        {
            return _appContext.Jugador;
        }

        public Jugador GetJugador(int idJugador)
        {
            return _appContext.Jugador.Find(idJugador);
        }

        public Jugador UpdateJugador(Jugador jugador)
        {
            var jugadorEncontrado = _appContext.Jugador.Find(jugador.Id);
            if (jugadorEncontrado != null)
            {
                jugadorEncontrado.Nombre = jugador.Nombre;
                jugadorEncontrado.Partido_id = jugador.Partido_id;
                jugadoresEncontrado.Equipo = jugadores.Equipo;
                equipoEncontrado.Municipio_id = equipo.Municipio_id;
                
                
                _appContext.SaveChanges();
            }
            return jugadoroEncontrado;
        }
    }
}