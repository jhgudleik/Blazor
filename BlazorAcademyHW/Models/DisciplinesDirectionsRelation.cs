using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BlazorAcademyHW.Models
{
    // Промежуточная таблица связей между Направлениями и Дисциплинами
    public class DisciplinesDirectionsRelation
    {
        // В SQL используется tinyint
        public int direction { get; set; }

        // В SQL используется smallint
        public int discipline { get; set; }

        [ForeignKey("direction")]
        public Directions DirectionNavigation { get; set; } = null!;

        [ForeignKey("discipline")]
        public Disciplines DisciplineNavigation { get; set; } = null!;
    }
}
