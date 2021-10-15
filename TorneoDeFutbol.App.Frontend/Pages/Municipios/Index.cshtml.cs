using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

namespace Torneo.App.Frontend.Pages.Municipios
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioMunicipio _repoMunicipio;
        public string bActual {get; set;}
        public IEnumerable<Municipio> municipios {get; set;}
        public IndexModel(IRepositorioMunicipio repoMunicipio)
        {
            _repoMunicipio = repoMunicipio;
        }
           public void OnGet(int? g, string b)
        {
            if (String.IsNullOrEmpty(b))
            {
                bActual = "";
                municipios = _repoMunicipio.GetAllMunicipio();
            }
            else{
               bActual = b;
               municipios = _repoMunicipio.SearchMunicipio(b);
             }
        }
    }
}
