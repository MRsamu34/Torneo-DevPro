using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia
{
    public class RepositorioMunicipio : IRepositorioMunicipio
    {
        private readonly AppContext _appContext = new AppContext();

        public Municipio AddMunicipio(Municipio municipio)
        {
            var municipioAdicionado = _appContext.Municipio.Add(municipio);
            _appContext.SaveChanges();
            return municipioAdicionado.Entity;
        }

        public void DeleteMunicipio(int idMunicipio)
        {
            var municipioEncontrado = _appContext.Municipio.Find(idMunicipio);
            if (municipioEncontrado == null)
                return;
            _appContext.Municipio.Remove(municipioEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Municipio> GetAllMunicipio()
        {
            return _appContext.Municipio;
        }

        public Municipio GetMunicipio(int idMunicipio)
        {
            return _appContext.Municipio.Find(idMunicipio);
        }

        public Municipio UpdateMunicipio(Municipio municipio)
        {
            var municipioEncontrado = _appContext.Municipio.Find(municipio.Id);
            if (municipioEncontrado != null)
            {
                municipioEncontrado.Nombre = municipio.Nombre;
                
                _appContext.SaveChanges();
            }
            return municipioEncontrado;
        }
    }
}