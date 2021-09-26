using System;
using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioDesempeño
    {
        IEnumerable<Desempeño> GetAllDesempeños();
        Desempeño AddDesempeño(Desempeño desempeño);
        Desempeño UpdateDesempeño(Desempeño desempeño);
        void DeleteDesempeño(int idDesempeño);    
        Desempeño GetDesempeño(int idDesempeño);
    }
}