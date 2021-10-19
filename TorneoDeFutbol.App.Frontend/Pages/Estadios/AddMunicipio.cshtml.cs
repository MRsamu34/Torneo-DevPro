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
    public class AddMunicipioModel : PageModel
    {
        private readonly IRepositorioEstadio _repoEstadio;
        private readonly IRepositorioMunicipio _repoMunicipio;
        public Estadio estadio { get; set; }
        public IEnumerable<Municipio> municipios {get; set;}
        public AddMunicipioModel(IRepositorioEstadio repoEstadio, IRepositorioMunicipio repoMunicipio)
        {
            _repoEstadio = repoEstadio;
            _repoMunicipio = repoMunicipio;
        }
        public void OnGet(int id)
        {
            estadio = _repoEstadio.GetEstadio(id);
            municipios = _repoMunicipio.GetAllMunicipio();
        }
        public IActionResult OnPost(int idEstadio, int idMunicipio)
        {
            Console.WriteLine(idEstadio + " " + idMunicipio);
            _repoEstadio.AgregarMunicipio(idEstadio, idMunicipio);
            return RedirectToPage("Details", new{id = idEstadio});
        }
    }
}