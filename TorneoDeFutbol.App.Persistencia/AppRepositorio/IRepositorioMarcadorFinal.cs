using System;
using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioMarcadorFinal
    {
        IEnumerable<MarcadorFinal> GetAllMarcadorFinal();
        MarcadorFinal AddMarcadorFinal(MarcadorFinal marcadorFinal);
        MarcadorFinal UpdateMarcadorFinal(MarcadorFinal marcadorFinal);
        void DeleteMarcadorFinal(int idMarcadorFinal);    
        MarcadorFinal GetMarcadorFinal(int idMarcadorFinal);
        // IEnumerable<MarcadorFinal> SearchMarcadorFinal(String nombre);

    }
}