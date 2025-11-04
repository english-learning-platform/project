using Extension_Project.Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Extension_Project.Models.Entities
{
    public class ClassLesson
    {
        [ForeignKey("SchoolClass")]
        public int SchoolClassID { get; set; }
        public SchoolClass SchoolClass { get; set; }

        [ForeignKey("Lesson")]
        public int LessonID { get; set; }
        public Lesson Lesson { get; set; }
    }
}
