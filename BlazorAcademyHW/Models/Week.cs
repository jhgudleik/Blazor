using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAcademyHW.Models;

public class Week
{
    [Key]
    [ForeignKey("Group")]
    public int grp_id { get; set; }

    public byte study_days { get; set; } // 7 бит: Пн=1, Вт=2, Ср=4, Чт=8, Пт=16, Сб=32, Вс=64

    public virtual Groups? Group { get; set; } = null!;
}
