using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Frontend.Pages.Partidos
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        public Partido partido {get; set;}
        public EditModel(IRepositorioPartido repoPartido)
        {
            _repoPartido = repoPartido;
        }
        public IActionResult OnGet(int id)
        {
            partido =_repoPartido.GetPartido(id);
            if(partido == null)
            {
                return NotFound();
            }else
            {
                return Page();
            }
        }
          public IActionResult OnPost(Partido partido)
        {
            if (ModelState.IsValid)
            {
                _repoPartido.UpdatePartido(partido);
                 return RedirectToPage("Index");
       
            }
           else
           {
               return Page();
           }
        }
    }
}
