using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Persistencia;
using TorneoDeFutbol.App.Dominio;


namespace TorneoDeFutbol.App.Frontend.Pages.Novedades
{
    public class CreateModel : PageModel
    {
        private readonly IRepositorioNovedad _repoNovedad;
        private readonly IRepositorioJugador _repoJugador;

        public Novedad novedad{get;set;}
        public IEnumerable<Jugador> jugador{get; set;}

        public CreateModel(IRepositorioNovedad repoNovedad,IRepositorioJugador repoJugador){
            _repoNovedad = repoNovedad;
            _repoJugador = repoJugador;
           
        }
        public void OnGet()
        {
            novedad = new Novedad();
            jugador = _repoJugador.GetAllJugador(); 
        }

        public IActionResult OnPost(Novedad novedad){
            if(ModelState.IsValid){
                _repoNovedad.AddNovedad(novedad);
            return RedirectToPage("Index");
            }
            else{
                return Page();
            }
            
        }
    }
}
