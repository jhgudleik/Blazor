using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        // ===== ВОЗРАСТ =====
        [NotMapped]
        public int? Age
        {
            get
            {
                if (birth_date == null)
                    return null;

                var today = DateOnly.FromDateTime(DateTime.Today);

                int age = today.Year - birth_date.Value.Year;

                if (birth_date.Value > today.AddYears(-age))
                    age--;

                return age;
            }
        }

    }
}
