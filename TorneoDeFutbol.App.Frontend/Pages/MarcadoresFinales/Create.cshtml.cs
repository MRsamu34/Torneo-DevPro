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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioMarcadorFinal _repoMarcadorFinal;
        private readonly IRepositorioPartido _repoPartido;
        private readonly IRepositorioEquipo _repoEquipo;

        public IEnumerable <Partido> partido{get; set;}
        public MarcadorFinal marcadorFinal{get; set;}
        public IEnumerable<Equipo> equipos{get; set;}


        public CreateModel(IRepositorioMarcadorFinal repoMarcadorFinal,IRepositorioEquipo repoEquipo,IRepositorioPartido repoPartido ){
            _repoMarcadorFinal = repoMarcadorFinal;
            _repoEquipo = repoEquipo;
            _repoPartido = repoPartido;
        }

        public void OnGet()
        {
            marcadorFinal = new MarcadorFinal();
            equipos = _repoEquipo.GetAllEquipo();
            partido = _repoPartido.GetAllPartido();

        }
        public IActionResult OnPost(MarcadorFinal marcadorFinal){
            if(ModelState.IsValid){
                _repoMarcadorFinal.AddMarcadorFinal(marcadorFinal);
            return RedirectToPage("Index");
            }
            else{
                return Page();
            }
            
        }
    }
}
