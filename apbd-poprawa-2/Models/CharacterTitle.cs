using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace apbd_poprawa_2.Models;

[Table("Character_Title")]
[PrimaryKey(nameof(CharacterId), nameof(Titled))]
public class CharacterTitle
{
    [ForeignKey(nameof(Character))] public int CharacterId { get; set; }
    [ForeignKey(nameof(Title))] public int Titled { get; set; }
    public DateTime AcquiredAt { get; set; }
}