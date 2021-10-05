using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Persistencia;
using TorneoDeFutbol.App.Dominio;


namespace TorneoDeFutbol.App.Frontend.Pages.Novedades
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioNovedad _repoNovedad;
        public IEnumerable<Novedad> novedad {get;set;}
        public IndexModel(IRepositorioNovedad repoNovedad){
            _repoNovedad = repoNovedad;
        }
        public void OnGet()
        {
            novedad = _repoNovedad.GetAllNovedad();
        }
    }
}
