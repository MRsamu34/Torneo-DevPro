using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
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
            var jugadorEncontrado = _appContext.Jugador.Find(idJugador);
            if (jugadorEncontrado == null)
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
             var jugador = _appContext.Jugador
                .Where(p => p.Id == idJugador)
                .Include(p => p.Equipo)
                .FirstOrDefault();
            return jugador;
        }

        public Jugador UpdateJugador(Jugador jugador)
        {
            var jugadorEncontrado = _appContext.Jugador.Find(jugador.Id);
            if (jugadorEncontrado != null)
            {
                jugadorEncontrado.Nombre = jugador.Nombre;
                jugadorEncontrado.Numero = jugador.Numero;
                jugadorEncontrado.Posicion = jugador.Posicion;               
                
                _appContext.SaveChanges();
            }
            return jugadorEncontrado;
        }

        Equipo IRepositorioJugador.AsignarEquipo(int idJugador, int idEquipo)
        {
            var jugadorEncontrado = _appContext.Jugador.FirstOrDefault(p => p.Id == idJugador);
            if (jugadorEncontrado != null)
            {
                var equipoEncontrado = _appContext.Equipo.FirstOrDefault(m => m.Id == idEquipo);
                if (equipoEncontrado != null)
                {
                    jugadorEncontrado.Equipo = equipoEncontrado;
                    _appContext.SaveChanges();
                }
                return equipoEncontrado;
            }
            return null;
        }
    }
}