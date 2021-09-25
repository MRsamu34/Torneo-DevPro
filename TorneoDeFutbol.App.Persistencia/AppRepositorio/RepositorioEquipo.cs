using System;
using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia
{
    public class RepositorioEquipo : IRepositorioEquipo
    {
        private readonly AppContext _appContext = new AppContext();

        public Equipo AddEquipo(Equipo equipo)
        {
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
            return _appContext.Equipo;
        }

        public Equipo GetEquipo(int idEquipo)
        {
            return _appContext.Equipo.Find(idEquipo);
        }

        public Equipo UpdateEquipo(Equipo equipo)
        {
            var equipoEncontrado = _appContext.Equipo.Find(equipo.Id);
            if (equipoEncontrado != null)
            {
                equipoEncontrado.Nombre = equipo.Nombre;
                equipoEncontrado.DirectorTecnico_id = equipo.DirectorTecnico_id;
                equipoEncontrado.Municipio_id = equipo.Municipio_id;
                equipoEncontrado.Jugadores = equipo.Jugadores;
                
                _appContext.SaveChanges();
            }
            return equipoEncontrado;
        }
    }
}