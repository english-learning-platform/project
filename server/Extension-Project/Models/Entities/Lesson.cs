using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Extension_Project.Models.Entities
{
    public class Lesson
    {
        [Key]
        public int LessonID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Public { get; set; }

        [ForeignKey("Topic")]
        public int TopicID { get; set; }
        public Topic Topic { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherID { get; set; }
        public Teacher Teacher { get; set; }

        public ICollection<ClassLesson> ClassLessons { get; set; }
        public ICollection<LessonAssignment> LessonAssignments { get; set; }
        public ICollection<Progress> ProgressRecords { get; set; }
    }
}
