using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Frontend.Pages.Desempeños
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioDesempeño _repoDesempeño;
        public IEnumerable<Desempeño> desempeños { get; set; }
        public IndexModel(IRepositorioDesempeño repoDesempeño)
        {
            _repoDesempeño = repoDesempeño;
        }
        public void OnGet()
        {
            desempeños = _repoDesempeño.GetAllDesempeños();
        }
    }
}
