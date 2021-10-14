using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Persistencia;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Frontend.Pages.Partidos
{
    public class createModel : PageModel
    {
        private readonly IRepositorioPartido _repoPartido;
        public Partido partido {get; set;}
        public createModel(IRepositorioPartido repoPartido)
    {
        _repoPartido = repoPartido;
    }
        public void OnGet()
        {
            partido = new Partido();
        
        }
        public IActionResult OnPost(Partido partido)
        {
            if (ModelState.IsValid)
            {
                _repoPartido.AddPartido(partido);
                 return RedirectToPage("Index");
       
            }
           else
           {
               return Page();
           }
        }
    }
}
    

