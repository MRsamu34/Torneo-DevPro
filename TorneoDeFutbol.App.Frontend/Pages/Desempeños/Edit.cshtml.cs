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
    public class EditModel : PageModel
    {
       private readonly IRepositorioDesempeño _repoDesempeño;
        public Desempeño desempeño {get; set;}
        public EditModel(IRepositorioDesempeño repoDesempeño)
        {
            _repoDesempeño = repoDesempeño;
        }
        public IActionResult OnGet(int Id)
        {
            desempeño = _repoDesempeño.GetDesempeño(Id);
            if (desempeño == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
        }
        public IActionResult OnPost(Desempeño desempeño)
        {
            if (ModelState.IsValid)
            {
            _repoDesempeño.UpdateDesempeño(desempeño);
            return RedirectToPage("Index");
            }
            else 
            {
                return Page();
            }
        }
    }
}
