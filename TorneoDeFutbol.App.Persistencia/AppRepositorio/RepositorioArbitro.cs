using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia
{
    public class RepositorioArbitro : IRepositorioArbitro
    {
        private readonly AppContext _appContext = new AppContext();

        public Arbitro AddArbitro(Arbitro arbitro)
        {
            var arbitroAdicionado = _appContext.Arbitro.Add(arbitro);
            _appContext.SaveChanges();
            return arbitroAdicionado.Entity;
        }

        public void DeleteArbitro(int idArbitro)
        {
            var arbitroEncontrado = _appContext.Arbitro.Find(idArbitro);
            if (arbitroEncontrado == null)
                return;
            _appContext.Arbitro.Remove(arbitroEncontrado);
            _appContext.SaveChanges();
        }

        public IEnumerable<Arbitro> GetAllArbitro()
        {
            return _appContext.Arbitro;
        }

        public Arbitro GetArbitro(int idArbitro)
        {
            return _appContext.Arbitro.Find(idArbitro);
        }

        public Arbitro UpdateArbitro(Arbitro arbitro)
        {
            var arbitroEncontrado = _appContext.Arbitro.Find(arbitro.Id);
            if (arbitroEncontrado != null)
            {
                arbitroEncontrado.Nombre = arbitro.Nombre;
                arbitroEncontrado.Documento = arbitro.Documento;
                arbitroEncontrado.Telefono = arbitro.Telefono;
                arbitroEncontrado.Colegio = arbitro.Colegio;
                
                _appContext.SaveChanges();
            }
            return arbitroEncontrado;
        }

        IEnumerable<Arbitro> IRepositorioArbitro.SearchArbitro(string nombre)
        {
            return _appContext.Arbitro
                        .Where(p => p.Nombre.Contains(nombre));
        }
    }
}


