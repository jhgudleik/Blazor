using System.ComponentModel.DataAnnotations;

namespace BlazorAcademyHW.Models
{
    public class Student
    {
        [Key]
        public int stud_id { get; set; }

        [Required]
        [StringLength(50)]
        public string last_name { get; set; } = null!;

        [Required]
        [StringLength(50)]
        public string first_name { get; set; } = null!;

        [StringLength(50)]
        public string? middle_name { get; set; }

        [Required]
        public DateOnly birth_date { get; set; }

        [StringLength(50)]
        public string? email { get; set; }

        [StringLength(16)]
        public string? phone { get; set; }

        public byte[]? photo { get; set; } // IMAGE → byte[]

        public int? group { get; set; }
    }
}
