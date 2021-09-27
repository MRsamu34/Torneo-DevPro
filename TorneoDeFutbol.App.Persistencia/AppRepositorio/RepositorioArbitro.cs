using System.Collections.Generic;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Persistencia
{
    public class RepositorioArbitro : IRepositorioArbitro
    {
        private readonly AppContext _appContext = new AppContext();

        public Arbitro AddArbitro(Arbitro arbitro)/////////
        {
            var ArbitroAdicionado = _appContext.Arbitro.Add(arbitro);
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
                
                _appContext.SaveChanges();
            }
            return arbitroEncontrado;
        }
    }
}


