using System;
using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia
{
    public interface IRepositorioDirectorTecnico
    {
        IEnumerable<DirectorTecnico> GetAllDirectorTecnico();
        DirectorTecnico AddDirectorTecnico(DirectorTecnico directorTecnico);
        DirectorTecnico UpdateDirectorTecnico(DirectorTecnico directorTecnico);
        void DeleteDirectorTecnico(int idDirectorTecnico);    
        DirectorTecnico GetDirectorTecnico(int idDirectorTecnico);
        IEnumerable<DirectorTecnico> SearchDirectoresTecnicos(String nombre);
    }
}