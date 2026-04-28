using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorAcademyHW.Models
{
    // Промежуточная таблица связей
    public class TeachersDisciplinesRelation
    {
        public int teacher { get; set; }
        public int discipline { get; set; }

        [ForeignKey("teacher")]
        public Teachers TeacherNavigation { get; set; } = null!;

        [ForeignKey("discipline")]
        public Disciplines DisciplineNavigation { get; set; } = null!;
    }
}
