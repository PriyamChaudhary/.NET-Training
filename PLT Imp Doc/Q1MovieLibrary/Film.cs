using System;

namespace Q1MovieLibrary;

public class Film : IFilm
{
    public string Title {get; set;}
    public string Director {get; set;}
    public int Year {get; set;}

    public Film(string title, string director, int year)
    {
        Title=title;
        Director=director;
        Year=year;
    }


}

public interface IFilm
{
    string Title {get; set;}
    string Director {get; set;}
    int Year {get; set;}
    
}