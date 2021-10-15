using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;
namespace TorneoDeFutbol.App.Frontend.Pages.Jugadores
{
    public class EditModel : PageModel
    {
        private readonly IRepositorioJugador _repoJugador;
        public Jugador jugador {get; set;}
        public EditModel(IRepositorioJugador repoJugador)
    {

      _repoJugador = repoJugador;
    }
    public IActionResult OnGet(int id)
        {
            jugador = _repoJugador.GetJugador(id);
            if (jugador == null)
            {
                return NotFound();
            }
            else
            {
                return Page();
            }
  
        }
    public IActionResult OnPost(Jugador jugador)
    {
       _repoJugador.UpdateJugador(jugador);
        return RedirectToPage("Index");
    }
    
    }
}
   
