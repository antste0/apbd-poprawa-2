using apbd_poprawa_2.Models;

namespace apbd_poprawa_2.DTOs;

public class CharacterDto
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int currentWeight { get; set; }
    public int maxWeight { get; set; }
    public List<BackpackItemsDto> Backpacks { get; set; }
    public List<TitleDto> Title { get; set; }
}

public class BackpackItemsDto
{
    public int CharacterId { get; set; }
    public int ItemId { get; set; }
    public List<ItemDto> Items { get; set; }
}

public class ItemDto
{
    public string ItemName { get; set; }
    public int ItemWeight { get; set; }
    public int Amount { get; set; }
}

public class Title
{
    public string Name { get; set; }
    public DateTime AcquiredAt { get; set; }
}

public class TitleDto
{
    public int TitleId { get; set; }
    public string Name { get; set; }
}
