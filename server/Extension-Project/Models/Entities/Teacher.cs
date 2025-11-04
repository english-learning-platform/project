using Extension_Project.Models.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Claims;

namespace Extension_Project.Models.Entities
{
    public class Teacher
    {
        [Key]
        public int TeacherID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }

        [ForeignKey("Manager")]
        public int ManagerID { get; set; }
        public Manager Manager { get; set; }

        public ICollection<Lesson> Lessons { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
        public ICollection<SchoolClass> SchoolClasses { get; set; }
    }
}
