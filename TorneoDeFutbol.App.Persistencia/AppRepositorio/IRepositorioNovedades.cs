using System;
using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioNovedades
    {
        IEnumerable<Novedades> GetAllNovedades();
        Novedades AddNovedades(Novedades novedades);
        Novedades UpdateNovedades(Novedades novedades);
        void DeleteNovedades(int idNovedades);    
        Novedades GetNovedades(int idNovedades);
    }
}