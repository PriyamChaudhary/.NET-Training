using System;
using Q1MovieLibrary;
class Program
{
    static void Main()
    {
        IFilmLibrary library = new FilmLibrary();

        library.AddFilm(new Film("Inception", "Christopher Nolan", 2010));
        library.AddFilm(new Film("Interstellar", "Christopher Nolan", 2014));

        Console.WriteLine("Total Films: " + library.GetTotalFilmCount());

        var searchResults = library.SearchFilms("Nolan");
        foreach (var film in searchResults)
        {
            Console.WriteLine($"{film.Title} ({film.Year}) - {film.Director}");
        }

        library.RemoveFilm("Inception");
        Console.WriteLine("Total Films After Removal: " + library.GetTotalFilmCount());
    }
}
