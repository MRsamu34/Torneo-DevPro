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
    public class EditModel : PageModel
    {
        private readonly IRepositorioEstadio _repoEstadio;
        private readonly IRepositorioMunicipio _repoMunicipio;
        public Estadio estadio {get; set;}
        public IEnumerable<Municipio> municipios {get; set;}
        public EditModel(IRepositorioEstadio repoEstadio, IRepositorioMunicipio repoMunicipio)
        {
            _repoEstadio = repoEstadio;
            _repoMunicipio = repoMunicipio;
        }
        public IActionResult OnGet(int Id)
        {
            estadio = _repoEstadio.GetEstadio(Id);
            municipios = _repoMunicipio.GetAllMunicipio();
            if (estadio == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Estadio estadio)
        {
            if (ModelState.IsValid)
            {
                _repoEstadio.UpdateEstadio(estadio);
                return RedirectToPage("Index");
            }
            else 
            {
                return Page();
            }
        }
    }
}
