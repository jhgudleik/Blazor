using System.ComponentModel.DataAnnotations;

namespace BlazorAcademyHW.Models
{
    public class Teachers
    {
        [Key]
        public int teacher_id { get; set; }

        [StringLength(50)]
        public string? last_name { get; set; }

        [StringLength(50)]
        public string? first_name { get; set; }

        [StringLength(50)]
        public string? middle_name { get; set; }

        public DateOnly? birth_date { get; set; }

        [StringLength(50)]
        public string? email { get; set; }

        [StringLength(16)]
        public string? phone { get; set; }

        public byte[]? photo { get; set; }

        public DateOnly? work_since { get; set; }

        public decimal? rate { get; set; } // smallmoney → decimal
    }
}
