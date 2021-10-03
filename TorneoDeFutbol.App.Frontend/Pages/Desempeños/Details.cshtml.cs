using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Frontend.Pages.Desempeños
{

    public class DetailsModel : PageModel
    {
        private readonly IRepositorioDesempeño _repoDesempeño;
        public Desempeño desempeño { get; set; }
        public DetailsModel(IRepositorioDesempeño repoDesempeño)
        {
            _repoDesempeño = repoDesempeño;
        }
        public IActionResult OnGet(int id)
        {
            desempeño = _repoDesempeño.GetDesempeño(id);
            if (desempeño == null)
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
