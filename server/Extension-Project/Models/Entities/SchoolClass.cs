using Extension_Project.Models.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Extension_Project.Models.Entities
{
    public class SchoolClass
    {
        [Key]
        public int ClassID { get; set; }
        public string Name { get; set; }

        [ForeignKey("Manager")]
        public int ManagerID { get; set; }
        public Manager Manager { get; set; }

        [ForeignKey("Teacher")]
        public int TeacherID { get; set; }
        public Teacher Teacher { get; set; }

        public ICollection<Student> Students { get; set; }
        public ICollection<ClassLesson> ClassLessons { get; set; }
    }
}
