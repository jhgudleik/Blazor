using System.ComponentModel.DataAnnotations;

namespace BlazorAcademyHW.Models
{
    public class Disciplines
    {
        [Key]
        public int discipline_id { get; set; }
        public string? discipline_name { get; set; }
        public short number_of_lessons { get; set; }
    }
}
