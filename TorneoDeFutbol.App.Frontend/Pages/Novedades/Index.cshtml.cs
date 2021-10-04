using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Frontend.Pages.Novedades
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioNovedades _repoNovedades;
        public IEnumerable<Novedades> novedades {get;set;}
        // public IndexModel(IRepositorioNovedades repoNovedades){
        //     _repoNovedades = repoNovedades;
        // }
        public void OnGet()
        {
            // novedades = _repoNovedades.GetAllNovedades();
        }
    }
}
