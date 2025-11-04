using Extension_Project.Models.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Extension_Project.Models.Entities
{
    public class ParentStudent
    {
        [ForeignKey("Parent")]
        public int ParentID { get; set; }
        public Parent Parent { get; set; }

        [ForeignKey("Student")]
        public int StudentID { get; set; }
        public Student Student { get; set; }
    }
}
