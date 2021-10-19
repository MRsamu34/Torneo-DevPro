using System;
using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia
{
    public class RepositorioMarcadorFinal : IRepositorioMarcadorFinal
    {
        private readonly AppContext _appContext = new AppContext();
        

        public MarcadorFinal AddMarcadorFinal(MarcadorFinal marcadorFinal)
        {
            var MarcadorFinalAdicionado = _appContext.MarcadorFinal.Add(marcadorFinal);
            _appContext.SaveChanges();
            return MarcadorFinalAdicionado.Entity;
        }

        public void DeleteMarcadorFinal(int idMarcadorFinal)
        {
            var marcadorFinalEncontrado = _appContext.MarcadorFinal.Find(idMarcadorFinal);
            if (marcadorFinalEncontrado == null)
                return;
            _appContext.MarcadorFinal.Remove(marcadorFinalEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<MarcadorFinal> GetAllMarcadorFinal()
        {
            return _appContext.MarcadorFinal;
        }

        public MarcadorFinal GetMarcadorFinal(int idMarcadorFinal)
        {
            return _appContext.MarcadorFinal.Find(idMarcadorFinal);
        }

        public MarcadorFinal UpdateMarcadorFinal(MarcadorFinal marcadorFinal)
        {
            var marcadorFinalEncontrado = _appContext.MarcadorFinal.Find(marcadorFinal.Id);
            if (marcadorFinalEncontrado != null)
            {
                marcadorFinalEncontrado.EquipoGanador = marcadorFinal.EquipoGanador;
                marcadorFinalEncontrado.MarcadorGanador = marcadorFinal.MarcadorGanador;
                marcadorFinalEncontrado.EquipoPerdedor = marcadorFinal.EquipoPerdedor;
                marcadorFinalEncontrado.MarcadorPerdedor = marcadorFinal.MarcadorPerdedor;
                marcadorFinalEncontrado.Partido = marcadorFinal.Partido;
                
                _appContext.SaveChanges();
            }
            return marcadorFinalEncontrado;
        }
        // IEnumerable<MarcadorFinal> IRepositorioMarcadorFinal.SearchMarcadorFinal(string equipoGanador)
        // {
        //     return  _appContext.MarcadorFinal.Where(d => d.EquipoGanador.Contains(equipoGanador));
        // }

    }
}