using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Persistencia;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Frontend.Pages.MarcadoresFinales
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioMarcadorFinal _repoMarcadorFinal;
        public IEnumerable<MarcadorFinal> marcadorFinal {get; set;}
        public string bActual{get; set;}
        public IndexModel(IRepositorioMarcadorFinal repoMarcadorFinal){
            _repoMarcadorFinal = repoMarcadorFinal;
        }
        public void OnGet(string b)
        {
            if(String.IsNullOrEmpty(b))
            {
                bActual = "";
                marcadorFinal = _repoMarcadorFinal.GetAllMarcadorFinal();
            }
            // else
            // {
            //     bActual = b;
            //     marcadorFinal = _repoMarcadorFinal.SearchMarcadorFinal(b);
            // }
            
        }
    }
}
