using apbd_poprawa_2.Data;
using apbd_poprawa_2.DTOs;
using apbd_poprawa_2.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace apbd_poprawa_2.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;

    public DbService(DatabaseContext context)
    {
        _context = context;
    }

    public Task<CharacterDto> GetCharactersData(int characterId)
    {
        var character = _context.Characters
            .Where(e => e.CharacterId == characterId)
            .Select(e => new CharacterDto()
            {
                FirstName = e.FirstName,
                LastName = e.LastName,
                currentWeight = e.CurrentWeight,
                maxWeight = e.MaxWeight,
                Backpacks =
                {

                },
                Title = 
                {
                    
                },
            }).FirstOrDefaultAsync();
        return character;
    }
}