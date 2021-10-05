using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TorneoDeFutbol.App.Persistencia;
using TorneoDeFutbol.App.Dominio;

namespace TorneoDeFutbol.App.Frontend.Pages.Jugadores
{
        public class IndexModel : PageModel
        {
            private readonly IRepositorioJugador _repoJugador;
            public IEnumerable<Jugador> jugador {get; set;}
            public IndexModel(IRepositorioJugador repoJugador)
        {
            _repoJugador = repoJugador;
        }
        public void OnGet()
        {
            jugador = _repoJugador.GetAllJugador();
        }
    }
}
    

