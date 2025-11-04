using Extension_Project.Models.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Extension_Project.Models.Entities
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public User User { get; set; }

        [ForeignKey("SchoolClass")]
        public int SchoolClassID { get; set; }
        public SchoolClass SchoolClass { get; set; }

        public ICollection<ParentStudent> ParentStudents { get; set; }
        public ICollection<Progress> ProgressRecords { get; set; }
    }
}
