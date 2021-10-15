using System;
using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioMunicipio
    {
        IEnumerable<Municipio> GetAllMunicipio();
        IEnumerable<Municipio> SearchMunicipio(string nombre);
        Municipio AddMunicipio(Municipio municipio);
        Municipio UpdateMunicipio(Municipio municipio);
        void DeleteMunicipio(int idMunicipio);    
        Municipio GetMunicipio(int idMunicipio);
    }
}