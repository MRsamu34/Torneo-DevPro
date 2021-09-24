using System;
using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioArbitro
    {
        IEnumerable<Arbitro> GetAllArbitro();
        Arbitro AddArbitro(Arbitro arbitro);
        Arbitro UpdateArbitro(Arbitro arbitro);
        void DeleteArbitro(int idArbitro);    
        Arbitro GetArbitro(int idArbitro);
    }
}