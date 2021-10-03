using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Persistencia;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Frontend.Pages.Equipos
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioEquipo _repoEquipo;
        public Equipo equipo{get; set;}
        public DetailsModel(IRepositorioEquipo repoEquipo){
            _repoEquipo = repoEquipo;
        }
        public IActionResult OnGet(int id)
        {
            equipo =_repoEquipo.GetEquipo(id);
            if(equipo == null)
            {
                return NotFound();
            }else
            {
                return Page();
            }
        }
    }
}
