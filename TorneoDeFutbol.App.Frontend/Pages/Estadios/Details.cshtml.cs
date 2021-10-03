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
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioEstadio _repoEstadio;
        public Estadio estadio { get; set; }
        public DetailsModel(IRepositorioEstadio repoEstadio)
        {
            _repoEstadio = repoEstadio;
        }
        public IActionResult OnGet(int id)
        {
            estadio = _repoEstadio.GetEstadio(id);
            if (estadio == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
    }
}
