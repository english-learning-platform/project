using Extension_Project.Models.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Extension_Project.Models.Entities
{
    public class Assignment
    {
        [Key]
        public int TaskID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Content { get; set; }

        [ForeignKey("Topic")]
        public int TopicID { get; set; }
        public Topic Topic { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherID { get; set; }
        public Teacher Teacher { get; set; }

        public ICollection<LessonAssignment> LessonAssignments { get; set; }
    }
}
