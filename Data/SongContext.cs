using Microsoft.EntityFrameworkCore;
using Moment_04.Models;

namespace Moment_04.Data{

// Klassen ärver från DbContext:
public class SongContext : DbContext {
    // Konstruktor för SongContext:
    public SongContext(DbContextOptions<SongContext> options) : base(options)
    {
        // Tom konstruktor, basen hanteras av DbContextOptions
    }

    // DbSet för att representera entiteten Song i databasen:
    public DbSet<Song> Songs { get; set; }
    }
}