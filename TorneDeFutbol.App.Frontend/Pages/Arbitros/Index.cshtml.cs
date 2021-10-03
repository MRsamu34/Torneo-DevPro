using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Frontend.Pages.Arbitros
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioArbitro _repoArbitro;
        public IEnumerable<Arbitro> arbitros {get; set;}
        public IndexModel(IRepositorioArbitro repoArbitro)
        {
            _repoArbitro = repoArbitro;
        }
        public void OnGet()
        {
            arbitros = _repoArbitro.GetAllArbitro();
        }
    }
}
