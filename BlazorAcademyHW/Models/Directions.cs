using System.ComponentModel.DataAnnotations;

namespace BlazorAcademyHW.Models;

public class Directions
{
    [Key]
    public int direction_id { get; set; }
    public string? direction_name { get; set; }
}
