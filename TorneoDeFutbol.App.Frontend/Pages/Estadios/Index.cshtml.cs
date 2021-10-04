using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Frontend.Pages.Estadios
{
    public class IndexModel : PageModel
    {
        private readonly IRepositorioEstadio _repoEstadio;
        public IEnumerable<Estadio> estadios { get; set; }
        public IndexModel(IRepositorioEstadio repoEstadio)
        {
            _repoEstadio = repoEstadio;
        }
        public void OnGet()
        {
            estadios = _repoEstadio.GetAllEstadios();
        }
    }
}