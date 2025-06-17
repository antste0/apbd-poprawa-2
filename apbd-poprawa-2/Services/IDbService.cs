using apbd_poprawa_2.DTOs;

namespace apbd_poprawa_2.Services;

public interface IDbService
{
    Task<CharacterDto> GetCharactersData(int characterId);
}