using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Persistencia;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Frontend.Pages.MarcadoresFinales
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioMarcadorFinal _repoMarcadorFinal;
        public MarcadorFinal marcadorFinal{get; set;}
        public EditModel(IRepositorioMarcadorFinal repoMarcadorFinal){
            _repoMarcadorFinal = repoMarcadorFinal;
        }
        public IActionResult OnGet(int id)
        {
            marcadorFinal = _repoMarcadorFinal.GetMarcadorFinal(id);
            if(marcadorFinal == null)
            {
                return NotFound();
            }else
            {
                return Page();
            }

        }

         public IActionResult OnPost(MarcadorFinal marcadorFinal){
            _repoMarcadorFinal.UpdateMarcadorFinal(marcadorFinal);
            return RedirectToPage("Index");
        }
    }
}
