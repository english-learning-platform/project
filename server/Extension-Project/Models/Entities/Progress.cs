using Extension_Project.Models.Entities;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Extension_Project.Models.Entities
{
    public class Progress
    {
        [Key]
        public int ProgressID { get; set; }

        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public Student Student { get; set; }

        [ForeignKey("Lesson")]
        public int LessonID { get; set; }
        public Lesson Lesson { get; set; }

        public decimal Score { get; set; }
        public DateTime Date { get; set; }
    }
}
