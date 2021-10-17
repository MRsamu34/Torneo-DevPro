using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace TorneoDeFutbol.App.Persistencia
{
    public class RepositorioDirectorTecnico : IRepositorioDirectorTecnico
    {
        private readonly AppContext _appContext = new AppContext();

        public DirectorTecnico AddDirectorTecnico(DirectorTecnico directorTecnico)
        {
            var directorTecnicoAdicionado = _appContext.DirectorTecnico.Add(directorTecnico);
            _appContext.SaveChanges();
            return directorTecnicoAdicionado.Entity;
        }

        public void DeleteDirectorTecnico(int idDirectorTecnico)
        {
            var directorTecnicoEncontrado = _appContext.DirectorTecnico.Find(idDirectorTecnico);
            if (directorTecnicoEncontrado == null)
                return;
            _appContext.DirectorTecnico.Remove(directorTecnicoEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<DirectorTecnico> GetAllDirectorTecnico()
        {
            return _appContext.DirectorTecnico;
        }

        public DirectorTecnico GetDirectorTecnico(int idDirectorTecnico)
        {
            return _appContext.DirectorTecnico.Find(idDirectorTecnico);
        }

        public DirectorTecnico UpdateDirectorTecnico(DirectorTecnico directorTecnico)
        {
            var directorTecnicoEncontrado = _appContext.DirectorTecnico.Find(directorTecnico.Id);
            if (directorTecnicoEncontrado != null)
            {
                directorTecnicoEncontrado.Nombre = directorTecnico.Nombre;
                directorTecnicoEncontrado.Documento = directorTecnico.Documento;
                directorTecnicoEncontrado.NumeroTelefono = directorTecnico.NumeroTelefono;
                
                _appContext.SaveChanges();
            }
            return directorTecnicoEncontrado;
        }
        /*IEnumerable<DirectorTecnico> IRepositorioDirectorTecnico.GetDirectoresTecnicosNombre(string nombre){
            return _appContext.DirectorTecnico
                        .Where(d => d.Nombre.Contains(nombre));
        }*/
    }
}