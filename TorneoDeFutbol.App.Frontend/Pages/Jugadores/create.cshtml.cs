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
    public class createModel : PageModel
     {
        private readonly IRepositorioJugador _repoJugador;
        public Jugador jugador {get; set;}
        public createModel(IRepositorioJugador repoJugador)
        {
            _repoJugador = repoJugador;
        }
        public void OnGet()
        {
            jugador = new Jugador();
        }
        public IActionResult OnPost(Jugador jugador)
        {
                _repoJugador.AddJugador(jugador);
                return RedirectToPage("Index");
       
        }

           
    }
}
