using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyHW.Models;

public class Groups
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int group_id { get; set; }
    public string? group_name { get; set; }
    public int direction { get; set; }
    // Навигационное свойство — связь с Directions
    public virtual Directions? Direction { get; set; }
}
