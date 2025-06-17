using apbd_poprawa_2.Exceptions;
using apbd_poprawa_2.Services;
using Microsoft.AspNetCore.Mvc;

namespace apbd_poprawa_2.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CharacterController(IDbService _dbService) : ControllerBase
{
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(int id)
    {
        try
        {
            var result = await _dbService.GetCharactersData(id);
            return Ok(result);
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
        catch (Exception e)
        {
            return BadRequest(e.Message);
        }
    }
}