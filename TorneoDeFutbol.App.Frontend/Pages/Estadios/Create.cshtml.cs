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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioEstadio _repoEstadio;
        private readonly IRepositorioMunicipio _repoMunicipio;
        public IEnumerable<Municipio> municipios {get; set;}
        public Estadio estadio {get; set;}
        public CreateModel(IRepositorioEstadio repoEstadio, IRepositorioMunicipio repoMunicipio)
        {
            _repoEstadio = repoEstadio;
            _repoMunicipio = repoMunicipio;

        }
        public void OnGet(int id)
        {
            estadio = new Estadio();
            municipios = _repoMunicipio.GetAllMunicipio();
        }
        public IActionResult OnPost(Estadio estadio, int idMunicipio)
        {
            if(ModelState.IsValid)
            {
                _repoEstadio.AddEstadio(estadio);
                //_repoEstadio.AgregarMunicipio(idMunicipio);
                Console.WriteLine(idMunicipio);
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
