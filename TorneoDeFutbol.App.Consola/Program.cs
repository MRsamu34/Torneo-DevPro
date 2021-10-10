using System;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Consola
{
    class Program
    {
        private static IRepositorioMunicipio _repoMunicipio= new RepositorioMunicipio();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            AddMunicipio();
            //BuscarMunicipio();
            //MostrarMunicipio();
            //AddEstadio();
            //MostrarEstadio();

        }

//---------------- MUNICIPIO ----------- Agrega a la base de datos....

        private static void AddMunicipio()
        {
            var municipio = new Municipio
            {
                Nombre = "Meta"
               };
            _repoMunicipio.AddMunicipio(municipio);
        }

         private static void BuscarMunicipio(int idMunicipio)
        {
            var municipio = _repoMunicipio.GetMunicipio(idMunicipio);
            Console.WriteLine(municipio.Nombre);
        }
        private static void MostrarMunicipio()
        {
            var municipios = _repoMunicipio.GetAllMunicipio();
            foreach (var municipio in municipios)
            {
                Console.WriteLine(municipio.Nombre);
            }
        }

        //---------------- EQUIPO ----------- Agrega a la base de datos....

       /*   private static void AddEquipo()
        {
            var equipo = new Equipo
            {
                Nombre = "Meta",
              //  DirectorTecnico = new
               };
            _repoEquipo.AddEquipo(equipo);
        }*/
        
        //---------------- ESTADIO ----------- Agrega a la base de datos....
        // private static void AddEstadio()
        // {
        //     var municipio = _repoMunicipio.GetMunicipio(1);
            
        //     var estadio = new Estadio()
        //     {
        //         Nombre = "Atanasio Girardot",
        //         Direccion = "Cr 55 Av-Barranquilla",
        //         //Municipio = municipio
        //     };
        //     _repoEstadio.AddEstadio(estadio);
        // }
        // //Mostrando el estadio
        // private static void MostrarEstadio()
        // {
        //     var estadios = _repoEstadio.GetAllEstadios();
        //     foreach (var estadio in estadios)
        //     {
        //         Console.WriteLine(estadio.Nombre);
        //     }
        // }
    }
}
