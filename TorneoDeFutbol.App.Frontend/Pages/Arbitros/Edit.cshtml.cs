using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Frontend.Pages.Arbitros
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioArbitro _repoArbitro;
        public Arbitro arbitro {get; set;}
        public EditModel(IRepositorioArbitro repoArbitro)
        {
            _repoArbitro = repoArbitro;
        }
        public IActionResult OnGet(int id)
        {
            arbitro =_repoArbitro.GetArbitro(id);
            if(arbitro == null)
            {
                return NotFound();
            }else
            {
                return Page();
            }
        }
          public IActionResult OnPost(Arbitro arbitro)
        {
            if (ModelState.IsValid)
            {
                _repoArbitro.UpdateArbitro(arbitro);
                 return RedirectToPage("Index");
       
            }
           else
           {
               return Page();
           }
        }
    }
}
