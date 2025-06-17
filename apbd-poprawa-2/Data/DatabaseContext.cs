using apbd_poprawa_2.Models;
using Microsoft.EntityFrameworkCore;

namespace apbd_poprawa_2.Data;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) {}
    
    public DbSet<Item> Items { get; set; }
    public DbSet<Backpack> Backpacks { get; set; }
    public DbSet<Character> Characters { get; set; }
    public DbSet<CharacterTitle> CharacterTitles { get; set; }
    public DbSet<Title> Titles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Item>().HasData(new List<Item>()
        {
            new Item() {ItemId = 1, Name = "item1", Weight = 1},
            new Item() { ItemId = 2, Name = "item2", Weight = 1},
            new Item() { ItemId = 3, Name = "item3", Weight = 1},
        });

        modelBuilder.Entity<Backpack>().HasData(new List<Backpack>()
        {
            new Backpack() {Amount = 1, ItemId = 1, CharacterId = 1},
            new Backpack() {Amount = 2, ItemId = 2, CharacterId = 1},
            new Backpack() {Amount = 3, ItemId = 3, CharacterId = 2},
        });

        modelBuilder.Entity<Character>().HasData(new List<Character>()
        {
            new Character()
                { CharacterId = 1, CurrentWeight = 1, MaxWeight = 6, FirstName = "first", LastName = "last" },
            new Character()
                { CharacterId = 2, CurrentWeight = 2, MaxWeight = 10, FirstName = "first", LastName = "last" },
        });

        modelBuilder.Entity<CharacterTitle>().HasData(new List<CharacterTitle>()
        {
            new CharacterTitle() { AcquiredAt = DateTime.Now, CharacterId = 1, Titled = 1 }
        });

        modelBuilder.Entity<CharacterTitle>().HasData(new List<CharacterTitle>()
        {
            new CharacterTitle() { AcquiredAt = DateTime.Now, CharacterId = 2, Titled = 2 }
        });
    }
}