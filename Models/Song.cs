using System.ComponentModel.DataAnnotations;

namespace Moment_04.Models{

    public class Song{
public int SongId {get; set;}
//Låtens namn (Måste finnas):
[Required]
public string? Song_Name { get; set; }

//Artistens namn (Måste finnas):
[Required]
public string? Song_artist { get; set; }

//Låtens Genre:
public string? Song_genre { get; set; }

//Låtens längd:
public int Song_length { get; set; }
    }
}