using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace apbd_poprawa_2.Models;

[Table("Title")]
public class Title
{
    [Key]
    public Guid TitleId { get; set; }
    [MaxLength(100)]
    public string Name { get; set; }
}