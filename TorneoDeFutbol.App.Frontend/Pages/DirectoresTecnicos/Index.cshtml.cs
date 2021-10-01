using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Persistencia;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Frontend.Pages.DirectoresTecnicos
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioDirectorTecnico _repoDirectorTecnico;
        public IEnumerable<DirectorTecnico> directoresTecnicos {get; set;}
        public IndexModel(IRepositorioDirectorTecnico repoDirectorTecnico){
            _repoDirectorTecnico = repoDirectorTecnico;
        }
        public void OnGet()
        {
            directoresTecnicos = _repoDirectorTecnico.GetAllDirectorTecnico();
        }
    }
}
