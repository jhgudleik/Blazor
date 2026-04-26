using System.ComponentModel.DataAnnotations;

namespace BlazorAcademyHW.Models;

public class Groups
{
    [Key]
    public int group_id { get; set; }
    public string? group_name { get; set; }
    public int direction { get; set; }
    // Навигационное свойство — связь с Directions
    public virtual Directions? Direction { get; set; }
}
