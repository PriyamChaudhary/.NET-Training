using System;

namespace Q1MovieLibrary;

public class FilmLibrary : IFilmLibrary
{
    private List<IFilm> _films;

    public FilmLibrary()
    {
        _films=new List<IFilm>();
    }

    public void AddFilm(IFilm film)
    {
        _films.Add(film);
    }
    public void RemoveFilm(string title)
    {
        var film = _films.FirstOrDefault(f =>
            f.Title.Equals(title, System.StringComparison.OrdinalIgnoreCase));

        if (film != null)
        {
            _films.Remove(film);
        }
        
    }
    public List<IFilm> GetFilms()
    {
        return _films;
    }
    public List<IFilm> SearchFilms(string query)
    {
        return _films.Where(fObj=>fObj.Title.Contains(query,StringComparison.OrdinalIgnoreCase) || fObj.Director.Contains(query,StringComparison.OrdinalIgnoreCase)).ToList();
        
    }
    public int GetTotalFilmCount()
    {
        return _films.Count;
    }

}

public interface IFilmLibrary
{
    void AddFilm(IFilm film);
    void RemoveFilm(string title);
    List<IFilm> GetFilms();
    List<IFilm> SearchFilms(string query);
    int GetTotalFilmCount();
    
}