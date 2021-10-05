using System;
using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioNovedad
    {
        IEnumerable<Novedad> GetAllNovedad();
        Novedad AddNovedad(Novedad novedad);
        Novedad UpdateNovedad(Novedad novedad);
        void DeleteNovedad(int idNovedad);    
        Novedad GetNovedad(int idNovedad);
    }
}