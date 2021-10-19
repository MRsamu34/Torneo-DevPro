using System;
using TorneoDeFutbol.App.Dominio;
using TorneoDeFutbol.App.Persistencia;

namespace TorneoDeFutbol.App.Consola
{
    class Program
    {
        private static IRepositorioMunicipio _repoMunicipio= new RepositorioMunicipio();
        private static IRepositorioEstadio _repoEstadio = new RepositorioEstadio();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddMunicipio();
            //BuscarMunicipio();
            //MostrarMunicipio();
            //AddDirectorTecnico();
            //BuscarDirectorTecnico();
            //MostrarDirectoresTecnicos();
            AddEstadio();
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

        //---------------- DIRECTOR TECNICO ----------- Agrega a la base de datos....

        /*private static void AddDirectorTecnico()
        {
            var directorTecnico = new DirectorTecnico
            {
                Nombre = "Rafael",
                Documento = "1010",
                NumeroTelefono = "2648840",

               };
            _repoDirectorTecnico.AddDirectorTecnico(directorTecnico);
        }

        private static void BuscarDirectorTecnico(int idDirectorTecnico)
        {
            var directorTecnico = _repoDirectorTecnico.GetDirectorTecnico(idDirectorTecnico);
            Console.WriteLine(directorTecnico.Nombre);
        }

        private static void MostrarDirectoresTecnicos()
        {
            var directoresTecnicos = _repoDirectorTecnico.GetAllDirectoresTecnicos();
            foreach (var directorTecnico in directoresTecnicos)
            {
                Console.WriteLine(directorTecnico.Nombre);
            }
        }*/

        //------------EQUIPO -----------Agrega a la base de datos ------

        /*private static void AddEquipo()
        {
            var equipo = new Equipo
            {
                Nombre = "Tolima",
                //Tengo una duda aqui como hago la relacion con el id de municipio, director tecnico y jugador
                DirectorTecnico = DirectorTecnico.Nombre,
                Municipio = Municipio.Nombre,
                Jugadores =.................,


               };
            _repoEquipo.AddEquipo(equipo);
        }*/

        //---------------- ESTADIO ----------- Agrega a la base de datos....
         private static void AddEstadio()
         {
             var municipio = _repoMunicipio.GetMunicipio(1);
             int id = municipio.Id;
             var estadio = new Estadio()
             {
                 Nombre = "Carlos Restrepo",
                 Direccion = "Cr 58 #32-20",
                 Municipio = id
             };
             _repoEstadio.AddEstadio(estadio);
         }
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
