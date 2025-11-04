using Extension_Project.Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Extension_Project.Models.Entities
{
    public class LessonAssignment
    {
        [ForeignKey("Lesson")]
        public int LessonID { get; set; }
        public Lesson Lesson { get; set; }

        [ForeignKey("Assignment")]
        public int AssignmentID { get; set; }
        public Assignment Assignment { get; set; }
    }
}
