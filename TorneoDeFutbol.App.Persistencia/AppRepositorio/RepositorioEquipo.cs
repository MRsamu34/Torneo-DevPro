using System;
using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace TorneoDeFutbol.App.Persistencia
{
    public class RepositorioEquipo : IRepositorioEquipo
    {
        private readonly AppContext _appContext = new AppContext();

        public Equipo AddEquipo(Equipo equipo)
        {
            var municipioEncontrado = _appContext.Municipio.Find(equipo.MunicipioId);
            var directorTecnicoEcontrado = _appContext.DirectorTecnico.Find(equipo.DirectorTecnicoId);
            var jugadorEncontrado = _appContext.Jugador.Find(equipo.Jugador.FirstOrDefault().Id);
            equipo.DirectorTecnico = directorTecnicoEcontrado;
            equipo.Municipio = municipioEncontrado;
            List<Jugador> jugadores = new List<Jugador>();
            jugadores.Add(jugadorEncontrado);
            equipo.Jugador = jugadores;
            var equipoAdicionado = _appContext.Equipo.Add(equipo);
            _appContext.SaveChanges();
            return equipoAdicionado.Entity;
        }

        public void DeleteEquipo(int idEquipo)
        {
            var equipoEncontrado = _appContext.Equipo.Find(idEquipo);
            if (equipoEncontrado == null)
                return;
            _appContext.Equipo.Remove(equipoEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Equipo> GetAllEquipo()
        {
            var equipos = _appContext.Equipo
                            .Include(e => e.Jugador)
                            .Include(e => e.Municipio)
                            .Include(e => e.DirectorTecnico);
            
            return equipos;
        }

        public Equipo GetEquipo(int idEquipo)
        {
            return _appContext.Equipo
                        .Where(e => e.Id == idEquipo)
                        //.Include(e => e.Jugador)
                        .Include(e => e.Municipio)
                        .Include(e => e.DirectorTecnico)
                        .FirstOrDefault();
        }

        public Equipo UpdateEquipo(Equipo equipo)
        {
            var equipoEncontrado = _appContext.Equipo.Find(equipo.Id);
            if (equipoEncontrado != null)
            {
                equipoEncontrado.Nombre = equipo.Nombre;
                equipoEncontrado.DirectorTecnico = equipo.DirectorTecnico;
                equipoEncontrado.Municipio = equipo.Municipio;
                equipoEncontrado.Jugador = equipo.Jugador;
                
                _appContext.SaveChanges();
            }
            return equipoEncontrado;
        }
    }
}